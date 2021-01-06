Imports Microsoft.VisualBasic.PowerPacks
Public Class ChooseStartingIsotopes


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
        Dim ButtonClicked As Button = CType(sender, Button)
        HandleIsotope(ButtonClicked.Text)
    End Sub

    Public Sub HandleIsotope(Isotope As String)
        Dim FullIsotope As String
        Dim AtomicNumber As Integer
        Dim AtomicMass As Integer
        Dim HalfLife As Double
        Dim StartingNumber As Integer
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("Isotopes.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(", ")
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    If currentRow(5) = Isotope Then
                        FullIsotope = currentRow(0)
                        HalfLife = currentRow(2)
                        AtomicNumber = currentRow(3)
                        AtomicMass = currentRow(4)
                    End If
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        End Using
        Select Case MsgBox("Are you sure that you would like to start with " & FullIsotope & "? It has an atomic number of " & AtomicNumber & ", an atomic mass of " & AtomicMass & ", and a half-life of " & HalfLife & ".", vbYesNo,)
            Case vbYes
                StartingNumber = InputBox("How many nuclei of this isotope would you like to start with?")
                If SimCreator.ChooseStartingIsotope.Text = "Choose Starting Isotope" Then

                End If
                SimCreator.SetStartingIsotope(AtomicNumber, AtomicMass, StartingNumber)
                SimCreator.ChooseStartingIsotope.Text = "Choose Another Starting Isotope"
                SimCreator.Show()
                Hide()
        End Select

    End Sub
End Class