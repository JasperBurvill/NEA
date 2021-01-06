<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DesignCupboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ExitProgram = New System.Windows.Forms.Button()
        Me.FinishCreation = New System.Windows.Forms.Button()
        Me.ChooseStartingIsotope = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ExitProgram
        '
        Me.ExitProgram.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExitProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ExitProgram.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitProgram.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitProgram.Location = New System.Drawing.Point(469, 527)
        Me.ExitProgram.Name = "ExitProgram"
        Me.ExitProgram.Size = New System.Drawing.Size(242, 91)
        Me.ExitProgram.TabIndex = 19
        Me.ExitProgram.Text = "Return to Main Menu"
        Me.ExitProgram.UseMnemonic = False
        Me.ExitProgram.UseVisualStyleBackColor = False
        '
        'FinishCreation
        '
        Me.FinishCreation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FinishCreation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FinishCreation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FinishCreation.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinishCreation.Location = New System.Drawing.Point(480, 407)
        Me.FinishCreation.Name = "FinishCreation"
        Me.FinishCreation.Size = New System.Drawing.Size(217, 91)
        Me.FinishCreation.TabIndex = 18
        Me.FinishCreation.Text = "Create Simulation"
        Me.FinishCreation.UseMnemonic = False
        Me.FinishCreation.UseVisualStyleBackColor = False
        '
        'ChooseStartingIsotope
        '
        Me.ChooseStartingIsotope.BackColor = System.Drawing.Color.LimeGreen
        Me.ChooseStartingIsotope.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ChooseStartingIsotope.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChooseStartingIsotope.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChooseStartingIsotope.Location = New System.Drawing.Point(324, 54)
        Me.ChooseStartingIsotope.Name = "ChooseStartingIsotope"
        Me.ChooseStartingIsotope.Size = New System.Drawing.Size(538, 323)
        Me.ChooseStartingIsotope.TabIndex = 17
        Me.ChooseStartingIsotope.Text = "Choose Starting Isotope"
        Me.ChooseStartingIsotope.UseMnemonic = False
        Me.ChooseStartingIsotope.UseVisualStyleBackColor = False
        '
        'DesignCupboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 672)
        Me.Controls.Add(Me.ExitProgram)
        Me.Controls.Add(Me.FinishCreation)
        Me.Controls.Add(Me.ChooseStartingIsotope)
        Me.Name = "DesignCupboard"
        Me.Text = "DesignCupboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ExitProgram As Button
    Friend WithEvents FinishCreation As Button
    Friend WithEvents ChooseStartingIsotope As Button
End Class
