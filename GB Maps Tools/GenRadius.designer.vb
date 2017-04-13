<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenRadius
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
        Me.CheckedListBoxDesignSpeed = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDownCant = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDownGauge = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonGenerate = New System.Windows.Forms.Button()
        CType(Me.NumericUpDownCant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownGauge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckedListBoxDesignSpeed
        '
        Me.CheckedListBoxDesignSpeed.ColumnWidth = 55
        Me.CheckedListBoxDesignSpeed.FormattingEnabled = True
        Me.CheckedListBoxDesignSpeed.HorizontalScrollbar = True
        Me.CheckedListBoxDesignSpeed.Items.AddRange(New Object() {"15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90", "95", "100", "105", "110", "115", "120", "125", "130", "140", "150", "160", "170", "180", "190", "200", "210", "220", "230", "240", "250", "260", "270", "280", "290", "300", "310", "320", "330", "340", "350", "360", "370", "380", "390", "400", "410", "420", "430", "440", "450", "460", "470", "480", "490", "500", "510"})
        Me.CheckedListBoxDesignSpeed.Location = New System.Drawing.Point(12, 27)
        Me.CheckedListBoxDesignSpeed.MultiColumn = True
        Me.CheckedListBoxDesignSpeed.Name = "CheckedListBoxDesignSpeed"
        Me.CheckedListBoxDesignSpeed.Size = New System.Drawing.Size(384, 229)
        Me.CheckedListBoxDesignSpeed.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select design speeds (kph) :"
        '
        'NumericUpDownCant
        '
        Me.NumericUpDownCant.Location = New System.Drawing.Point(453, 27)
        Me.NumericUpDownCant.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDownCant.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownCant.Name = "NumericUpDownCant"
        Me.NumericUpDownCant.Size = New System.Drawing.Size(51, 20)
        Me.NumericUpDownCant.TabIndex = 2
        Me.NumericUpDownCant.Value = New Decimal(New Integer() {105, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(402, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cant :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(510, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "mm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(402, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Gauge :"
        '
        'NumericUpDownGauge
        '
        Me.NumericUpDownGauge.Location = New System.Drawing.Point(453, 52)
        Me.NumericUpDownGauge.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NumericUpDownGauge.Minimum = New Decimal(New Integer() {1067, 0, 0, 0})
        Me.NumericUpDownGauge.Name = "NumericUpDownGauge"
        Me.NumericUpDownGauge.Size = New System.Drawing.Size(51, 20)
        Me.NumericUpDownGauge.TabIndex = 6
        Me.NumericUpDownGauge.Value = New Decimal(New Integer() {1067, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(510, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "mm"
        '
        'ButtonGenerate
        '
        Me.ButtonGenerate.Location = New System.Drawing.Point(462, 227)
        Me.ButtonGenerate.Name = "ButtonGenerate"
        Me.ButtonGenerate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGenerate.TabIndex = 8
        Me.ButtonGenerate.Text = "Generate"
        Me.ButtonGenerate.UseVisualStyleBackColor = True
        '
        'GenRadius
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 262)
        Me.Controls.Add(Me.ButtonGenerate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDownGauge)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDownCant)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckedListBoxDesignSpeed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GenRadius"
        Me.Text = "Generate Radius"
        CType(Me.NumericUpDownCant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownGauge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckedListBoxDesignSpeed As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownCant As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownGauge As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButtonGenerate As System.Windows.Forms.Button
End Class
