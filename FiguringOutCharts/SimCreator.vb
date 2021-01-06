Class SimCreator
    Private SimDisplay As New Sim

    Private Sub ChooseStartingIsotope_Click(sender As Object, e As EventArgs) Handles ChooseStartingIsotope.Click
        Dim IsotopeChooser As New ChooseStartingIsotopes
        IsotopeChooser.Show()
        Hide()
    End Sub

    Private Sub ReturnToMainMenu_Click(sender As Object, e As EventArgs) Handles ReturnToMainMenu.Click
        MainMenu.Show()
        Hide()
    End Sub

    Private Sub FinishCreation_Click(sender As Object, e As EventArgs) Handles FinishCreation.Click
        If ChooseStartingIsotope.Text = "Choose Starting Isotope" Then
            MsgBox("You are yet to choose a starting isotope")
        Else
            SimDisplay.Show()
            Hide()
        End If
    End Sub

    Public Sub SetStartingIsotope(AtomicNumber, AtomicMass, StartingNumberOfNuclei)
        SimDisplay.SetStartingIsotope(AtomicNumber, AtomicMass, StartingNumberOfNuclei)
    End Sub


End Class