<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sim
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(4.0R, 5.0R)
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 100.0R)
        Dim DataPoint3 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(1.0R, 50.0R)
        Dim DataPoint4 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(2.0R, 25.0R)
        Dim DataPoint5 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(3.0R, 12.5R)
        Dim DataPoint6 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(6.25R, 4.0R)
        Me.DecayCurveButton = New System.Windows.Forms.Button()
        Me.PieChartButton = New System.Windows.Forms.Button()
        Me.BarChartButton = New System.Windows.Forms.Button()
        Me.ReturnToMenu = New System.Windows.Forms.Button()
        Me.SaveSim = New System.Windows.Forms.Button()
        Me.BarChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PieChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DecayCurve = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.EnterTimeButton = New System.Windows.Forms.Button()
        Me.ReturnToSimMenu = New System.Windows.Forms.Button()
        CType(Me.BarChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PieChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecayCurve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DecayCurveButton
        '
        Me.DecayCurveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DecayCurveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DecayCurveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DecayCurveButton.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecayCurveButton.Location = New System.Drawing.Point(927, 359)
        Me.DecayCurveButton.Name = "DecayCurveButton"
        Me.DecayCurveButton.Size = New System.Drawing.Size(174, 105)
        Me.DecayCurveButton.TabIndex = 5
        Me.DecayCurveButton.Text = "Plot Decay Curve"
        Me.DecayCurveButton.UseMnemonic = False
        Me.DecayCurveButton.UseVisualStyleBackColor = False
        '
        'PieChartButton
        '
        Me.PieChartButton.BackColor = System.Drawing.Color.LimeGreen
        Me.PieChartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PieChartButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PieChartButton.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PieChartButton.Location = New System.Drawing.Point(666, 359)
        Me.PieChartButton.Name = "PieChartButton"
        Me.PieChartButton.Size = New System.Drawing.Size(174, 105)
        Me.PieChartButton.TabIndex = 4
        Me.PieChartButton.Text = "Pie Chart"
        Me.PieChartButton.UseMnemonic = False
        Me.PieChartButton.UseVisualStyleBackColor = False
        '
        'BarChartButton
        '
        Me.BarChartButton.BackColor = System.Drawing.Color.Red
        Me.BarChartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BarChartButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BarChartButton.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarChartButton.Location = New System.Drawing.Point(397, 359)
        Me.BarChartButton.Name = "BarChartButton"
        Me.BarChartButton.Size = New System.Drawing.Size(174, 105)
        Me.BarChartButton.TabIndex = 3
        Me.BarChartButton.Text = "Bar Chart"
        Me.BarChartButton.UseMnemonic = False
        Me.BarChartButton.UseVisualStyleBackColor = False
        '
        'ReturnToMenu
        '
        Me.ReturnToMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ReturnToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ReturnToMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReturnToMenu.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnToMenu.Location = New System.Drawing.Point(14, 14)
        Me.ReturnToMenu.Name = "ReturnToMenu"
        Me.ReturnToMenu.Size = New System.Drawing.Size(282, 105)
        Me.ReturnToMenu.TabIndex = 16
        Me.ReturnToMenu.Text = "Return to Main Menu"
        Me.ReturnToMenu.UseMnemonic = False
        Me.ReturnToMenu.UseVisualStyleBackColor = False
        '
        'SaveSim
        '
        Me.SaveSim.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SaveSim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveSim.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveSim.Location = New System.Drawing.Point(1219, 14)
        Me.SaveSim.Name = "SaveSim"
        Me.SaveSim.Size = New System.Drawing.Size(282, 105)
        Me.SaveSim.TabIndex = 17
        Me.SaveSim.Text = "Save Simulation"
        Me.SaveSim.UseMnemonic = False
        Me.SaveSim.UseVisualStyleBackColor = False
        '
        'BarChart
        '
        Me.BarChart.BackColor = System.Drawing.Color.Yellow
        Me.BarChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BarChart.BorderlineColor = System.Drawing.Color.Black
        Me.BarChart.BorderSkin.PageColor = System.Drawing.Color.Yellow
        ChartArea1.AxisX.Title = "Isotope"
        ChartArea1.AxisY.Title = "NumberOfNuclei"
        ChartArea1.BackColor = System.Drawing.Color.Yellow
        ChartArea1.Name = "ChartArea1"
        Me.BarChart.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Yellow
        Legend1.BackSecondaryColor = System.Drawing.Color.Black
        Legend1.Name = "Legend1"
        Me.BarChart.Legends.Add(Legend1)
        Me.BarChart.Location = New System.Drawing.Point(482, 142)
        Me.BarChart.Name = "BarChart"
        Me.BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.BackSecondaryColor = System.Drawing.Color.Yellow
        Series1.ChartArea = "ChartArea1"
        Series1.IsVisibleInLegend = False
        Series1.Legend = "Legend1"
        Series1.Name = "Isotope Series"
        Series1.Points.Add(DataPoint1)
        Me.BarChart.Series.Add(Series1)
        Me.BarChart.Size = New System.Drawing.Size(517, 535)
        Me.BarChart.TabIndex = 18
        Me.BarChart.Text = "Bar Chart showing quantities of different isotopes at given time"
        Me.BarChart.Visible = False
        '
        'PieChart
        '
        Me.PieChart.BackColor = System.Drawing.Color.Yellow
        Me.PieChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PieChart.BackImageTransparentColor = System.Drawing.Color.Yellow
        Me.PieChart.BackSecondaryColor = System.Drawing.Color.Yellow
        ChartArea2.BackColor = System.Drawing.Color.Yellow
        ChartArea2.Name = "ChartArea1"
        Me.PieChart.ChartAreas.Add(ChartArea2)
        Legend2.BackColor = System.Drawing.Color.Yellow
        Legend2.Name = "Legend1"
        Me.PieChart.Legends.Add(Legend2)
        Me.PieChart.Location = New System.Drawing.Point(469, 122)
        Me.PieChart.Name = "PieChart"
        Me.PieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.PieChart.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.LimeGreen, System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.Red, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.Aqua}
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.LabelBackColor = System.Drawing.Color.Yellow
        Series2.LabelBorderColor = System.Drawing.Color.Yellow
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.PieChart.Series.Add(Series2)
        Me.PieChart.Size = New System.Drawing.Size(554, 606)
        Me.PieChart.TabIndex = 19
        Me.PieChart.Text = "Pie Chart showing the proportions of different isotopes at a given time"
        Me.PieChart.Visible = False
        '
        'DecayCurve
        '
        Me.DecayCurve.BackColor = System.Drawing.Color.Yellow
        Me.DecayCurve.BorderlineColor = System.Drawing.Color.Yellow
        ChartArea3.AxisX.Title = "Time"
        ChartArea3.AxisY.Title = "Number Of Nuclei"
        ChartArea3.BackColor = System.Drawing.Color.Yellow
        ChartArea3.Name = "ChartArea1"
        Me.DecayCurve.ChartAreas.Add(ChartArea3)
        Legend3.BackColor = System.Drawing.Color.Yellow
        Legend3.Name = "Legend1"
        Me.DecayCurve.Legends.Add(Legend3)
        Me.DecayCurve.Location = New System.Drawing.Point(180, 122)
        Me.DecayCurve.Name = "DecayCurve"
        Me.DecayCurve.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.DecayCurve.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.LimeGreen, System.Drawing.Color.Red, System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.Fuchsia, System.Drawing.Color.Aqua, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))}
        Series3.BorderWidth = 4
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.LabelBackColor = System.Drawing.Color.Yellow
        Series3.LabelBorderWidth = 5
        Series3.Legend = "Legend1"
        Series3.MarkerSize = 2
        Series3.Name = "Series1"
        DataPoint2.LabelBackColor = System.Drawing.Color.Yellow
        DataPoint3.LabelBackColor = System.Drawing.Color.Yellow
        DataPoint4.LabelBackColor = System.Drawing.Color.Yellow
        DataPoint5.LabelBackColor = System.Drawing.Color.Yellow
        DataPoint6.LabelBackColor = System.Drawing.Color.Yellow
        Series3.Points.Add(DataPoint2)
        Series3.Points.Add(DataPoint3)
        Series3.Points.Add(DataPoint4)
        Series3.Points.Add(DataPoint5)
        Series3.Points.Add(DataPoint6)
        Me.DecayCurve.Series.Add(Series3)
        Me.DecayCurve.Size = New System.Drawing.Size(1078, 587)
        Me.DecayCurve.TabIndex = 20
        Me.DecayCurve.Text = "Decay Curve of different isotopes"
        Me.DecayCurve.Visible = False
        '
        'EnterTimeButton
        '
        Me.EnterTimeButton.BackColor = System.Drawing.Color.Red
        Me.EnterTimeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EnterTimeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnterTimeButton.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterTimeButton.Location = New System.Drawing.Point(666, 715)
        Me.EnterTimeButton.Name = "EnterTimeButton"
        Me.EnterTimeButton.Size = New System.Drawing.Size(174, 105)
        Me.EnterTimeButton.TabIndex = 21
        Me.EnterTimeButton.Text = "Enter Time"
        Me.EnterTimeButton.UseMnemonic = False
        Me.EnterTimeButton.UseVisualStyleBackColor = False
        Me.EnterTimeButton.Visible = False
        '
        'ReturnToSimMenu
        '
        Me.ReturnToSimMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ReturnToSimMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ReturnToSimMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReturnToSimMenu.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnToSimMenu.Location = New System.Drawing.Point(606, 14)
        Me.ReturnToSimMenu.Name = "ReturnToSimMenu"
        Me.ReturnToSimMenu.Size = New System.Drawing.Size(282, 105)
        Me.ReturnToSimMenu.TabIndex = 24
        Me.ReturnToSimMenu.Text = "Return To Simulation Menu"
        Me.ReturnToSimMenu.UseMnemonic = False
        Me.ReturnToSimMenu.UseVisualStyleBackColor = False
        Me.ReturnToSimMenu.Visible = False
        '
        'Sim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(1515, 869)
        Me.Controls.Add(Me.ReturnToSimMenu)
        Me.Controls.Add(Me.EnterTimeButton)
        Me.Controls.Add(Me.SaveSim)
        Me.Controls.Add(Me.ReturnToMenu)
        Me.Controls.Add(Me.DecayCurveButton)
        Me.Controls.Add(Me.PieChartButton)
        Me.Controls.Add(Me.BarChartButton)
        Me.Controls.Add(Me.BarChart)
        Me.Controls.Add(Me.DecayCurve)
        Me.Controls.Add(Me.PieChart)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Sim"
        Me.Text = "Sim"
        CType(Me.BarChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PieChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecayCurve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DecayCurveButton As Button
    Friend WithEvents PieChartButton As Button
    Friend WithEvents BarChartButton As Button
    Friend WithEvents ReturnToMenu As Button
    Friend WithEvents SaveSim As Button
    Friend WithEvents BarChart As DataVisualization.Charting.Chart
    Friend WithEvents PieChart As DataVisualization.Charting.Chart
    Friend WithEvents DecayCurve As DataVisualization.Charting.Chart
    Friend WithEvents EnterTimeButton As Button
    Friend WithEvents ReturnToSimMenu As Button
End Class
