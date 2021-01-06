Public Class MainMenu

    Private Sub LoadSim_Click(sender As Object, e As EventArgs) Handles LoadSim.Click

    End Sub

    Private Sub CreateSim_Click(sender As Object, e As EventArgs) Handles CreateSim.Click
        Dim SimCreator As New SimCreator
        Dim Sim As New Sim
        SimCreator.Show()
        Hide()
    End Sub

    Private Sub ViewAssignments_Click(sender As Object, e As EventArgs) Handles ViewAssignments.Click

    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class