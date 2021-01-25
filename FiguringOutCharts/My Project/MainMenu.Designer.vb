<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.ExitProgram = New System.Windows.Forms.Button()
        Me.ViewAssignments = New System.Windows.Forms.Button()
        Me.CreateSim = New System.Windows.Forms.Button()
        Me.LoadSim = New System.Windows.Forms.Button()
        Me.SetAssignments = New System.Windows.Forms.Button()
        Me.LogOut = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitProgram
        '
        Me.ExitProgram.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExitProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ExitProgram.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitProgram.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitProgram.Location = New System.Drawing.Point(620, 490)
        Me.ExitProgram.Name = "ExitProgram"
        Me.ExitProgram.Size = New System.Drawing.Size(242, 91)
        Me.ExitProgram.TabIndex = 10
        Me.ExitProgram.Text = "Quit to Desktop"
        Me.ExitProgram.UseMnemonic = False
        Me.ExitProgram.UseVisualStyleBackColor = False
        '
        'ViewAssignments
        '
        Me.ViewAssignments.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ViewAssignments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ViewAssignments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ViewAssignments.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewAssignments.Location = New System.Drawing.Point(745, 169)
        Me.ViewAssignments.Name = "ViewAssignments"
        Me.ViewAssignments.Size = New System.Drawing.Size(149, 91)
        Me.ViewAssignments.TabIndex = 13
        Me.ViewAssignments.Text = "View Assignments"
        Me.ViewAssignments.UseMnemonic = False
        Me.ViewAssignments.UseVisualStyleBackColor = False
        '
        'CreateSim
        '
        Me.CreateSim.BackColor = System.Drawing.Color.LimeGreen
        Me.CreateSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CreateSim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CreateSim.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateSim.Location = New System.Drawing.Point(521, 169)
        Me.CreateSim.Name = "CreateSim"
        Me.CreateSim.Size = New System.Drawing.Size(149, 91)
        Me.CreateSim.TabIndex = 12
        Me.CreateSim.Text = "Create New Simulation"
        Me.CreateSim.UseMnemonic = False
        Me.CreateSim.UseVisualStyleBackColor = False
        '
        'LoadSim
        '
        Me.LoadSim.BackColor = System.Drawing.Color.Red
        Me.LoadSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LoadSim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoadSim.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadSim.Location = New System.Drawing.Point(290, 169)
        Me.LoadSim.Name = "LoadSim"
        Me.LoadSim.Size = New System.Drawing.Size(149, 91)
        Me.LoadSim.TabIndex = 11
        Me.LoadSim.Text = "Load Simulation"
        Me.LoadSim.UseMnemonic = False
        Me.LoadSim.UseVisualStyleBackColor = False
        '
        'SetAssignments
        '
        Me.SetAssignments.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SetAssignments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SetAssignments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SetAssignments.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetAssignments.Location = New System.Drawing.Point(521, 309)
        Me.SetAssignments.Name = "SetAssignments"
        Me.SetAssignments.Size = New System.Drawing.Size(149, 91)
        Me.SetAssignments.TabIndex = 14
        Me.SetAssignments.Text = "Set Assignments"
        Me.SetAssignments.UseMnemonic = False
        Me.SetAssignments.UseVisualStyleBackColor = False
        '
        'LogOut
        '
        Me.LogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogOut.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut.Location = New System.Drawing.Point(329, 490)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(242, 91)
        Me.LogOut.TabIndex = 15
        Me.LogOut.Text = "Log Out"
        Me.LogOut.UseMnemonic = False
        Me.LogOut.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.InitialImage = CType(resources.GetObject("PictureBox4.InitialImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(24, 33)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(140, 120)
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.InitialImage = CType(resources.GetObject("PictureBox3.InitialImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(24, 463)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(140, 120)
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1028, 463)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(140, 120)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1028, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 120)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(471, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 51)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "MAIN MENU"
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLabel.Location = New System.Drawing.Point(462, 77)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(0, 45)
        Me.WelcomeLabel.TabIndex = 21
        Me.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(1194, 626)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LogOut)
        Me.Controls.Add(Me.SetAssignments)
        Me.Controls.Add(Me.ViewAssignments)
        Me.Controls.Add(Me.CreateSim)
        Me.Controls.Add(Me.LoadSim)
        Me.Controls.Add(Me.ExitProgram)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitProgram As Button
    Friend WithEvents ViewAssignments As Button
    Friend WithEvents CreateSim As Button
    Friend WithEvents LoadSim As Button
    Friend WithEvents SetAssignments As Button
    Friend WithEvents LogOut As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents WelcomeLabel As Label
End Class
