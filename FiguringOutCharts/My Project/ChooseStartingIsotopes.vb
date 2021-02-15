Imports Microsoft.VisualBasic.PowerPacks
Class ChooseStartingIsotopes
    Private SimCreator As SimCreator
    Public Sub New(ByVal SimCreator As SimCreator)
        InitializeComponent()
        Me.SimCreator = SimCreator
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        SimCreator.Show()
        Hide()
    End Sub

    Private Sub Isotope_Click(sender As Object, e As EventArgs) Handles Th232.Click, Ra228.Click, Ac228.Click, Th228.Click, Ra224.Click, Rn220.Click, Po216.Click, Pb212.Click,
            Bi212.Click, Po212.Click, Tl208.Click, Pb208.Click, Np237.Click, Pa233.Click, U233.Click, Th229.Click, Ra225.Click, Ac225.Click, Fr221.Click, At217.Click, Bi213.Click,
            Tl209.Click, Po213.Click, Pb209.Click, Bi209.Click, Tl205.Click, U238.Click, Th234.Click, Pa234.Click, U234.Click, Th230.Click, Ra226.Click, Rn222.Click, Po218.Click,
            Pb214.Click, At218.Click, Bi214.Click, Po214.Click, Tl210.Click, Pb210.Click, Bi210.Click, Hg206.Click, Tl206.Click, Po210.Click, Pb206.Click, U235.Click, Th231.Click,
            Pa231.Click, Ac227.Click, Th227.Click, Fr223.Click, Ra223.Click, At219.Click, Rn219.Click, Bi215.Click, Po215.Click, At215.Click, Pb211.Click, Bi211.Click, Po211.Click,
            Tl207.Click, Pb207.Click
        Dim ButtonClicked As Button = CType(sender, Button) 'Stores the specific button the user clicked in a variable
        HandleIsotope(ButtonClicked.Text) 'Sends the name of this button to be processed
    End Sub

    Public Sub HandleIsotope(Isotope As String)
        Dim FullIsotope As String = ""
        Dim AtomicNumber As Integer
        Dim AtomicMass As Integer
        Dim HalfLife As String = ""
        Dim StartingNumber As Integer = -1
        Dim TempString As String
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("Isotopes.txt") 'Opens the file with the data about various isotopes stored
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(", ")
            Dim currentRow As String()
            While Not MyReader.EndOfData
                currentRow = MyReader.ReadFields()
                If currentRow(5) = Isotope Then 'Gets the properties of the isotope clicked and stores them in variables (no need for handling of non-existent isotope as isotope is chosen using buttons
                    FullIsotope = currentRow(0)
                    HalfLife = currentRow(2)
                    AtomicNumber = currentRow(3)
                    AtomicMass = currentRow(4)
                End If
            End While
        End Using
        Dim TempNumber As Double = HalfLife
        Dim Counter As Integer = 0
        While TempNumber >= 10 Or TempNumber < 1 'While loop that finds the order of magnitude of the half-life in seconds
            If TempNumber >= 10 Then
                TempNumber = TempNumber / 10
                Counter = Counter + 1
            Else
                TempNumber = TempNumber * 10
                Counter = Counter - 1
            End If
        End While
        HalfLife = TempNumber.ToString & " x 10^" & Counter 'Uses the calculated order of magnitude to convert the half-life to standard form
        Select Case MsgBox("Are you sure that you would like to start with " & FullIsotope & "? It has an atomic number of " & AtomicNumber & ", an atomic mass of " & AtomicMass & ", and a half-life of " & HalfLife & "s.", vbYesNo,)
            Case vbYes
                Do
                    Try
                        TempString = InputBox("How many nuclei of this isotope would you like to start with?")
                        If TempString = "" Then Exit Sub
                        If TempString.Contains(".") Or TempString.Contains("-") Or TempString = 0 Then StartingNumber = "String"
                        StartingNumber = TempString
                    Catch ex As Exception
                        MsgBox("Please enter a reasonable, natural number of nuclei") 'This will be triggered if the user enters a decimal, a negative, a non-number, or zero for the number of nuclei, as well as if they enter a number that is unreasonably large
                    End Try
                Loop Until StartingNumber <> -1 'Loops until a valid starting number of nuclei is selected
                SimCreator.SetStartingIsotope(AtomicNumber, AtomicMass, StartingNumber)
                SimCreator.ChooseStartingIsotope.Text = "Choose Another Starting Isotope" 'Changes the button on the sim creator (if it has not already been changed) to ask the user to choose more isotopes if they desire
                SimCreator.Show()
                Hide()
        End Select

    End Sub

End Class