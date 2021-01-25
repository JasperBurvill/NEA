
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.IO
Class Sim
    Private AlphaIsotopes As New List(Of Alpha)
    Private BetaIsotopes As New List(Of Beta)
    Private PresentIsotopes As New List(Of Isotope)
    Private StartingIsotopes As New List(Of Isotope)
    Private IsotopesOnCurve As New List(Of String)
    Private MainMenu As MainMenu
    Private CurrentTeacher As Teacher
    Private CurrentStudent As Student
    Private IsTeacher As Boolean
    Private TimeToCalculateFrom As Date
    Private TimeInterval As Double
    Private CurrentTime As Integer

    Public Sub New(CurrentUser As Object, IsTeacher As Boolean, MainMenu As MainMenu)
        InitializeComponent()
        Me.IsTeacher = IsTeacher
        Me.MainMenu = MainMenu
        If IsTeacher Then
            CurrentTeacher = CurrentUser
        Else
            CurrentStudent = CurrentUser
            If CurrentStudent.GetAccountID = "0" Then SaveSim.Hide()
        End If
    End Sub
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
        DecayCurve.ChartAreas(0).Axes(0).Title = ("Time/" & TimeInterval & " seconds")
        DecayCurve.Series.Clear()
        UpdateChart()
        ReturnToSimMenu.Show()
        ProgressSim(150)
        ResetIsotopes()
        CurrentTime = 0
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
        ProgressSim(InputBox("Enter the time that you would like to go to (in " & TimeInterval & "s of seconds)"))
    End Sub

    Private Sub ReturnToMenu_Click(sender As Object, e As EventArgs) Handles ReturnToMenu.Click
        If Not IsTeacher And CurrentStudent.GetAccountID <> "0" Then CurrentStudent.UpdateAssignments(1, CalculateTimeSpent)
        MainMenu.Show()
        Hide()
    End Sub

    Private Sub SaveSim_Click(sender As Object, e As EventArgs) Handles SaveSim.Click
        Dim FileName As String
        Dim AccountID As String
        If IsTeacher Then
            AccountID = CurrentTeacher.GetAccountID
        Else
            AccountID = CurrentStudent.GetAccountID
        End If
        Do
            FileName = InputBox("What would you like to call the file?")
            FileName = "C:\NEASimStorage\" & AccountID & FileName & ".txt"
        Loop Until IsValidFileName(FileName)
        CreateFile(FileName)
    End Sub

    Public Sub CreateFile(FileName As String)
        Dim MyWriter As New StreamWriter(FileName)
        For i = 0 To StartingIsotopes.Count - 1
            MyWriter.WriteLine(String.Format("{0},{1},{2}", StartingIsotopes(i).GetAtomicNumber, StartingIsotopes(i).GetAtomicMass, StartingIsotopes(i).GetNumberOfNuclei))
        Next
        MyWriter.Flush()
    End Sub

    Public Function IsValidFileName(Filename)
        If System.IO.File.Exists(Filename) Then
            MsgBox("A file with that name already exists under this account")
            Return False
        Else
            MsgBox("File name valid")
            Return True
        End If
        Return False
    End Function

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
        ElseIf DecayCurve.Visible = True Then
            Dim NumberOfNuclei As Integer
            For i = 0 To PresentIsotopes.Count - 1
                NumberOfNuclei = PresentIsotopes(i).GetNumberOfNuclei
                If CheckIfIsotopeIsOnCurve(PresentIsotopes(i).GetAtomicNumber, PresentIsotopes(i).GetAtomicMass) Then
                    DecayCurve.Series(i).Points.AddY(NumberOfNuclei)
                Else
                    DecayCurve.Series.Add(GetIsotopeData(PresentIsotopes(i).GetAtomicNumber, PresentIsotopes(i).GetAtomicMass, 0))
                    IsotopesOnCurve.Add(GetIsotopeData(PresentIsotopes(i).GetAtomicNumber, PresentIsotopes(i).GetAtomicMass, 0))
                    DecayCurve.Series(i).ChartType = SeriesChartType.Spline
                    DecayCurve.Series(i).BorderWidth = 4
                    DecayCurve.Series(i).Points.AddY(NumberOfNuclei)
                End If
            Next

        End If
    End Sub

    Public Function CheckIfIsotopeIsOnCurve(AtomicNumber, AtomicMass)
        For i = 0 To DecayCurve.Series.Count - 1
            If DecayCurve.Series(i).Name = GetIsotopeData(AtomicNumber, AtomicMass, 0) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function CheckIfAllIsotopesDecayed()
        Dim IsotopesDecayed As Integer = 0
        For i = 1 To PresentIsotopes.Count - 1
            If PresentIsotopes(i).GetNumberOfNuclei <= 10000 Or PresentIsotopes(i).GetHalfLife = 0 Then
                IsotopesDecayed = IsotopesDecayed + 1
            End If
        Next
        If IsotopesDecayed = PresentIsotopes.Count Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub ProgressSim(Time As Integer)
        If Time >= CurrentTime Then
            Time = Time - CurrentTime
        Else
            ResetIsotopes()
        End If
        For i = 1 To Time
            For j = AlphaIsotopes.Count - 1 To 0 Step -1
                If AlphaIsotopes(j).GetHalfLife <> 0 Then 'Im representing a stable isotope as having a half-life of 0
                    AlphaIsotopes(j).Decay(AlphaIsotopes, BetaIsotopes, TimeInterval)
                    BetaIsotopes(j).Decay(AlphaIsotopes, BetaIsotopes, TimeInterval)
                End If
            Next
            CreatePresentIsotopes()
            If DecayCurve.Visible = True Then UpdateChart()
        Next
        If DecayCurve.Visible = False Then UpdateChart()
        CurrentTime = Time
        If Not IsTeacher Then CurrentStudent.UpdateAssignments(1, CalculateTimeSpent)
        SetTimeToCalculateFrom()
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
            Return 0
        End Using
    End Function
    Public Function IsIsotopeReal(AtomicNumber, AtomicMass)
        If GetIsotopeData(AtomicNumber, AtomicMass, 3) = 0 Then Return False
        Return True
    End Function
    Public Sub CreatePresentIsotopes()
        PresentIsotopes.Clear()
        For i = 0 To AlphaIsotopes.Count - 1
            If IsIsotopeReal(AlphaIsotopes(i).GetAtomicNumber, AlphaIsotopes(i).GetAtomicMass) <> 0 Then
                PresentIsotopes.Add(New Isotope(AlphaIsotopes(i).GetNumberOfNuclei + BetaIsotopes(i).GetNumberOfNuclei, AlphaIsotopes(i).GetAtomicNumber, AlphaIsotopes(i).GetAtomicMass, AlphaIsotopes(i).GetHalfLife))
            End If
        Next
    End Sub
    Public Sub ResetIsotopes()
        AlphaIsotopes.Clear()
        BetaIsotopes.Clear()
        For i = 0 To StartingIsotopes.Count - 1
            AlphaIsotopes.Add(New Alpha(Math.Round(StartingIsotopes(i).GetNumberOfNuclei * GetIsotopeData(StartingIsotopes(i).GetAtomicNumber, StartingIsotopes(i).GetAtomicMass, 1)), StartingIsotopes(i).GetAtomicNumber, StartingIsotopes(i).GetAtomicMass, GetIsotopeData(StartingIsotopes(i).GetAtomicNumber, StartingIsotopes(i).GetAtomicMass, 2)))
            BetaIsotopes.Add(New Beta(Math.Round(StartingIsotopes(i).GetNumberOfNuclei * (1 - GetIsotopeData(StartingIsotopes(i).GetAtomicNumber, StartingIsotopes(i).GetAtomicMass, 1))), StartingIsotopes(i).GetAtomicNumber, StartingIsotopes(i).GetAtomicMass, GetIsotopeData(StartingIsotopes(i).GetAtomicNumber, StartingIsotopes(i).GetAtomicMass, 2)))
        Next
        CreatePresentIsotopes()
    End Sub
    Public Sub SetStartingIsotope(AtomicNumber, AtomicMass, StartingNumberOfNuclei)
        AlphaIsotopes.Add(New Alpha(Math.Round(StartingNumberOfNuclei * GetIsotopeData(AtomicNumber, AtomicMass, 1)), AtomicNumber, AtomicMass, GetIsotopeData(AtomicNumber, AtomicMass, 2)))
        BetaIsotopes.Add(New Beta(Math.Round(StartingNumberOfNuclei * (1 - GetIsotopeData(AtomicNumber, AtomicMass, 1))), AtomicNumber, AtomicMass, GetIsotopeData(AtomicNumber, AtomicMass, 2)))
        PresentIsotopes.Add(New Isotope(StartingNumberOfNuclei, AtomicNumber, AtomicMass, GetIsotopeData(AtomicNumber, AtomicMass, 2)))
        StartingIsotopes.Add(New Isotope(StartingNumberOfNuclei, AtomicNumber, AtomicMass, GetIsotopeData(AtomicNumber, AtomicMass, 2)))
    End Sub

    Public Sub SetTimeInterval(AtomicNumber, AtomicMass)
        Dim HalfLife As Double
        TimeInterval = 1
        HalfLife = GetIsotopeData(AtomicNumber, AtomicMass, 2)
        Do
            HalfLife = HalfLife / 10
            TimeInterval = TimeInterval * 10
        Loop Until HalfLife <= 100
    End Sub

    Public Sub SetTimeToCalculateFrom()
        TimeToCalculateFrom = Now
    End Sub

    Public Function CalculateTimeSpent()
        Return (Now - TimeToCalculateFrom).TotalMinutes
    End Function
End Class


Class Isotope
    Protected NumberOfNuclei As Double
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
    Public Overridable Sub Decay(ByRef AlphaIsotopes As List(Of Alpha), ByRef BetaIsotopes As List(Of Beta), TimeInterval As Double)
        DecayedNuclei = NumberOfNuclei - Math.Round(NumberOfNuclei * (Math.E ^ (-(Math.Log(2) / HalfLife) * TimeInterval)))
        NumberOfNuclei = NumberOfNuclei - DecayedNuclei
    End Sub

    Public Function GetNewAlphaRatio(AtomicNumber, AtomicMass)
        Return GetIsotopeData(AtomicNumber, AtomicMass, 1)
    End Function

    Public Function GetNewHalfLife(AtomicNumber, AtomicMass)
        Return GetIsotopeData(AtomicNumber, AtomicMass, 2)
    End Function

    Public Function CheckIfIsotopePresent(AtomicNumber As Integer, AtomicMass As Integer, ByRef AlphaIsotopes As List(Of Alpha), ByRef BetaIsotopes As List(Of Beta))
        Dim IsotopeIndex As Integer = -1
        For i = 0 To AlphaIsotopes.Count - 1 'Only need to check alpha isotopes as if it is in alpha then it will also be in beta, even if it has NumberOfNuclei = 0
            If AlphaIsotopes(i).GetAtomicNumber = AtomicNumber And AlphaIsotopes(i).GetAtomicMass = AtomicMass Then
                IsotopeIndex = i
            End If
        Next
        Return IsotopeIndex
    End Function

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
            Return 0
        End Using
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

    Public Overrides Sub Decay(ByRef AlphaIsotopes As List(Of Alpha), ByRef BetaIsotopes As List(Of Beta), TimeInterval As Double)
        MyBase.Decay(AlphaIsotopes, BetaIsotopes, TimeInterval)
        If CheckIfIsotopePresent(AtomicNumber - 2, AtomicMass - 4, AlphaIsotopes, BetaIsotopes) >= 0 Then
            AlphaIsotopes(CheckIfIsotopePresent(AtomicNumber - 2, AtomicMass - 4, AlphaIsotopes, BetaIsotopes)).AddNuclei(DecayedNuclei * GetNewAlphaRatio(AtomicNumber - 2, AtomicMass - 4))
            BetaIsotopes(CheckIfIsotopePresent(AtomicNumber - 2, AtomicMass - 4, AlphaIsotopes, BetaIsotopes)).AddNuclei(DecayedNuclei * (1 - GetNewAlphaRatio(AtomicNumber - 2, AtomicMass - 4)))
        Else
            AlphaIsotopes.Add(New Alpha(DecayedNuclei * GetNewAlphaRatio(AtomicNumber - 2, AtomicMass - 4), AtomicNumber - 2, AtomicMass - 4, GetNewHalfLife(AtomicNumber - 2, AtomicMass - 4)))
            BetaIsotopes.Add(New Beta(DecayedNuclei * (1 - GetNewAlphaRatio(AtomicNumber - 2, AtomicMass - 4)), AtomicNumber - 2, AtomicMass - 4, GetNewHalfLife(AtomicNumber - 2, AtomicMass - 4)))
        End If
    End Sub
End Class

Class Beta
    Inherits Isotope
    Public Sub New(ByVal NumberOfNuclei As Integer, ByVal AtomicNumber As Integer, ByVal AtomicMass As Integer, ByVal HalfLife As Double)
        MyBase.New(NumberOfNuclei, AtomicNumber, AtomicMass, HalfLife)
    End Sub
    Public Overrides Sub Decay(ByRef AlphaIsotopes As List(Of Alpha), ByRef BetaIsotopes As List(Of Beta), TimeInterval As Double)
        MyBase.Decay(AlphaIsotopes, BetaIsotopes, TimeInterval)
        If CheckIfIsotopePresent(AtomicNumber + 1, AtomicMass, AlphaIsotopes, BetaIsotopes) >= 0 Then
            AlphaIsotopes(CheckIfIsotopePresent(AtomicNumber + 1, AtomicMass, AlphaIsotopes, BetaIsotopes)).AddNuclei(DecayedNuclei * GetNewAlphaRatio(AtomicNumber + 1, AtomicMass))
            BetaIsotopes(CheckIfIsotopePresent(AtomicNumber + 1, AtomicMass, AlphaIsotopes, BetaIsotopes)).AddNuclei(DecayedNuclei * (1 - GetNewAlphaRatio(AtomicNumber + 1, AtomicMass)))
        Else
            AlphaIsotopes.Add(New Alpha(DecayedNuclei * GetNewAlphaRatio(AtomicNumber + 1, AtomicMass), AtomicNumber + 1, AtomicMass, GetNewHalfLife(AtomicNumber + 1, AtomicMass)))
            BetaIsotopes.Add(New Beta(DecayedNuclei * (1 - GetNewAlphaRatio(AtomicNumber + 1, AtomicMass)), AtomicNumber + 1, AtomicMass, GetNewHalfLife(AtomicNumber + 1, AtomicMass)))
        End If
    End Sub
End Class