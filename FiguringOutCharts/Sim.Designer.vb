﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint7 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(4.0R, 5.0R)
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint8 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 100.0R)
        Dim DataPoint9 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(1.0R, 50.0R)
        Dim DataPoint10 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(2.0R, 25.0R)
        Dim DataPoint11 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(3.0R, 12.5R)
        Dim DataPoint12 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(6.25R, 4.0R)
        Me.DecayCurveButton = New System.Windows.Forms.Button()
        Me.PieChartButton = New System.Windows.Forms.Button()
        Me.BarChartButton = New System.Windows.Forms.Button()
        Me.ReturnToMenu = New System.Windows.Forms.Button()
        Me.SaveSim = New System.Windows.Forms.Button()
        Me.BarChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PieChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DecayCurve = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.EnterTimeButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ReturnToSimMenu = New System.Windows.Forms.Button()
        Me.Loading1 = New System.Windows.Forms.Label()
        Me.Loading2 = New System.Windows.Forms.Label()
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
        ChartArea4.AxisX.Title = "Isotope"
        ChartArea4.AxisY.Title = "NumberOfNuclei"
        ChartArea4.BackColor = System.Drawing.Color.Yellow
        ChartArea4.Name = "ChartArea1"
        Me.BarChart.ChartAreas.Add(ChartArea4)
        Legend4.BackColor = System.Drawing.Color.Yellow
        Legend4.BackSecondaryColor = System.Drawing.Color.Black
        Legend4.Name = "Legend1"
        Me.BarChart.Legends.Add(Legend4)
        Me.BarChart.Location = New System.Drawing.Point(482, 142)
        Me.BarChart.Name = "BarChart"
        Me.BarChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series4.BackSecondaryColor = System.Drawing.Color.Yellow
        Series4.ChartArea = "ChartArea1"
        Series4.IsVisibleInLegend = False
        Series4.Legend = "Legend1"
        Series4.Name = "Isotope Series"
        Series4.Points.Add(DataPoint7)
        Me.BarChart.Series.Add(Series4)
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
        ChartArea5.BackColor = System.Drawing.Color.Yellow
        ChartArea5.Name = "ChartArea1"
        Me.PieChart.ChartAreas.Add(ChartArea5)
        Legend5.BackColor = System.Drawing.Color.Yellow
        Legend5.Name = "Legend1"
        Me.PieChart.Legends.Add(Legend5)
        Me.PieChart.Location = New System.Drawing.Point(469, 122)
        Me.PieChart.Name = "PieChart"
        Me.PieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.PieChart.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.LimeGreen, System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.Red, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.Aqua}
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series5.LabelBackColor = System.Drawing.Color.Yellow
        Series5.LabelBorderColor = System.Drawing.Color.Yellow
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.PieChart.Series.Add(Series5)
        Me.PieChart.Size = New System.Drawing.Size(554, 606)
        Me.PieChart.TabIndex = 19
        Me.PieChart.Text = "Pie Chart showing the proportions of different isotopes at a given time"
        Me.PieChart.Visible = False
        '
        'DecayCurve
        '
        Me.DecayCurve.BackColor = System.Drawing.Color.Yellow
        Me.DecayCurve.BorderlineColor = System.Drawing.Color.Yellow
        ChartArea6.AxisX.Title = "Time"
        ChartArea6.AxisY.Title = "Number Of Nuclei"
        ChartArea6.BackColor = System.Drawing.Color.Yellow
        ChartArea6.Name = "ChartArea1"
        Me.DecayCurve.ChartAreas.Add(ChartArea6)
        Legend6.BackColor = System.Drawing.Color.Yellow
        Legend6.Name = "Legend1"
        Me.DecayCurve.Legends.Add(Legend6)
        Me.DecayCurve.Location = New System.Drawing.Point(180, 122)
        Me.DecayCurve.Name = "DecayCurve"
        Me.DecayCurve.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.DecayCurve.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.LimeGreen, System.Drawing.Color.Red, System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.Fuchsia, System.Drawing.Color.Aqua, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))}
        Series6.BorderWidth = 4
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series6.LabelBackColor = System.Drawing.Color.Yellow
        Series6.LabelBorderWidth = 5
        Series6.Legend = "Legend1"
        Series6.MarkerSize = 2
        Series6.Name = "Series1"
        DataPoint8.LabelBackColor = System.Drawing.Color.Yellow
        DataPoint9.LabelBackColor = System.Drawing.Color.Yellow
        DataPoint10.LabelBackColor = System.Drawing.Color.Yellow
        DataPoint11.LabelBackColor = System.Drawing.Color.Yellow
        DataPoint12.LabelBackColor = System.Drawing.Color.Yellow
        Series6.Points.Add(DataPoint8)
        Series6.Points.Add(DataPoint9)
        Series6.Points.Add(DataPoint10)
        Series6.Points.Add(DataPoint11)
        Series6.Points.Add(DataPoint12)
        Me.DecayCurve.Series.Add(Series6)
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
        Me.EnterTimeButton.Location = New System.Drawing.Point(397, 705)
        Me.EnterTimeButton.Name = "EnterTimeButton"
        Me.EnterTimeButton.Size = New System.Drawing.Size(174, 105)
        Me.EnterTimeButton.TabIndex = 21
        Me.EnterTimeButton.Text = "Enter Time"
        Me.EnterTimeButton.UseMnemonic = False
        Me.EnterTimeButton.UseVisualStyleBackColor = False
        Me.EnterTimeButton.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LimeGreen
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(666, 705)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(174, 105)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Pie Chart"
        Me.Button2.UseMnemonic = False
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(927, 705)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(174, 105)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Plot Decay Curve"
        Me.Button3.UseMnemonic = False
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
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
        'Loading1
        '
        Me.Loading1.AutoSize = True
        Me.Loading1.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loading1.Location = New System.Drawing.Point(546, 323)
        Me.Loading1.Name = "Loading1"
        Me.Loading1.Size = New System.Drawing.Size(261, 67)
        Me.Loading1.TabIndex = 25
        Me.Loading1.Text = "Loading..."
        Me.Loading1.Visible = False
        '
        'Loading2
        '
        Me.Loading2.AutoSize = True
        Me.Loading2.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loading2.Location = New System.Drawing.Point(521, 390)
        Me.Loading2.Name = "Loading2"
        Me.Loading2.Size = New System.Drawing.Size(306, 67)
        Me.Loading2.TabIndex = 26
        Me.Loading2.Text = "Please Wait"
        Me.Loading2.Visible = False
        '
        'Sim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(1515, 869)
        Me.Controls.Add(Me.Loading2)
        Me.Controls.Add(Me.Loading1)
        Me.Controls.Add(Me.ReturnToSimMenu)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
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
        Me.PerformLayout()

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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ReturnToSimMenu As Button
    Friend WithEvents Loading1 As Label
    Friend WithEvents Loading2 As Label
End Class
