<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartUpMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartUpMenu))
        Me.LogIn = New System.Windows.Forms.Button()
        Me.CreateAccount = New System.Windows.Forms.Button()
        Me.UseGuest = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ExitProgram = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogIn
        '
        Me.LogIn.BackColor = System.Drawing.Color.Red
        Me.LogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogIn.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogIn.Location = New System.Drawing.Point(293, 247)
        Me.LogIn.Name = "LogIn"
        Me.LogIn.Size = New System.Drawing.Size(149, 91)
        Me.LogIn.TabIndex = 0
        Me.LogIn.Text = "Log In"
        Me.LogIn.UseMnemonic = False
        Me.LogIn.UseVisualStyleBackColor = False
        '
        'CreateAccount
        '
        Me.CreateAccount.BackColor = System.Drawing.Color.LimeGreen
        Me.CreateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CreateAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CreateAccount.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateAccount.Location = New System.Drawing.Point(524, 247)
        Me.CreateAccount.Name = "CreateAccount"
        Me.CreateAccount.Size = New System.Drawing.Size(149, 91)
        Me.CreateAccount.TabIndex = 1
        Me.CreateAccount.Text = "Create an Account"
        Me.CreateAccount.UseMnemonic = False
        Me.CreateAccount.UseVisualStyleBackColor = False
        '
        'UseGuest
        '
        Me.UseGuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UseGuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UseGuest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UseGuest.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UseGuest.Location = New System.Drawing.Point(748, 247)
        Me.UseGuest.Name = "UseGuest"
        Me.UseGuest.Size = New System.Drawing.Size(149, 91)
        Me.UseGuest.TabIndex = 2
        Me.UseGuest.Text = "Use as a Guest"
        Me.UseGuest.UseMnemonic = False
        Me.UseGuest.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(228, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(742, 38)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Hello and welcome to this simulation of Nuclear Decay!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(295, 421)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(590, 38)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Please select how you would like to proceed"
        '
        'PictureBox1
        '
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1039, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 120)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1039, 473)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(140, 120)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.InitialImage = CType(resources.GetObject("PictureBox3.InitialImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(35, 473)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(140, 120)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.InitialImage = CType(resources.GetObject("PictureBox4.InitialImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(35, 43)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(140, 120)
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'ExitProgram
        '
        Me.ExitProgram.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExitProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ExitProgram.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitProgram.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitProgram.Location = New System.Drawing.Point(479, 502)
        Me.ExitProgram.Name = "ExitProgram"
        Me.ExitProgram.Size = New System.Drawing.Size(242, 91)
        Me.ExitProgram.TabIndex = 9
        Me.ExitProgram.Text = "Quit to Desktop"
        Me.ExitProgram.UseMnemonic = False
        Me.ExitProgram.UseVisualStyleBackColor = False
        '
        'StartUpMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(1197, 625)
        Me.Controls.Add(Me.ExitProgram)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UseGuest)
        Me.Controls.Add(Me.CreateAccount)
        Me.Controls.Add(Me.LogIn)
        Me.Name = "StartUpMenu"
        Me.Text = "StartUpMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogIn As Button
    Friend WithEvents CreateAccount As Button
    Friend WithEvents UseGuest As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ExitProgram As Button
End Class
