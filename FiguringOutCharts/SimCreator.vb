Class SimCreator
    Private SimDisplay As Sim
    Private MainMenu As MainMenu
    Public Sub New(CurrentUser As Object, IsTeacher As Boolean, ByVal MainMenu As MainMenu)
        InitializeComponent()
        Me.MainMenu = MainMenu
        SimDisplay = New Sim(CurrentUser, IsTeacher, MainMenu)
    End Sub
    Private Sub ChooseStartingIsotope_Click(sender As Object, e As EventArgs) Handles ChooseStartingIsotope.Click
        Dim IsotopeChooser As New ChooseStartingIsotopes(Me)
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
            SimDisplay.SetTimeToCalculateFrom()
            SimDisplay.Show()
            Hide()
        End If
    End Sub

    Public Sub SetStartingIsotope(AtomicNumber, AtomicMass, StartingNumberOfNuclei)
        If ChooseStartingIsotope.Text = "Choose Starting Isotope" Then

            SimDisplay.SetTimeInterval(AtomicNumber, AtomicMass)
        End If
        SimDisplay.SetStartingIsotope(AtomicNumber, AtomicMass, StartingNumberOfNuclei)
    End Sub

End Class