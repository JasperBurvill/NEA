Imports MySql.Data.MySqlClient
Class MainMenu
    Private SimCreator As SimCreator
    Private AssignmentViewer As AssignmentViewer
    Private CurrentStudent As Student
    Private CurrentTeacher As Teacher


    Private Sub CreateSim_Click(sender As Object, e As EventArgs) Handles CreateSim.Click 'Creates a new sim creator and shows it
        If SetAssignments.Visible = True Then
            SimCreator = New SimCreator(CurrentTeacher, True, Me)
        Else
            SimCreator = New SimCreator(CurrentStudent, False, Me)
        End If
        SimCreator.Show()
        Hide()
    End Sub

    Private Sub ViewAssignments_Click(sender As Object, e As EventArgs) Handles ViewAssignments.Click 'Creates a new assignment viewer and shows it
        If SetAssignments.Visible = True Then
            AssignmentViewer = New AssignmentViewer(CurrentTeacher, True, Me)
        Else
            AssignmentViewer = New AssignmentViewer(CurrentStudent, False, Me)
        End If
        AssignmentViewer.Show()
        Hide()
    End Sub

    Private Sub SetAssignments_Click(sender As Object, e As EventArgs) Handles SetAssignments.Click
        Dim ListOfStudents As New List(Of String)
        Dim Student As String = "None selected"
        Dim FinishedSelecting As Boolean = False
        Dim IsTimeBased As Boolean
        Dim Time As Integer = 0
        Dim NumberOfRuns As Integer = 0
        Dim DueDate As Date
        Dim TempString As String = ""
        Select Case MsgBox("Would you like to set an assignment for the whole class?", vbYesNoCancel)
            Case vbYes
                ListOfStudents = CurrentTeacher.GetWholeClass 'Adds all the students to the list that are being set an assignment to save the teacher from typing out each one
            Case vbNo
                Do
                    Do
                        If Student <> "None selected" Then MsgBox("That student is not in your class")
                        Student = InputBox("Enter the ID of the student that you would like to set an assignment for")
                        If Student = "" Then Exit Sub
                    Loop Until CurrentTeacher.CheckStudentIsInClass(Student) 'Only allows the teacher to set assignments for students in their class
                    ListOfStudents.Add(Student)
                    Select Case MsgBox("Would you like to set the assignment for another student", vbYesNo)
                        Case vbNo
                            FinishedSelecting = True
                    End Select
                Loop Until FinishedSelecting 'Keeps asking for students until the teacher says that they are done
            Case vbCancel 'Returns the user to menu if they click the cancel button
                Exit Sub
            Case vbAbort
                Exit Sub
        End Select
        Select Case MsgBox("Would you like to set the students to run simulations for a set period of time? (The alternative is to run a set number of simulations)", vbYesNoCancel)
            Case vbYes
                Do
                    IsTimeBased = True
                    Try
                        TempString = InputBox("Please enter the number of minutes that you would like to set an assignment for")
                        If TempString = "" Then Exit Sub
                        If TempString.Contains(".") Then IsTimeBased = False
                        Time = TempString 'Triggers the try catch statement if the user enters a non-number
                    Catch ex As Exception
                        IsTimeBased = False
                    End Try
                    If IsTimeBased = False Or Time = 0 Then MsgBox("Please enter an integer number of minutes that is greater than zero")
                Loop Until IsTimeBased = True And Time > 0 'Keeps looping until a valid input is entered
            Case vbNo
                Do
                    IsTimeBased = False
                    Try
                        TempString = InputBox("Please enter the number of runs that you would like to set an assignment to complete ")
                        If TempString = "" Then Exit Sub
                        If TempString.Contains(".") Then IsTimeBased = True
                        NumberOfRuns = TempString 'Triggers the try catch statement if the user enters a non-number
                    Catch ex As Exception
                        IsTimeBased = True
                    End Try
                    If IsTimeBased = True Then MsgBox("Please enter an integer number of runs that is greater than zero ")
                Loop Until IsTimeBased = False And NumberOfRuns > 0 'Keeps looping until a valid input is entered
            Case vbCancel
                Exit Sub
            Case vbAbort
                Exit Sub
        End Select
        Do
            FinishedSelecting = True
            Try
                TempString = InputBox("Enter the date that the assignment is due (format dd/MM/yyyy)")
                If TempString = "" Then Exit Sub
                DueDate = TempString 'Will trigger the try catch if an invalid date is entered
            Catch ex As Exception
                MsgBox("Please enter a valid date")
                FinishedSelecting = False
            End Try
        Loop Until FinishedSelecting = True
        CurrentTeacher.SetAssignments(ListOfStudents, IsTimeBased, Time, NumberOfRuns, DueDate) 'Sets the assignment with the parameters chosen
    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click 'Closes the main menu and returns to the start up menu
        StartUpMenu.Show()
        Hide()
    End Sub


    Private Sub ExitProgram_Click(sender As Object, e As EventArgs) Handles ExitProgram.Click 'Closes the program
        End
    End Sub

    Private Sub LoadSim_Click(sender As Object, e As EventArgs) Handles LoadSim.Click
        Dim FileName As String
        Dim Sim As Sim
        Do
            FileName = InputBox("Enter the name of the file that you wish to load")
            If FileName = "" Then Exit Sub
            If SetAssignments.Visible Then
                Sim = New Sim(CurrentTeacher, True, Me)
                FileName = CurrentTeacher.GetAccountID & FileName
            Else
                Sim = New Sim(CurrentStudent, False, Me)
                FileName = CurrentStudent.GetAccountID & FileName
            End If '^^I store the file with the user's ID appended onto the front so that the user can only access it if its their file and different users can have sims with the same name
            If Not CheckFileExists(FileName) Then MsgBox("That file does not exist")
        Loop Until CheckFileExists(FileName)
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\NEASimStorage\" & FileName & ".txt") 'Accesses the file that has the user's simulation saved
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",") 'Starting isotope information is delimited by commas
            Dim LoopChecker As Boolean = False
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields() 'Reads the row that the reader is currently on and stores it as an array
                    If Not LoopChecker Then Sim.SetTimeInterval(currentRow(0), currentRow(1)) 'Sets the time interval that the simulation runs on depending on the half-life of the first isotope added
                    Sim.SetStartingIsotope(currentRow(0), currentRow(1), currentRow(2)) 'Sets a starting isotope in the Sim class
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.") 'Skips the line if something has been stored incorrectly, theoretically this should never happen
                End Try
                LoopChecker = True
            End While
        End Using
        Sim.SetTimeToCalculateFrom() 'Initialises the time that the user has spent with the simulation to track assignments
        Sim.Show() 'Opens the simulation
        Hide()
    End Sub

    Public Function CheckFileExists(FileName As String) 'Simply makes sure that the file the user is requesting exists and returns a boolean value
        If System.IO.File.Exists("C:\NEASimStorage\" & FileName & ".txt") Then
            Return True
        End If
        Return False
    End Function

    Public Sub LogIn(AccountID As String, IsTeacher As Boolean)
        If AccountID = "0" Then 'Sets the ID of the guest as 0
            CurrentStudent = New Student(AccountID) 'Uses the student class as there was no reason to create a new class
            WelcomeLabel.Text = "Welcome guest"
            SetAssignments.Hide()
            ViewAssignments.Hide()
            LoadSim.Hide() 'A guest can only access the create sim button
        ElseIf IsTeacher = True Then
            CurrentTeacher = New Teacher(AccountID) 'Sets the teacher account
            WelcomeLabel.Text = "Welcome " & CurrentTeacher.GetName
            SetAssignments.Show()
            ViewAssignments.Show()
            LoadSim.Show()
        Else
            CurrentStudent = New Student(AccountID) 'Sets the student account
            WelcomeLabel.Text = "Welcome " & CurrentStudent.GetName
            SetAssignments.Hide()
            ViewAssignments.Show()
            LoadSim.Show() 'A student cannot access the set assignments button
        End If
    End Sub
End Class

Class User
    Protected AccountID As String
    Protected ConnStr As String = "server=localhost;user=Dev;port=3306;database=simaccounts;password=Turtwig;"
    Protected DDLstr As String
    Protected SQLstr As String
    Protected Name As String
    Protected MyCommand As MySqlCommand
    Protected MyConnection As MySqlConnection
    Protected Table As New DataTable
    Public Sub New(AccountID As String)
        Me.AccountID = AccountID
        OpenDatabase()
    End Sub

    Public Sub OpenDatabase() 'Used to open the database, by this point the database has to have been created so no need for the DDL
        Try
            MyConnection = New MySqlConnection(ConnStr)
            MyConnection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ExecuteCommand(CommandStr As String) 'Executes basic SQL and DDL commands
        Try
            MyCommand = New MySqlCommand(CommandStr, MyConnection)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GetAssignmentTable(SQL As String) 'Creates a table showing information on assignments depending on the button clicked and by what type of account in the assignment viewer
        Table.Clear()
        Try
            OpenDatabase()
            MyCommand = New MySqlCommand(SQL, MyConnection)
            Table.Load(MyCommand.ExecuteReader)
            MyCommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MyConnection.Close()
        Return Table
    End Function

    Public Function GetNextAssignmentID() 'Gives each assignment a unique identifier in the form of an integer that can be used as a primary key, based off of how many rows have been stored in the database
        Dim DataSet As DataSet = New DataSet()
        Dim DataAdapter As New MySqlDataAdapter
        MyCommand = New MySqlCommand("SELECT AssignmentID FROM Assignments", MyConnection)
        OpenDatabase()
        Try
            DataAdapter.SelectCommand = MyCommand
            DataAdapter.Fill(DataSet, "StudentID")
            Dim DataTable As DataTable = DataSet.Tables("StudentID")
            Return DataTable.Rows.Count + 1 'Adds one to the number of rows to get the new ID
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MyConnection.Close()
            Return 1 'Could be that the assignment table doesnt yet exist, in this case the ID is set as one
        End Try
    End Function

    Public Function GetName()
        Return Name
    End Function

    Public Function GetAccountID()
        Return AccountID
    End Function

End Class

Class Teacher
    Inherits User

    Public Sub New(AccountID)
        MyBase.New(AccountID)
        Try
            MyCommand = New MySqlCommand("SELECT FirstName FROM Teachers WHERE TeacherID = '" & AccountID & "'", MyConnection)
            MyCommand.CommandType = CommandType.Text
            Name = MyCommand.ExecuteScalar 'Gets the first name of the Teacher
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MyConnection.Close()
    End Sub

    Public Sub SetAssignments(ListOfStudents As List(Of String), IsTimeBased As Boolean, Time As Integer, NumberOfRuns As Integer, DueDate As Date)
        DDLstr = "CREATE TABLE IF NOT EXISTS Assignments
(AssignmentID INT PRIMARY KEY,
StudentID CHAR(6), 
TeacherID CHAR(3),
TimeOrRuns CHAR(4),
TimeOrRunsRemaining INT,
DueDate DATE,
Completed BOOLEAN)"
        'Creates the table of assignments if it doesnt exist
        OpenDatabase()
        ExecuteCommand(DDLstr)
        For i = 0 To ListOfStudents.Count - 1
            If IsTimeBased = True Then
                DDLstr = "INSERT INTO Assignments(AssignmentID, StudentID, TeacherID, TimeOrRuns, TimeOrRunsRemaining, DueDate, Completed) VALUES ('" & GetNextAssignmentID() & "','" & ListOfStudents(i) & "','" & AccountID & "','Time','" & Time & "','" & DueDate.ToString("yyyy-MM-dd") & "','0')"
            Else
                DDLstr = "INSERT INTO Assignments(AssignmentID, StudentID, TeacherID, TimeOrRuns, TimeOrRunsRemaining, DueDate, Completed) VALUES ('" & GetNextAssignmentID() & "','" & ListOfStudents(i) & "','" & AccountID & "','Runs','" & NumberOfRuns & "','" & DueDate.ToString("yyyy-MM-dd") & "','0')"
            End If
            ExecuteCommand(DDLstr) 'Adds the assignment to the assignment table
        Next
        MsgBox("Assignment set")
        MyConnection.Close()
    End Sub

    Public Function GetWholeClass() 'To be called when an assignment needs to be set for the whole class, returns a list of the account IDs of all the students in their class
        Dim TempList As New List(Of String)
        Dim DataSet As DataSet = New DataSet()
        Dim DataAdapter As New MySqlDataAdapter
        MyCommand = New MySqlCommand("SELECT StudentID FROM Students WHERE TeacherID = '" & AccountID & "'", MyConnection) 'Only gets the students where they are in the teacher's class
        OpenDatabase()
        Try
            DataAdapter.SelectCommand = MyCommand
            DataAdapter.Fill(DataSet, "StudentID")
            Dim DataTable As DataTable = DataSet.Tables("StudentID")
            For i = 0 To DataTable.Rows.Count - 1
                TempList.Add(DataTable.Rows(i).Item("StudentID")) 'Adds the ID to the list
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MyConnection.Close()
        Return TempList
    End Function

    Public Function CheckStudentIsInClass(Student) 'This stops a teacher from giving assignments to students if they are in their class
        Dim DataSet As DataSet = New DataSet()
        Dim DataAdapter As New MySqlDataAdapter
        MyCommand = New MySqlCommand("SELECT StudentID FROM Students WHERE StudentID = '" & Student & "' AND TeacherID = '" & AccountID & "'", MyConnection)
        OpenDatabase()
        Try
            DataAdapter.SelectCommand = MyCommand
            DataAdapter.Fill(DataSet, "StudentID")
            Dim DataTable As DataTable = DataSet.Tables("StudentID")
            If DataTable.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
            MyConnection.Close() 'Returns false if the query gives no results and true if it gives a result
        Catch ex As Exception
            MsgBox(ex.Message)
            MyConnection.Close()
            Return False
        End Try
    End Function


End Class

Class Student
    Inherits User

    Public Sub New(AccountID)
        MyBase.New(AccountID)
        Try
            MyCommand = New MySqlCommand("SELECT FirstName FROM Students WHERE StudentID = '" & AccountID & "'", MyConnection) 'Sets the students name in the same way as in the Teacher class
            MyCommand.CommandType = CommandType.Text
            Name = MyCommand.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MyConnection.Close()
    End Sub

    Public Sub UpdateAssignments(NumberOfRunsCompleted As Integer, TimeSpent As Integer) 'Called regularly when a simulation is being run to update a students progress on their assignments
        Dim DataSet As DataSet = New DataSet()
        Dim DataAdapter As New MySqlDataAdapter
        Dim DueDate As Date
        MyCommand = New MySqlCommand("SELECT * FROM Assignments WHERE StudentID = '" & AccountID & "'", MyConnection)
        OpenDatabase()
        Try
            DataAdapter.SelectCommand = MyCommand
            DataAdapter.Fill(DataSet, "TimeOrRuns")
            Dim DataTable As DataTable = DataSet.Tables("TimeOrRuns")
            For i = 0 To DataTable.Rows.Count - 1
                DueDate = DataTable.Rows(i).Item("DueDate")
                If DataTable.Rows(i).Item("TimeOrRuns") = "Time" Then
                    If DataTable.Rows(i).Item("TimeOrRunsRemaining") - TimeSpent > 0 Then
                        DDLstr = "INSERT INTO Assignments(AssignmentID, StudentID, TeacherID, TimeOrRuns, TimeOrRunsRemaining, DueDate, Completed) VALUES ('" & DataTable.Rows(i).Item("AssignmentID") & "','" & DataTable.Rows(i).Item("StudentID") & "','" & DataTable.Rows(i).Item("TeacherID") & "','Time','" & (DataTable.Rows(i).Item("TimeOrRunsRemaining") - TimeSpent).ToString & "','" & DueDate.ToString("yyyy-MM-dd") & "','0')" 'The date needs to be uploaded to the database in a specific format
                    Else
                        DDLstr = "INSERT INTO Assignments(AssignmentID, StudentID, TeacherID, TimeOrRuns, TimeOrRunsRemaining, DueDate, Completed) VALUES ('" & DataTable.Rows(i).Item("AssignmentID") & "','" & DataTable.Rows(i).Item("StudentID") & "','" & DataTable.Rows(i).Item("TeacherID") & "','Time','0','" & DueDate.ToString("yyyy-MM-dd") & "','1')"
                    End If
                Else
                    If DataTable.Rows(i).Item("TimeOrRunsRemaining") - NumberOfRunsCompleted > 0 Then
                        DDLstr = "INSERT INTO Assignments(AssignmentID, StudentID, TeacherID, TimeOrRuns, TimeOrRunsRemaining, DueDate, Completed) VALUES ('" & DataTable.Rows(i).Item("AssignmentID") & "','" & DataTable.Rows(i).Item("StudentID") & "','" & DataTable.Rows(i).Item("TeacherID") & "','Runs','" & (DataTable.Rows(i).Item("TimeOrRunsRemaining") - NumberOfRunsCompleted).ToString & "','" & DueDate.ToString("yyyy-MM-dd") & "','0')"
                    Else
                        DDLstr = "INSERT INTO Assignments(AssignmentID, StudentID, TeacherID, TimeOrRuns, TimeOrRunsRemaining, DueDate, Completed) VALUES ('" & DataTable.Rows(i).Item("AssignmentID") & "','" & DataTable.Rows(i).Item("StudentID") & "','" & DataTable.Rows(i).Item("TeacherID") & "','Runs','0','" & DueDate.ToString("yyyy-MM-dd") & "','1')"
                    End If
                End If '^^Create new assignment entries with the same assignmentID to replace the old one with updated values
                ExecuteCommand("DELETE FROM Assignments WHERE AssignmentID = '" & DataTable.Rows(i).Item("AssignmentID") & "'") 'Deletes old entry
                ExecuteCommand(DDLstr)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MyConnection.Close()
    End Sub
End Class