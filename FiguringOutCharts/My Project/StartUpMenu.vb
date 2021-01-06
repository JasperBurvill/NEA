Public Class StartUpMenu
    Private Sub StartUpMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub UseGuest_Click(sender As Object, e As EventArgs) Handles UseGuest.Click
        Dim MainMenu As New MainMenu
        MainMenu.Show()
        Hide()
    End Sub
    Private Sub ExitProgram_Click(sender As Object, e As EventArgs) Handles ExitProgram.Click
        End
    End Sub


End Class