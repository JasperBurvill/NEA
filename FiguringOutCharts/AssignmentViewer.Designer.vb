<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignmentViewer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BigLabel = New System.Windows.Forms.Label()
        Me.UncompletedButton = New System.Windows.Forms.Button()
        Me.CompletedButton = New System.Windows.Forms.Button()
        Me.OverdueButton = New System.Windows.Forms.Button()
        Me.ReturnToMenu = New System.Windows.Forms.Button()
        Me.SpecifcStudentButton = New System.Windows.Forms.Button()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.AssignmentsMenuButton = New System.Windows.Forms.Button()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BigLabel
        '
        Me.BigLabel.AutoSize = True
        Me.BigLabel.Font = New System.Drawing.Font("Comic Sans MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BigLabel.Location = New System.Drawing.Point(408, 84)
        Me.BigLabel.Name = "BigLabel"
        Me.BigLabel.Size = New System.Drawing.Size(414, 90)
        Me.BigLabel.TabIndex = 13
        Me.BigLabel.Text = "Assignments"
        '
        'UncompletedButton
        '
        Me.UncompletedButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UncompletedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UncompletedButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UncompletedButton.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UncompletedButton.Location = New System.Drawing.Point(329, 247)
        Me.UncompletedButton.Name = "UncompletedButton"
        Me.UncompletedButton.Size = New System.Drawing.Size(149, 91)
        Me.UncompletedButton.TabIndex = 12
        Me.UncompletedButton.Text = "Uncompleted Assignments"
        Me.UncompletedButton.UseMnemonic = False
        Me.UncompletedButton.UseVisualStyleBackColor = False
        '
        'CompletedButton
        '
        Me.CompletedButton.BackColor = System.Drawing.Color.LimeGreen
        Me.CompletedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CompletedButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CompletedButton.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompletedButton.Location = New System.Drawing.Point(545, 247)
        Me.CompletedButton.Name = "CompletedButton"
        Me.CompletedButton.Size = New System.Drawing.Size(149, 91)
        Me.CompletedButton.TabIndex = 11
        Me.CompletedButton.Text = "Completed Assignments"
        Me.CompletedButton.UseMnemonic = False
        Me.CompletedButton.UseVisualStyleBackColor = False
        '
        'OverdueButton
        '
        Me.OverdueButton.BackColor = System.Drawing.Color.Red
        Me.OverdueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.OverdueButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OverdueButton.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverdueButton.Location = New System.Drawing.Point(759, 247)
        Me.OverdueButton.Name = "OverdueButton"
        Me.OverdueButton.Size = New System.Drawing.Size(149, 91)
        Me.OverdueButton.TabIndex = 10
        Me.OverdueButton.Text = "Overdue Assignments"
        Me.OverdueButton.UseMnemonic = False
        Me.OverdueButton.UseVisualStyleBackColor = False
        '
        'ReturnToMenu
        '
        Me.ReturnToMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ReturnToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ReturnToMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReturnToMenu.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnToMenu.Location = New System.Drawing.Point(497, 576)
        Me.ReturnToMenu.Name = "ReturnToMenu"
        Me.ReturnToMenu.Size = New System.Drawing.Size(242, 91)
        Me.ReturnToMenu.TabIndex = 15
        Me.ReturnToMenu.Text = "Return To Main Menu"
        Me.ReturnToMenu.UseMnemonic = False
        Me.ReturnToMenu.UseVisualStyleBackColor = False
        '
        'SpecifcStudentButton
        '
        Me.SpecifcStudentButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SpecifcStudentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SpecifcStudentButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SpecifcStudentButton.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecifcStudentButton.Location = New System.Drawing.Point(545, 384)
        Me.SpecifcStudentButton.Name = "SpecifcStudentButton"
        Me.SpecifcStudentButton.Size = New System.Drawing.Size(149, 91)
        Me.SpecifcStudentButton.TabIndex = 16
        Me.SpecifcStudentButton.Text = "View Specific Student"
        Me.SpecifcStudentButton.UseMnemonic = False
        Me.SpecifcStudentButton.UseVisualStyleBackColor = False
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid.BackgroundColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid.GridColor = System.Drawing.Color.Black
        Me.DataGrid.Location = New System.Drawing.Point(294, 205)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGrid.Size = New System.Drawing.Size(685, 336)
        Me.DataGrid.TabIndex = 17
        Me.DataGrid.Visible = False
        '
        'AssignmentsMenuButton
        '
        Me.AssignmentsMenuButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AssignmentsMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.AssignmentsMenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AssignmentsMenuButton.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssignmentsMenuButton.Location = New System.Drawing.Point(497, 576)
        Me.AssignmentsMenuButton.Name = "AssignmentsMenuButton"
        Me.AssignmentsMenuButton.Size = New System.Drawing.Size(242, 91)
        Me.AssignmentsMenuButton.TabIndex = 18
        Me.AssignmentsMenuButton.Text = "Return To Assignments Menu"
        Me.AssignmentsMenuButton.UseMnemonic = False
        Me.AssignmentsMenuButton.UseVisualStyleBackColor = False
        '
        'AssignmentViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(1241, 696)
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.AssignmentsMenuButton)
        Me.Controls.Add(Me.SpecifcStudentButton)
        Me.Controls.Add(Me.ReturnToMenu)
        Me.Controls.Add(Me.BigLabel)
        Me.Controls.Add(Me.UncompletedButton)
        Me.Controls.Add(Me.CompletedButton)
        Me.Controls.Add(Me.OverdueButton)
        Me.Name = "AssignmentViewer"
        Me.Text = "AssignmentViewer"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BigLabel As Label
    Friend WithEvents UncompletedButton As Button
    Friend WithEvents CompletedButton As Button
    Friend WithEvents OverdueButton As Button
    Friend WithEvents ReturnToMenu As Button
    Friend WithEvents SpecifcStudentButton As Button
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents AssignmentsMenuButton As Button
End Class
