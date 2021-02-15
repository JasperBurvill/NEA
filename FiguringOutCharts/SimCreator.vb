Class SimCreator
    Private SimDisplay As Sim
    Private MainMenu As MainMenu
    Public Sub New(CurrentUser As Object, IsTeacher As Boolean, ByVal MainMenu As MainMenu)
        InitializeComponent()
        Me.MainMenu = MainMenu
        SimDisplay = New Sim(CurrentUser, IsTeacher, MainMenu) 'Creates a sim and sends it the necessary information about the user
    End Sub
    Private Sub ChooseStartingIsotope_Click(sender As Object, e As EventArgs) Handles ChooseStartingIsotope.Click
        Dim IsotopeChooser As New ChooseStartingIsotopes(Me) 'Creates the window to choose the isotope
        IsotopeChooser.Show()
        Hide()
    End Sub

    Private Sub ReturnToMainMenu_Click(sender As Object, e As EventArgs) Handles ReturnToMainMenu.Click
        MainMenu.Show()
        Hide()
    End Sub

    Private Sub FinishCreation_Click(sender As Object, e As EventArgs) Handles FinishCreation.Click

        If ChooseStartingIsotope.Text = "Choose Starting Isotope" Then 'Triggers if the user has not yet picked an isotope
            MsgBox("You are yet to choose a starting isotope")
        Else
            SimDisplay.SetTimeToCalculateFrom() 'Starts calculating how much time has been spent with the simulation for students that are completing assignments
            SimDisplay.Show()
            Hide()
        End If
    End Sub

    Public Sub SetStartingIsotope(AtomicNumber, AtomicMass, StartingNumberOfNuclei)
        If ChooseStartingIsotope.Text = "Choose Starting Isotope" Then
            SimDisplay.SetTimeInterval(AtomicNumber, AtomicMass) 'Sets the time interval displayed on the graphs in the simulation dependent on the half-life of the first isotope added
        End If
        SimDisplay.SetStartingIsotope(AtomicNumber, AtomicMass, StartingNumberOfNuclei) 'Adds the chosen isotope to the list of starting isotopes in the simulation so that the program knows what to revert to
    End Sub

End Class