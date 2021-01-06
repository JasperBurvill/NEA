
Class Sim
    Property AlphaIsotopes As New List(Of Alpha)
    Property BetaIsotopes As New List(Of Beta)
    Private PresentIsotopes As New List(Of Isotope)
    Private CurrentTime As Integer
    Private StartingAlpha As New List(Of Alpha)
    Private StartingBeta As New List(Of Beta)
    Private Sub BarChartButton_Click(sender As Object, e As EventArgs) Handles BarChartButton.Click
        BarChartButton.Hide()
        PieChartButton.Hide()
        DecayCurveButton.Hide()
        BarChart.Show()
        EnterTimeButton.Show()
        ReturnToSimMenu.Show()
        UpdateChart()
    End Sub

    Private Sub PieChartButton_Click(sender As Object, e As EventArgs) Handles PieChartButton.Click
        BarChartButton.Hide()
        PieChartButton.Hide()
        DecayCurveButton.Hide()
        PieChart.Show()
        EnterTimeButton.Show()
        ReturnToSimMenu.Show()
        UpdateChart()
    End Sub

    Private Sub DecayCurveButton_Click(sender As Object, e As EventArgs) Handles DecayCurveButton.Click
        BarChartButton.Hide()
        PieChartButton.Hide()
        DecayCurveButton.Hide()
        DecayCurve.Show()
        EnterTimeButton.Show()
        ReturnToSimMenu.Show()
        UpdateChart()
    End Sub

    Private Sub ReturnToSimMenu_Click(sender As Object, e As EventArgs) Handles ReturnToSimMenu.Click
        BarChart.Hide()
        PieChart.Hide()
        DecayCurve.Hide()
        EnterTimeButton.Hide()
        BarChartButton.Show()
        PieChartButton.Show()
        DecayCurveButton.Show()
        ReturnToSimMenu.Hide()
    End Sub

    Private Sub EnterTimeButton_Click(sender As Object, e As EventArgs) Handles EnterTimeButton.Click
        ProgressSim(InputBox("Enter the time that you would like to go to"))
        If DecayCurve.Visible = False Then UpdateChart()
    End Sub

    Public Sub UpdateChart()
        If BarChart.Visible = True Then
            BarChart.Series(0).Points.Clear()
            For i = 0 To PresentIsotopes.Count - 1
                BarChart.Series(0).Points.Add(PresentIsotopes(i).GetNumberOfNuclei)
                BarChart.Series(0).Points(i).AxisLabel = GetIsotopeData(PresentIsotopes(i).GetAtomicNumber, PresentIsotopes(i).GetAtomicMass, 0)
            Next
        ElseIf PieChart.Visible = True Then
            PieChart.Series(0).Points.Clear()
            For i = 0 To PresentIsotopes.Count - 1
                PieChart.Series(0).Points.Add(PresentIsotopes(i).GetNumberOfNuclei)
                PieChart.Series(0).Points(i).LegendText = GetIsotopeData(PresentIsotopes(i).GetAtomicNumber, PresentIsotopes(i).GetAtomicMass, 0)
            Next
        End If
    End Sub

    Public Sub UpdateCurve(Time)
        CreatePresentIsotopes()
        For i = 0 To PresentIsotopes.Count - 1
            DecayCurve.Series.Add(GetIsotopeData(PresentIsotopes(i).GetAtomicNumber, PresentIsotopes(i).GetAtomicMass, 0))
            DecayCurve.Series(i).Points.AddXY(Time, PresentIsotopes(i).GetNumberOfNuclei)
        Next
    End Sub

    Public Sub ProgressSim(Time As Integer)

        If Time >= CurrentTime Then
            Time = Time - CurrentTime
        Else
            ResetIsotopes()
        End If
        For i = 1 To Time
            For j = AlphaIsotopes.Count - 1 To 0 Step -1
                If AlphaIsotopes(j).GetHalfLife <> 0 Then 'Im representing a stable isotope as having a half-life of 0
                    AlphaIsotopes(j).Decay()
                    BetaIsotopes(j).Decay()
                End If
            Next
            ' If Sim.DecayCurve.Visible = True Then UpdateCurve(i)
        Next
        CreatePresentIsotopes()
        CurrentTime = Time
    End Sub
    Public Function GetIsotopeData(AtomicNumber, AtomicMass, Index)
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("Isotopes.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(", ")
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    If currentRow(3) = AtomicNumber And currentRow(4) = AtomicMass Then
                        Return (currentRow(Index))
                    End If
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Function

    Public Sub CreatePresentIsotopes()
        PresentIsotopes.Clear()
        For i = 0 To AlphaIsotopes.Count - 1
            If AlphaIsotopes(i).GetNumberOfNuclei + BetaIsotopes(i).GetNumberOfNuclei <> 0 Then
                PresentIsotopes.Add(New Isotope(AlphaIsotopes(i).GetNumberOfNuclei + BetaIsotopes(i).GetNumberOfNuclei, AlphaIsotopes(i).GetAtomicNumber, AlphaIsotopes(i).GetAtomicMass, AlphaIsotopes(i).GetHalfLife))
            End If
        Next
    End Sub
    Public Sub ResetIsotopes()
        AlphaIsotopes = StartingAlpha
        BetaIsotopes = StartingBeta
        PresentIsotopes.Clear()
        For i = 0 To StartingAlpha.Count - 1
            PresentIsotopes.Add(New Isotope(AlphaIsotopes(i).GetNumberOfNuclei + BetaIsotopes(i).GetNumberOfNuclei, AlphaIsotopes(i).GetAtomicNumber, AlphaIsotopes(i).GetAtomicMass, AlphaIsotopes(i).GetHalfLife))
        Next
    End Sub
    Public Sub SetStartingIsotope(AtomicNumber, AtomicMass, StartingNumberOfNuclei)
        AlphaIsotopes.Add(New Alpha(Math.Round(StartingNumberOfNuclei * GetIsotopeData(AtomicNumber, AtomicMass, 1)), AtomicNumber, AtomicMass, GetIsotopeData(AtomicNumber, AtomicMass, 2)))
        BetaIsotopes.Add(New Beta(Math.Round(StartingNumberOfNuclei * (1 - GetIsotopeData(AtomicNumber, AtomicMass, 1))), AtomicNumber, AtomicMass, GetIsotopeData(AtomicNumber, AtomicMass, 2)))
        PresentIsotopes.Add(New Isotope(StartingNumberOfNuclei, AtomicNumber, AtomicMass, GetIsotopeData(AtomicNumber, AtomicMass, 2)))
        StartingAlpha = AlphaIsotopes
        StartingBeta = BetaIsotopes
    End Sub

End Class


Class Isotope
    Protected NumberOfNuclei As Integer
    Protected DecayedNuclei As Integer
    Protected HalfLife As Double
    Protected AtomicNumber As Integer
    Protected AtomicMass As Integer

    Public Sub New(ByVal NumberOfNuclei As Integer, ByVal AtomicNumber As Integer, ByVal AtomicMass As Integer, ByVal HalfLife As Double)
        Me.NumberOfNuclei = NumberOfNuclei
        Me.AtomicNumber = AtomicNumber
        Me.AtomicMass = AtomicMass
        Me.HalfLife = HalfLife
    End Sub
    Public Overridable Sub Decay()
        DecayedNuclei = NumberOfNuclei - Math.Round(NumberOfNuclei * (Math.E ^ -(Math.Log(2) / HalfLife)))
        NumberOfNuclei = NumberOfNuclei - DecayedNuclei
    End Sub

    Public Function GetNewAlphaRatio(AtomicNumber, AtomicMass)
        Return Sim.GetIsotopeData(AtomicNumber, AtomicMass, 1)
    End Function

    Public Function GetNewHalfLife(AtomicNumber, AtomicMass)
        Return Sim.GetIsotopeData(AtomicNumber, AtomicMass, 2)
    End Function

    Public Function CheckIfIsotopePresent(AtomicNumber, AtomicMass)
        Dim IsotopeIndex As Integer = -1
        For i = 0 To Sim.AlphaIsotopes.Count - 1 'Only need to check alpha isotopes as if it is in alpha then it will also be in beta, even if it has NumberOfNuclei = 0
            If Sim.AlphaIsotopes(i).GetAtomicNumber = AtomicNumber And Sim.AlphaIsotopes(i).GetAtomicMass = AtomicMass Then
                IsotopeIndex = i
            End If
        Next
        Return IsotopeIndex
    End Function

    Public Sub AddNuclei(NumberAdded)
        NumberOfNuclei = NumberOfNuclei + NumberAdded
    End Sub

    Public Function GetNumberOfNuclei()
        Return NumberOfNuclei
    End Function

    Public Function GetAtomicNumber()
        Return AtomicNumber
    End Function

    Public Function GetAtomicMass()
        Return AtomicMass
    End Function

    Public Function GetHalfLife()
        Return HalfLife
    End Function

End Class

Class Alpha
    Inherits Isotope
    Sub New(ByVal NumberOfNuclei As Integer, ByVal AtomicNumber As Integer, ByVal AtomicMass As Integer, ByVal HalfLife As Double)
        MyBase.New(NumberOfNuclei, AtomicNumber, AtomicMass, HalfLife)
    End Sub

    Public Overrides Sub Decay()
        MyBase.Decay()
        If CheckIfIsotopePresent(AtomicNumber - 2, AtomicMass - 4) >= 0 Then
            Sim.AlphaIsotopes(CheckIfIsotopePresent(AtomicNumber - 2, AtomicMass - 4)).AddNuclei(DecayedNuclei * GetNewAlphaRatio(AtomicNumber - 2, AtomicMass - 4))
            Sim.BetaIsotopes(CheckIfIsotopePresent(AtomicNumber - 2, AtomicMass - 4)).AddNuclei(DecayedNuclei * (1 - GetNewAlphaRatio(AtomicNumber - 2, AtomicMass - 4)))
        Else
            Sim.AlphaIsotopes.Add(New Alpha(DecayedNuclei * GetNewAlphaRatio(AtomicNumber - 2, AtomicMass - 4), AtomicNumber - 2, AtomicMass - 4, GetNewHalfLife(AtomicNumber - 2, AtomicMass - 4)))
            Sim.BetaIsotopes.Add(New Beta(DecayedNuclei * (1 - GetNewAlphaRatio(AtomicNumber - 2, AtomicMass - 4)), AtomicNumber - 2, AtomicMass - 4, GetNewHalfLife(AtomicNumber - 2, AtomicMass - 4)))
        End If
    End Sub
End Class

Class Beta
    Inherits Isotope
    Public Sub New(ByVal NumberOfNuclei As Integer, ByVal AtomicNumber As Integer, ByVal AtomicMass As Integer, ByVal HalfLife As Double)
        MyBase.New(NumberOfNuclei, AtomicNumber, AtomicMass, HalfLife)
    End Sub
    Public Overrides Sub Decay()
        MyBase.Decay()
        If CheckIfIsotopePresent(AtomicNumber + 1, AtomicMass) >= 0 Then
            Sim.AlphaIsotopes(CheckIfIsotopePresent(AtomicNumber + 1, AtomicMass)).AddNuclei(DecayedNuclei * GetNewAlphaRatio(AtomicNumber + 1, AtomicMass))
            Sim.BetaIsotopes(CheckIfIsotopePresent(AtomicNumber + 1, AtomicMass)).AddNuclei(DecayedNuclei * (1 - GetNewAlphaRatio(AtomicNumber + 1, AtomicMass)))
        Else
            Sim.AlphaIsotopes.Add(New Alpha(DecayedNuclei * GetNewAlphaRatio(AtomicNumber + 1, AtomicMass), AtomicNumber + 1, AtomicMass, GetNewHalfLife(AtomicNumber + 1, AtomicMass)))
            Sim.BetaIsotopes.Add(New Beta(DecayedNuclei * (1 - GetNewAlphaRatio(AtomicNumber + 1, AtomicMass)), AtomicNumber + 1, AtomicMass, GetNewHalfLife(AtomicNumber + 1, AtomicMass)))
        End If
    End Sub
End Class