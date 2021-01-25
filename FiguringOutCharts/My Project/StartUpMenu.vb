Imports MySql.Data.MySqlClient
Public Class StartUpMenu
    Private MainMenu As New MainMenu
    Private ConnStr As String
    Private DDLstr As String
    Private SQLstr As String
    Private MyCommand As MySqlCommand
    Private MyConnection As MySqlConnection
    Private AccountID As String
    Private FirstName As String
    Private Surname As String
    Private Password As String
    Private IsTeacher As Boolean
    Private TeacherID As String

    Private Sub ExitProgram_Click(sender As Object, e As EventArgs) Handles ExitProgram.Click
        End
    End Sub
    Private Sub UseGuest_Click(sender As Object, e As EventArgs) Handles UseGuest.Click
        MainMenu.LogIn("0", False) 'I've treated the guest user as a student with accountID of zero. They can't click any of the buttons that would cause problems, so this works fine.
        MainMenu.Show()
        Hide()
    End Sub

    Private Sub LogIn_Click(sender As Object, e As EventArgs) Handles LogIn.Click
        Dim ValidAccount As Boolean = True
        Dim CorrectPassword As Boolean = True
        OpenDatabase() 'Opens the database full of accounts
        Do
            ValidAccount = True
            Try
                AccountID = InputBox("Enter your account ID")
                If AccountID.Length = 3 Then 'Teacher's have an ID of length 3, whereas students have a length of 6, allowing me to differentiate between them easily
                    SQLstr = "SELECT Password FROM Teachers WHERE TeacherID = '" & AccountID & "'"
                    IsTeacher = True
                ElseIf AccountID.Length = 6 Then
                    SQLstr = "SELECT Password FROM Students WHERE StudentID = '" & AccountID & "'"
                    IsTeacher = False
                End If '^^Sets the SQL query to retrieve the password from the relevant table for the given ID
                MyCommand = New MySqlCommand(SQLstr, MyConnection)
                MyCommand.CommandType = CommandType.Text
                Password = MyCommand.ExecuteScalar 'Executes the SQL query and stores the result in the password variable
                If Password = "" Then 'This will only trigger if the database returns a null value for the password, which would mean that the account does not exist.
                    MsgBox("Account does not exist, please try again")
                    ValidAccount = False 'Causes the do loop to keep iterating until a valid account is entered
                End If
            Catch ex As Exception
                MsgBox(ex.Message) 'Returns an error message if something goes wrong in accessing the database
            End Try
        Loop Until ValidAccount
        Do
            CorrectPassword = True
            If InputBox("Please enter your password") <> Password Then
                CorrectPassword = False
                MsgBox("Incorrect Password")
            End If
        Loop Until CorrectPassword 'Only lets the user progress if they get the password correct for the account they entered
        MyConnection.Close()
        MainMenu.LogIn(AccountID, IsTeacher) 'Opens the main menu and logs the user in
        MainMenu.Show()
        Hide()
    End Sub

    Private Sub CreateAccount_Click(sender As Object, e As EventArgs) Handles CreateAccount.Click
        Password = ""
        Select Case MsgBox("Are you a teacher? (If you are not a teacher then you are a student)", vbYesNoCancel)
            Case vbYes
                IsTeacher = True
            Case vbNo
                IsTeacher = False
        End Select
        Do
            AccountID = InputBox("Please enter your user ID")
        Loop Until ValidateAccountID(IsTeacher, AccountID)
        FirstName = InputBox("Please enter your first name")
        Surname = InputBox("Please enter your surname")
        Do
            If Password <> "" Then MsgBox("Your passwords did not match")
            Do
                Password = InputBox("Please choose a password")
            Loop Until ValidatePassword(Password)
        Loop Until InputBox("Please confirm your password") = Password
        If IsTeacher = False Then TeacherID = InputBox("Please enter your teacher's ID")
        MakeAccount(AccountID, FirstName, Surname, Password, IsTeacher, TeacherID)
        MainMenu.LogIn(AccountID, IsTeacher)
        MainMenu.Show()
        Hide()
    End Sub

    Public Function ValidateAccountID(IsTeacher As Boolean, AccountID As String)
        Dim Number As New System.Text.RegularExpressions.Regex("[0-9]") 'Regex is used here to make sure that the IDs fit the format they should fit for the type of account they represent
        Dim Upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        If IsTeacher = True And AccountID.Length <> 3 Or IsTeacher = True And Upper.Matches(AccountID).Count <> AccountID.Length Then
            MsgBox("Your ID must be three characters in length and must contain only upper case letters")
            Return False
        ElseIf IsTeacher = False And AccountID.Length <> 6 Or (IsTeacher = False And Number.Matches(AccountID).Count <> AccountID.Length) Then
            MsgBox("Your ID must be six characters in length and must contain only numbers")
            Return False
        End If
        Return True
    End Function
    Public Function ValidatePassword(Password As String)
        Dim Upper As New System.Text.RegularExpressions.Regex("[A-Z]") 'This forces the user to choose a password with a mixture of upper case, lower case, and numbers for security purposes
        Dim Lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim Number As New System.Text.RegularExpressions.Regex("[0-9]")
        Dim Special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")
        If Upper.Matches(Password).Count < 1 Or Lower.Matches(Password).Count < 1 Or Number.Matches(Password).Count < 1 Or Special.Matches(Password).Count <> 0 Then
            MsgBox("Your password must include a mixture of upper case, lower case, numbers, and must have no special characters.")
            Return False
        End If
        Return True
    End Function

    Public Sub MakeAccount(AccountID As String, FirstName As String, Surname As String, Password As String, IsTeacher As Boolean, TeacherID As String)
        If IsTeacher = True Then
            DDLstr = "CREATE TABLE IF NOT EXISTS Teachers
(TeacherID Char(3) NOT NULL PRIMARY KEY,
FirstName Varchar(25),
Surname Varchar(25),
Password Varchar(25))"
        Else
            DDLstr = "CREATE TABLE IF NOT EXISTS Students
(StudentID Char(6) NOT NULL PRIMARY KEY,
FirstName Varchar(25),
Surname Varchar(25),
Password Varchar(25),
TeacherID Char(3))"
        End If
        OpenDatabase() '^^If the table being accessed doesnt already exist then it is created with the necessary features
        ExecuteCommand(DDLstr)
        If IsTeacher = True Then
            SQLstr = "INSERT INTO Teachers(TeacherID, FirstName, Surname, Password) VALUES ('" & AccountID & "','" & FirstName & "','" & Surname & "','" & Password & "')"
        Else
            SQLstr = "INSERT INTO Students(StudentID, FirstName, Surname, Password, TeacherID) VALUES ('" & AccountID & "','" & FirstName & "','" & Surname & "','" & Password & "','" & TeacherID & "')"
        End If
        ExecuteCommand(SQLstr)
        MyConnection.Close()
    End Sub

    Public Sub ExecuteCommand(Commstr As String) 'Basic sub to execute standard SQL or DDL commands that don't have a special format to them
        Try
            MyCommand = New MySqlCommand(Commstr, MyConnection)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub OpenDatabase() 'Sub to create and open the database when it needs to be accessed elsewhere in the class
        Try
            ConnStr = "server=localhost;user=Dev;port=3306;password=Turtwig;" 'The connection string needs to be changed to be on the database level rather than the entity level
            MyConnection = New MySqlConnection(ConnStr)
            MyConnection.Open()
            MyCommand = New MySqlCommand("CREATE DATABASE IF NOT EXISTS `simaccounts`;", MyConnection)
            MyCommand.ExecuteNonQuery()
            MyConnection.Close()
            ConnStr = "server=localhost;user=Dev;port=3306;database=simaccounts;password=Turtwig;" 'Changes the connection string back
            MyConnection = New MySqlConnection(ConnStr)
            MyConnection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class