Class AssignmentViewer
    Private IsTeacher As Boolean
    Private MainMenu As MainMenu
    Private CurrentStudent As Student
    Private CurrentTeacher As Teacher
    Public Sub New(CurrentUser As Object, IsTeacher As Boolean, ByVal MainMenu As MainMenu)
        InitializeComponent()
        Me.MainMenu = MainMenu
        Me.IsTeacher = IsTeacher
        AssignmentsMenuButton.Hide()
        If IsTeacher Then
            CurrentTeacher = CurrentUser
            SpecifcStudentButton.Show()
        Else
            CurrentStudent = CurrentUser
            SpecifcStudentButton.Hide()
        End If
        DataGrid.Hide()
    End Sub
    Private Sub UncompletedButton_Click(sender As Object, e As EventArgs) Handles UncompletedButton.Click
        DataGrid.Show()
        DataGrid.AutoResizeColumns()
        AssignmentsMenuButton.Show()
        ReturnToMenu.Hide()

        If IsTeacher Then
            DataGrid.DataSource = CurrentTeacher.GetAssignmentTable("SELECT FirstName,Surname,Assignments.StudentID,TimeOrRuns,TimeOrRunsRemaining,DueDate,Completed FROM Assignments INNER JOIN Students ON Assignments.StudentID = Students.StudentID WHERE Assignments.TeacherID = '" & CurrentTeacher.GetAccountID & "' AND Assignments.Completed = '0'")
        Else
            DataGrid.DataSource = CurrentStudent.GetAssignmentTable("SELECT TimeOrRuns,TimeOrRunsRemaining,DueDate,Completed FROM Assignments WHERE StudentID = '" & CurrentStudent.GetAccountID & "' AND Completed = '0'")
        End If
    End Sub

    Private Sub CompletedButton_Click(sender As Object, e As EventArgs) Handles CompletedButton.Click
        DataGrid.Show()
        DataGrid.AutoResizeColumns()
        AssignmentsMenuButton.Show()
        ReturnToMenu.Hide()
        If IsTeacher Then
            DataGrid.DataSource = CurrentTeacher.GetAssignmentTable("SELECT FirstName,Surname,Assignments.StudentID,TimeOrRuns,DueDate,Completed FROM Assignments INNER JOIN Students ON Assignments.StudentID = Students.StudentID WHERE Assignments.TeacherID = '" & CurrentTeacher.GetAccountID & "' AND Assignments.Completed = '1'")
        Else

            DataGrid.DataSource = CurrentStudent.GetAssignmentTable("SELECT TimeOrRuns,DueDate,Completed FROM Assignments WHERE StudentID = '" & CurrentStudent.GetAccountID & "' AND Completed = '1'")
        End If
    End Sub

    Private Sub OverdueButton_Click(sender As Object, e As EventArgs) Handles OverdueButton.Click
        DataGrid.Show()
        DataGrid.AutoResizeColumns()
        AssignmentsMenuButton.Show()
        ReturnToMenu.Hide()
        If IsTeacher Then
            DataGrid.DataSource = CurrentTeacher.GetAssignmentTable("SELECT FirstName,Surname,Assignments.StudentID,TimeOrRuns,TimeOrRunsRemaining,DueDate,Completed FROM Assignments INNER JOIN Students ON Assignments.StudentID = Students.StudentID WHERE Assignments.TeacherID = '" & CurrentTeacher.GetAccountID & "' AND Assignments.Completed = '0' AND DueDate < '" & DateTime.Now.ToString("yyyy-MM-dd") & "'")
        Else
            DataGrid.DataSource = CurrentStudent.GetAssignmentTable("SELECT TimeOrRuns,TimeOrRunsRemaining,DueDate,Completed FROM Assignments WHERE StudentID = '" & CurrentStudent.GetAccountID & "' AND Completed = '0' AND DueDate < '" & DateTime.Now.ToString("yyyy-MM-dd") & "'")
        End If

    End Sub

    Private Sub SpecifcStudentButton_Click(sender As Object, e As EventArgs) Handles SpecifcStudentButton.Click
        Dim SpecificStudent As String
        Dim LoopCheck As Boolean = False
        Do
            If LoopCheck Then MsgBox("That student is not in your class")
            SpecificStudent = InputBox("Please enter the ID of the student that you would like to view the assignments of.")
            LoopCheck = True
        Loop Until CurrentTeacher.CheckStudentIsInClass(SpecificStudent)
        DataGrid.Show()
        DataGrid.AutoResizeColumns()
        AssignmentsMenuButton.Show()
        ReturnToMenu.Hide()
        DataGrid.DataSource = CurrentTeacher.GetAssignmentTable("SELECT FirstName,Surname,Assignments.StudentID,TimeOrRuns,TimeOrRunsRemaining,DueDate,Completed FROM Assignments INNER JOIN Students ON Assignments.StudentID = Students.StudentID WHERE Assignments.TeacherID = '" & CurrentTeacher.GetAccountID & "' AND Assignments.StudentID = '" & SpecificStudent & "'")
    End Sub

    Private Sub ReturnToMenu_Click(sender As Object, e As EventArgs) Handles ReturnToMenu.Click
        MainMenu.Show()
        Hide()
    End Sub

    Private Sub AssignmentsMenuButton_Click(sender As Object, e As EventArgs) Handles AssignmentsMenuButton.Click
        DataGrid.Hide()
        AssignmentsMenuButton.Hide()
        ReturnToMenu.Show()
    End Sub


End Class