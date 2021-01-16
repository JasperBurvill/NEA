Imports MySql.Data.MySqlClient
Public Class StartUpMenu
    Private ConnStr As String = "server=localhost;user=Dev;port=3306;password=Turtwig;"
    Private DDLstr As String
    Private SQLstr As String
    Private MyCommand As MySqlCommand
    Private MyConnection As MySqlConnection
    Private MyReader As MySqlDataReader
    Private AccountID As String
    Private FirstName As String
    Private Surname As String
    Private Password As String
    Private IsTeacher As Boolean
    Private ClassID As String
    Private Sub StartUpMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitProgram_Click(sender As Object, e As EventArgs) Handles ExitProgram.Click
        End
    End Sub
    Private Sub UseGuest_Click(sender As Object, e As EventArgs) Handles UseGuest.Click
        Dim MainMenu As New MainMenu
        MainMenu.Show()
        Hide()
    End Sub

    Private Sub LogIn_Click(sender As Object, e As EventArgs) Handles LogIn.Click
        Dim ValidAccount As Boolean = True
        Dim CorrectPassword As Boolean = True
        ConnStr = "server=localhost;user=Dev;port=3306;database=simaccounts;password=Turtwig;"
        OpenDatabase()
        Do
            ValidAccount = True
            Try
                AccountID = InputBox("Enter your account ID")
                If AccountID.Length = 3 Then
                    SQLstr = "SELECT Password FROM Teachers WHERE TeacherID = '" & AccountID & "'"
                ElseIf AccountID.Length = 6 Then
                    SQLstr = "SELECT Password FROM Students WHERE StudentID = '" & AccountID & "'"
                End If
                MyCommand = New MySqlCommand(SQLstr, MyConnection)
                MyCommand.CommandType = CommandType.Text
                Password = MyCommand.ExecuteScalar
                If Password = "" Then
                    MsgBox("Account does not exist, please try again")
                    ValidAccount = False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Loop Until ValidAccount
        Do
            CorrectPassword = True
            If InputBox("Please enter your password") = Password Then
                MsgBox("Logged in")
            Else
                MsgBox("Incorrect Password")
                CorrectPassword = False
            End If
        Loop Until CorrectPassword

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
        ClassID = InputBox("Please enter your class")
        MakeAccount(AccountID, FirstName, Surname, Password, IsTeacher, ClassID)
    End Sub

    Public Function ValidateAccountID(IsTeacher As Boolean, AccountID As String)
        Dim Number As New System.Text.RegularExpressions.Regex("[0-9]")
        Dim Upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        If IsTeacher = True And AccountID.Length <> 3 Or Upper.Matches(AccountID).Count <> AccountID.Length Then
            MsgBox("Your ID must be three characters in length and must contain only upper case letters")
            Return False
        ElseIf IsTeacher = False And AccountID.Length <> 6 Or Number.Matches(AccountID).Count <> AccountID.Length Then
            MsgBox("Your ID must be six characters in length and must contain only numbers")
            Return False
        End If
        Return True
    End Function
    Public Function ValidatePassword(Password)
        Dim Upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim Lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim Number As New System.Text.RegularExpressions.Regex("[0-9]")
        Dim Special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")
        If Upper.Matches(Password).Count < 1 Or Lower.Matches(Password).Count < 1 Or Number.Matches(Password).Count < 1 Or Special.Matches(Password).Count <> 0 Then
            MsgBox("Your password must include a mixture of upper case, lower case, numbers, and must have no special characters.")
            Return False
        End If
        Return True
    End Function

    Public Sub MakeAccount(AccountID, FirstName, Surname, Password, IsTeacher, ClassID)
        ConnStr = "server=localhost;user=Dev;port=3306;database=simaccounts;password=Turtwig;"
        If IsTeacher = True Then
            DDLstr = "CREATE TABLE Teachers
(TeacherID Char(3) NOT NULL PRIMARY KEY,
FirstName Varchar(25),
Surname Varchar(25),
Password Varchar(25),
ClassID Varchar(3))"
        Else
            DDLstr = "CREATE TABLE Students
(StudentID Char(6) NOT NULL PRIMARY KEY,
FirstName Varchar(25),
Surname Varchar(25),
Password Varchar(25),
ClassID Varchar(3))"
        End If
        OpenDatabase()
        ExecuteCommand(DDLstr)
        If IsTeacher = True Then
            SQLstr = "INSERT INTO Teachers(TeacherID, FirstName, Surname, Password, ClassID) VALUES ('" & AccountID & "','" & FirstName & "','" & Surname & "','" & Password & "','" & ClassID & "')"
        Else
            SQLstr = "INSERT INTO Students(StudentID, FirstName, Surname, Password, ClassID) VALUES ('" & AccountID & "','" & FirstName & "','" & Surname & "','" & Password & "','" & ClassID & "')"
        End If
        ExecuteCommand(SQLstr)
        MyConnection.Close()
        MainMenu.LogIn(AccountID, Password)
    End Sub
    Public Sub ExecuteCommand(SQLstr)
        Try
            MyCommand = New MySqlCommand(SQLstr, MyConnection)
            MyCommand.ExecuteNonQuery()
            MsgBox("Successfully executed command")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub OpenDatabase()
        Try
            MyConnection = New MySqlConnection(ConnStr)
            MyConnection.Open()
            MsgBox("open :)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class