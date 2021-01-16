Class MainMenu
    Private SimCreator As New SimCreator
    Private Sub LoadSim_Click(sender As Object, e As EventArgs) Handles LoadSim.Click

    End Sub

    Private Sub CreateSim_Click(sender As Object, e As EventArgs) Handles CreateSim.Click
        SimCreator.Show()
        Hide()
    End Sub

    Private Sub ViewAssignments_Click(sender As Object, e As EventArgs) Handles ViewAssignments.Click

    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub LogIn(AccountID, Password)

    End Sub
End Class

Class User
    Public Sub New()

    End Sub
End Class

Class Teacher
    Inherits User
End Class

Class Student
    Inherits User
End Class