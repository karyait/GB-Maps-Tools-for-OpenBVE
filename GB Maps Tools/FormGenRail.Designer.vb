<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGenRail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGenRail))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ButtonGen = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNvImg = New System.Windows.Forms.Button()
        Me.btnPtImg = New System.Windows.Forms.Button()
        Me.cbtype = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxImg1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxImg0 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxGauge = New System.Windows.Forms.TextBox()
        Me.TextBoxSw1 = New System.Windows.Forms.TextBox()
        Me.TextBoxSw0 = New System.Windows.Forms.TextBox()
        Me.TextBoxfiledir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDownNo = New System.Windows.Forms.NumericUpDown()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonGenRadius = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDownNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 166)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(767, 10)
        Me.ProgressBar1.TabIndex = 6
        Me.ProgressBar1.Visible = False
        '
        'ButtonGen
        '
        Me.ButtonGen.Location = New System.Drawing.Point(788, 160)
        Me.ButtonGen.Name = "ButtonGen"
        Me.ButtonGen.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGen.TabIndex = 5
        Me.ButtonGen.Text = "Generate"
        Me.ButtonGen.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonGenRadius)
        Me.GroupBox1.Controls.Add(Me.btnNvImg)
        Me.GroupBox1.Controls.Add(Me.btnPtImg)
        Me.GroupBox1.Controls.Add(Me.cbtype)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBoxImg1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtRadius)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBoxImg0)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxGauge)
        Me.GroupBox1.Controls.Add(Me.TextBoxSw1)
        Me.GroupBox1.Controls.Add(Me.TextBoxSw0)
        Me.GroupBox1.Controls.Add(Me.TextBoxfiledir)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxTitle)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownNo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(853, 142)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'btnNvImg
        '
        Me.btnNvImg.Image = CType(resources.GetObject("btnNvImg.Image"), System.Drawing.Image)
        Me.btnNvImg.Location = New System.Drawing.Point(448, 111)
        Me.btnNvImg.Name = "btnNvImg"
        Me.btnNvImg.Size = New System.Drawing.Size(23, 23)
        Me.btnNvImg.TabIndex = 26
        Me.btnNvImg.UseVisualStyleBackColor = True
        '
        'btnPtImg
        '
        Me.btnPtImg.Image = CType(resources.GetObject("btnPtImg.Image"), System.Drawing.Image)
        Me.btnPtImg.Location = New System.Drawing.Point(205, 111)
        Me.btnPtImg.Name = "btnPtImg"
        Me.btnPtImg.Size = New System.Drawing.Size(23, 23)
        Me.btnPtImg.TabIndex = 25
        Me.btnPtImg.UseVisualStyleBackColor = True
        '
        'cbtype
        '
        Me.cbtype.FormattingEnabled = True
        Me.cbtype.Items.AddRange(New Object() {"ballast", "slab"})
        Me.cbtype.Location = New System.Drawing.Point(347, 30)
        Me.cbtype.Name = "cbtype"
        Me.cbtype.Size = New System.Drawing.Size(58, 21)
        Me.cbtype.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(249, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "-ve radius image"
        '
        'TextBoxImg1
        '
        Me.TextBoxImg1.Location = New System.Drawing.Point(342, 113)
        Me.TextBoxImg1.Name = "TextBoxImg1"
        Me.TextBoxImg1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxImg1.TabIndex = 22
        Me.TextBoxImg1.Text = "bl1rXXXXX.png"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(714, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 32)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "(split with comma, i.e. : 162,-162,512,-512 )"
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(58, 55)
        Me.txtRadius.Multiline = True
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(650, 49)
        Me.txtRadius.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "+ve radius image"
        '
        'TextBoxImg0
        '
        Me.TextBoxImg0.Location = New System.Drawing.Point(99, 113)
        Me.TextBoxImg0.Name = "TextBoxImg0"
        Me.TextBoxImg0.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxImg0.TabIndex = 18
        Me.TextBoxImg0.Text = "bl1rXXXXX.png"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(800, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Gauge"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Radius"
        '
        'TextBoxGauge
        '
        Me.TextBoxGauge.Location = New System.Drawing.Point(803, 29)
        Me.TextBoxGauge.Name = "TextBoxGauge"
        Me.TextBoxGauge.Size = New System.Drawing.Size(39, 20)
        Me.TextBoxGauge.TabIndex = 15
        Me.TextBoxGauge.Text = "1067"
        '
        'TextBoxSw1
        '
        Me.TextBoxSw1.Location = New System.Drawing.Point(773, 29)
        Me.TextBoxSw1.Name = "TextBoxSw1"
        Me.TextBoxSw1.Size = New System.Drawing.Size(24, 20)
        Me.TextBoxSw1.TabIndex = 14
        Me.TextBoxSw1.Text = "0"
        '
        'TextBoxSw0
        '
        Me.TextBoxSw0.Location = New System.Drawing.Point(744, 29)
        Me.TextBoxSw0.Name = "TextBoxSw0"
        Me.TextBoxSw0.Size = New System.Drawing.Size(23, 20)
        Me.TextBoxSw0.TabIndex = 13
        Me.TextBoxSw0.Text = "0"
        '
        'TextBoxfiledir
        '
        Me.TextBoxfiledir.Location = New System.Drawing.Point(411, 29)
        Me.TextBoxfiledir.Name = "TextBoxfiledir"
        Me.TextBoxfiledir.Size = New System.Drawing.Size(327, 20)
        Me.TextBoxfiledir.TabIndex = 11
        Me.TextBoxfiledir.Text = "gb_maps\rail\1067\ballast\1067ballast1rXXXXXi0o105.csv"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(408, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "file dir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(344, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Title"
        '
        'TextBoxTitle
        '
        Me.TextBoxTitle.Location = New System.Drawing.Point(172, 29)
        Me.TextBoxTitle.Name = "TextBoxTitle"
        Me.TextBoxTitle.Size = New System.Drawing.Size(169, 20)
        Me.TextBoxTitle.TabIndex = 4
        Me.TextBoxTitle.Text = "Curve RXXXXX 1067mm - 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(58, 29)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(108, 20)
        Me.TextBoxName.TabIndex = 2
        Me.TextBoxName.Text = "BL1067-1RXXXXX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Start No"
        '
        'NumericUpDownNo
        '
        Me.NumericUpDownNo.Location = New System.Drawing.Point(6, 30)
        Me.NumericUpDownNo.Maximum = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
        Me.NumericUpDownNo.Name = "NumericUpDownNo"
        Me.NumericUpDownNo.Size = New System.Drawing.Size(45, 20)
        Me.NumericUpDownNo.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ButtonGenRadius
        '
        Me.ButtonGenRadius.Image = CType(resources.GetObject("ButtonGenRadius.Image"), System.Drawing.Image)
        Me.ButtonGenRadius.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonGenRadius.Location = New System.Drawing.Point(596, 110)
        Me.ButtonGenRadius.Name = "ButtonGenRadius"
        Me.ButtonGenRadius.Size = New System.Drawing.Size(112, 23)
        Me.ButtonGenRadius.TabIndex = 52
        Me.ButtonGenRadius.Text = "Generate Radius"
        Me.ButtonGenRadius.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonGenRadius.UseVisualStyleBackColor = True
        '
        'FormGenRail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 193)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ButtonGen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormGenRail"
        Me.ShowInTaskbar = False
        Me.Text = "FormGenRail"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDownNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ButtonGen As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxImg0 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxGauge As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSw1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSw0 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxfiledir As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownNo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxImg1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRadius As System.Windows.Forms.TextBox
    Friend WithEvents cbtype As System.Windows.Forms.ComboBox
    Friend WithEvents btnNvImg As System.Windows.Forms.Button
    Friend WithEvents btnPtImg As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ButtonGenRadius As System.Windows.Forms.Button
End Class
