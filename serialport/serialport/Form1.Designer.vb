<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim AGaugeRange1 As System.Windows.Forms.AGaugeRange = New System.Windows.Forms.AGaugeRange()
        Dim AGaugeRange2 As System.Windows.Forms.AGaugeRange = New System.Windows.Forms.AGaugeRange()
        Dim AGaugeRange3 As System.Windows.Forms.AGaugeRange = New System.Windows.Forms.AGaugeRange()
        Dim AGaugeRange4 As System.Windows.Forms.AGaugeRange = New System.Windows.Forms.AGaugeRange()
        Dim AGaugeRange5 As System.Windows.Forms.AGaugeRange = New System.Windows.Forms.AGaugeRange()
        Dim AGaugeRange6 As System.Windows.Forms.AGaugeRange = New System.Windows.Forms.AGaugeRange()
        Dim AGaugeRange7 As System.Windows.Forms.AGaugeRange = New System.Windows.Forms.AGaugeRange()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.AGauge1 = New System.Windows.Forms.AGauge()
        Me.AGauge2 = New System.Windows.Forms.AGauge()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Serial Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(459, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Baud Rate"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(139, 68)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(308, 33)
        Me.ComboBox1.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(584, 68)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(308, 33)
        Me.ComboBox2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(904, 61)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 44)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(904, 117)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(174, 44)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Disconnect"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(15, 207)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Temp.:"
        '
        'Timer1
        '
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(998, 569)
        Me.Button3.Margin = New System.Windows.Forms.Padding(6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 58)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(176, 207)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "°C"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(4, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(672, 46)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "TEMPERATURE CONTROL PANEL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(459, 207)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Power:"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.ForeColor = System.Drawing.Color.Red
        Me.TextBox3.Location = New System.Drawing.Point(208, 124)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(228, 39)
        Me.TextBox3.TabIndex = 18
        '
        'TextBox4
        '
        Me.TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox4.Location = New System.Drawing.Point(11, 124)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(192, 39)
        Me.TextBox4.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(103, 207)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 25)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(549, 207)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 25)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.CausesValidation = False
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(624, 207)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 25)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(15, 127)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 25)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "connection status"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(215, 127)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 25)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "data status"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Blue
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(904, 197)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(174, 44)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "+10 POWER"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(904, 253)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(174, 44)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "-10 POWER"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'AGauge1
        '
        Me.AGauge1.BaseArcColor = System.Drawing.Color.Gray
        Me.AGauge1.BaseArcRadius = 80
        Me.AGauge1.BaseArcStart = 135
        Me.AGauge1.BaseArcSweep = 135
        Me.AGauge1.BaseArcWidth = 2
        Me.AGauge1.Center = New System.Drawing.Point(105, 105)
        AGaugeRange1.Color = System.Drawing.Color.Cyan
        AGaugeRange1.EndValue = 5.0!
        AGaugeRange1.InnerRadius = 20
        AGaugeRange1.InRange = False
        AGaugeRange1.Name = "GaugeRange1"
        AGaugeRange1.OuterRadius = 80
        AGaugeRange1.StartValue = -15.0!
        AGaugeRange2.Color = System.Drawing.Color.Lime
        AGaugeRange2.EndValue = 20.0!
        AGaugeRange2.InnerRadius = 20
        AGaugeRange2.InRange = False
        AGaugeRange2.Name = "GaugeRange2"
        AGaugeRange2.OuterRadius = 80
        AGaugeRange2.StartValue = 5.0!
        AGaugeRange3.Color = System.Drawing.Color.Yellow
        AGaugeRange3.EndValue = 30.0!
        AGaugeRange3.InnerRadius = 20
        AGaugeRange3.InRange = False
        AGaugeRange3.Name = "GaugeRange3"
        AGaugeRange3.OuterRadius = 80
        AGaugeRange3.StartValue = 20.0!
        AGaugeRange4.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        AGaugeRange4.EndValue = 38.0!
        AGaugeRange4.InnerRadius = 20
        AGaugeRange4.InRange = False
        AGaugeRange4.Name = "GaugeRange4"
        AGaugeRange4.OuterRadius = 80
        AGaugeRange4.StartValue = 30.0!
        AGaugeRange5.Color = System.Drawing.Color.Red
        AGaugeRange5.EndValue = 45.0!
        AGaugeRange5.InnerRadius = 20
        AGaugeRange5.InRange = False
        AGaugeRange5.Name = "GaugeRange5"
        AGaugeRange5.OuterRadius = 80
        AGaugeRange5.StartValue = 38.0!
        Me.AGauge1.GaugeRanges.Add(AGaugeRange1)
        Me.AGauge1.GaugeRanges.Add(AGaugeRange2)
        Me.AGauge1.GaugeRanges.Add(AGaugeRange3)
        Me.AGauge1.GaugeRanges.Add(AGaugeRange4)
        Me.AGauge1.GaugeRanges.Add(AGaugeRange5)
        Me.AGauge1.Location = New System.Drawing.Point(85, 268)
        Me.AGauge1.MaxValue = 45.0!
        Me.AGauge1.MinValue = -15.0!
        Me.AGauge1.Name = "AGauge1"
        Me.AGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray
        Me.AGauge1.NeedleColor2 = System.Drawing.Color.DimGray
        Me.AGauge1.NeedleRadius = 80
        Me.AGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance
        Me.AGauge1.NeedleWidth = 2
        Me.AGauge1.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.AGauge1.ScaleLinesInterInnerRadius = 73
        Me.AGauge1.ScaleLinesInterOuterRadius = 80
        Me.AGauge1.ScaleLinesInterWidth = 1
        Me.AGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.AGauge1.ScaleLinesMajorInnerRadius = 70
        Me.AGauge1.ScaleLinesMajorOuterRadius = 80
        Me.AGauge1.ScaleLinesMajorStepValue = 15.0!
        Me.AGauge1.ScaleLinesMajorWidth = 2
        Me.AGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.AGauge1.ScaleLinesMinorInnerRadius = 75
        Me.AGauge1.ScaleLinesMinorOuterRadius = 80
        Me.AGauge1.ScaleLinesMinorTicks = 9
        Me.AGauge1.ScaleLinesMinorWidth = 1
        Me.AGauge1.ScaleNumbersColor = System.Drawing.Color.Black
        Me.AGauge1.ScaleNumbersFormat = Nothing
        Me.AGauge1.ScaleNumbersRadius = 95
        Me.AGauge1.ScaleNumbersRotation = 1
        Me.AGauge1.ScaleNumbersStartScaleLine = 0
        Me.AGauge1.ScaleNumbersStepScaleLines = 1
        Me.AGauge1.Size = New System.Drawing.Size(438, 359)
        Me.AGauge1.TabIndex = 27
        Me.AGauge1.Text = "AGauge1"
        Me.AGauge1.Value = 0!
        '
        'AGauge2
        '
        Me.AGauge2.BaseArcColor = System.Drawing.Color.Gray
        Me.AGauge2.BaseArcRadius = 80
        Me.AGauge2.BaseArcStart = 135
        Me.AGauge2.BaseArcSweep = 135
        Me.AGauge2.BaseArcWidth = 2
        Me.AGauge2.Center = New System.Drawing.Point(105, 105)
        AGaugeRange6.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        AGaugeRange6.EndValue = 50.0!
        AGaugeRange6.InnerRadius = 20
        AGaugeRange6.InRange = False
        AGaugeRange6.Name = "GaugeRange1"
        AGaugeRange6.OuterRadius = 80
        AGaugeRange6.StartValue = 0!
        AGaugeRange7.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        AGaugeRange7.EndValue = 100.0!
        AGaugeRange7.InnerRadius = 20
        AGaugeRange7.InRange = False
        AGaugeRange7.Name = "GaugeRange2"
        AGaugeRange7.OuterRadius = 80
        AGaugeRange7.StartValue = 50.0!
        Me.AGauge2.GaugeRanges.Add(AGaugeRange6)
        Me.AGauge2.GaugeRanges.Add(AGaugeRange7)
        Me.AGauge2.Location = New System.Drawing.Point(529, 268)
        Me.AGauge2.MaxValue = 100.0!
        Me.AGauge2.MinValue = 0!
        Me.AGauge2.Name = "AGauge2"
        Me.AGauge2.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray
        Me.AGauge2.NeedleColor2 = System.Drawing.Color.DimGray
        Me.AGauge2.NeedleRadius = 80
        Me.AGauge2.NeedleType = System.Windows.Forms.NeedleType.Advance
        Me.AGauge2.NeedleWidth = 2
        Me.AGauge2.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.AGauge2.ScaleLinesInterInnerRadius = 73
        Me.AGauge2.ScaleLinesInterOuterRadius = 80
        Me.AGauge2.ScaleLinesInterWidth = 1
        Me.AGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.AGauge2.ScaleLinesMajorInnerRadius = 70
        Me.AGauge2.ScaleLinesMajorOuterRadius = 80
        Me.AGauge2.ScaleLinesMajorStepValue = 50.0!
        Me.AGauge2.ScaleLinesMajorWidth = 2
        Me.AGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.AGauge2.ScaleLinesMinorInnerRadius = 75
        Me.AGauge2.ScaleLinesMinorOuterRadius = 80
        Me.AGauge2.ScaleLinesMinorTicks = 9
        Me.AGauge2.ScaleLinesMinorWidth = 1
        Me.AGauge2.ScaleNumbersColor = System.Drawing.Color.Black
        Me.AGauge2.ScaleNumbersFormat = Nothing
        Me.AGauge2.ScaleNumbersRadius = 95
        Me.AGauge2.ScaleNumbersRotation = 1
        Me.AGauge2.ScaleNumbersStartScaleLine = 0
        Me.AGauge2.ScaleNumbersStepScaleLines = 1
        Me.AGauge2.Size = New System.Drawing.Size(363, 359)
        Me.AGauge2.TabIndex = 28
        Me.AGauge2.Text = "AGauge2"
        Me.AGauge2.Value = 0!
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 642)
        Me.Controls.Add(Me.AGauge2)
        Me.Controls.Add(Me.AGauge1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmMain"
        Me.Text = "Temperature Control Panel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents AGauge1 As AGauge
    Friend WithEvents AGauge2 As AGauge
End Class
