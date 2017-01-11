<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Me.groupBox1 = New System.Windows.Forms.GroupBox()
    Me.label3 = New System.Windows.Forms.Label()
    Me.tbMinObjectSize = New System.Windows.Forms.TrackBar()
    Me.label2 = New System.Windows.Forms.Label()
    Me.panel2 = New System.Windows.Forms.Panel()
    Me.tbBrightness = New System.Windows.Forms.TrackBar()
    Me.comboBox3 = New System.Windows.Forms.ComboBox()
    Me.tbLog = New System.Windows.Forms.TextBox()
    Me.panel1 = New System.Windows.Forms.Panel()
    Me.label1 = New System.Windows.Forms.Label()
    Me.comboBox1 = New System.Windows.Forms.ComboBox()
    Me.EzB_Connect1 = New EZ_B.UCEZB_Connect()
    Me.groupBox1.SuspendLayout()
    CType(Me.tbMinObjectSize, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.tbBrightness, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'groupBox1
    '
    Me.groupBox1.Controls.Add(Me.label3)
    Me.groupBox1.Controls.Add(Me.tbMinObjectSize)
    Me.groupBox1.Controls.Add(Me.label2)
    Me.groupBox1.Controls.Add(Me.panel2)
    Me.groupBox1.Controls.Add(Me.tbBrightness)
    Me.groupBox1.Controls.Add(Me.comboBox3)
    Me.groupBox1.Controls.Add(Me.tbLog)
    Me.groupBox1.Controls.Add(Me.panel1)
    Me.groupBox1.Controls.Add(Me.label1)
    Me.groupBox1.Controls.Add(Me.comboBox1)
    Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.groupBox1.Location = New System.Drawing.Point(0, 31)
    Me.groupBox1.Name = "groupBox1"
    Me.groupBox1.Size = New System.Drawing.Size(1042, 615)
    Me.groupBox1.TabIndex = 3
    Me.groupBox1.TabStop = False
    Me.groupBox1.Text = "Commands"
    '
    'label3
    '
    Me.label3.AutoSize = True
    Me.label3.Location = New System.Drawing.Point(809, 170)
    Me.label3.Name = "label3"
    Me.label3.Size = New System.Drawing.Size(81, 13)
    Me.label3.TabIndex = 10
    Me.label3.Text = "Min Object Size"
    '
    'tbMinObjectSize
    '
    Me.tbMinObjectSize.LargeChange = 25
    Me.tbMinObjectSize.Location = New System.Drawing.Point(738, 138)
    Me.tbMinObjectSize.Maximum = 200
    Me.tbMinObjectSize.Minimum = 1
    Me.tbMinObjectSize.Name = "tbMinObjectSize"
    Me.tbMinObjectSize.Size = New System.Drawing.Size(220, 45)
    Me.tbMinObjectSize.SmallChange = 25
    Me.tbMinObjectSize.TabIndex = 9
    Me.tbMinObjectSize.TickFrequency = 25
    Me.tbMinObjectSize.Value = 100
    '
    'label2
    '
    Me.label2.AutoSize = True
    Me.label2.Location = New System.Drawing.Point(821, 60)
    Me.label2.Name = "label2"
    Me.label2.Size = New System.Drawing.Size(56, 13)
    Me.label2.TabIndex = 8
    Me.label2.Text = "Brightness"
    '
    'panel2
    '
    Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.panel2.Location = New System.Drawing.Point(386, 45)
    Me.panel2.Name = "panel2"
    Me.panel2.Size = New System.Drawing.Size(346, 286)
    Me.panel2.TabIndex = 7
    '
    'tbBrightness
    '
    Me.tbBrightness.LargeChange = 25
    Me.tbBrightness.Location = New System.Drawing.Point(738, 28)
    Me.tbBrightness.Maximum = 200
    Me.tbBrightness.Minimum = 1
    Me.tbBrightness.Name = "tbBrightness"
    Me.tbBrightness.Size = New System.Drawing.Size(220, 45)
    Me.tbBrightness.SmallChange = 25
    Me.tbBrightness.TabIndex = 6
    Me.tbBrightness.TickFrequency = 25
    Me.tbBrightness.Value = 100
    '
    'comboBox3
    '
    Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.comboBox3.FormattingEnabled = True
    Me.comboBox3.Location = New System.Drawing.Point(738, 90)
    Me.comboBox3.Name = "comboBox3"
    Me.comboBox3.Size = New System.Drawing.Size(89, 21)
    Me.comboBox3.TabIndex = 5
    '
    'tbLog
    '
    Me.tbLog.BackColor = System.Drawing.Color.Black
    Me.tbLog.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.tbLog.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.tbLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.tbLog.Location = New System.Drawing.Point(3, 359)
    Me.tbLog.Multiline = True
    Me.tbLog.Name = "tbLog"
    Me.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.tbLog.Size = New System.Drawing.Size(1036, 253)
    Me.tbLog.TabIndex = 3
    '
    'panel1
    '
    Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.panel1.Location = New System.Drawing.Point(9, 45)
    Me.panel1.Name = "panel1"
    Me.panel1.Size = New System.Drawing.Size(371, 286)
    Me.panel1.TabIndex = 2
    '
    'label1
    '
    Me.label1.AutoSize = True
    Me.label1.Location = New System.Drawing.Point(6, 22)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(71, 13)
    Me.label1.TabIndex = 1
    Me.label1.Text = "Video Device"
    '
    'comboBox1
    '
    Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.comboBox1.FormattingEnabled = True
    Me.comboBox1.Location = New System.Drawing.Point(80, 18)
    Me.comboBox1.Name = "comboBox1"
    Me.comboBox1.Size = New System.Drawing.Size(205, 21)
    Me.comboBox1.TabIndex = 0
    '
    'EzB_Connect1
    '
    Me.EzB_Connect1.Dock = System.Windows.Forms.DockStyle.Top
    Me.EzB_Connect1.Location = New System.Drawing.Point(0, 0)
    Me.EzB_Connect1.Name = "EzB_Connect1"
    Me.EzB_Connect1.Port = ""
    Me.EzB_Connect1.ShowDebugButton = True
    Me.EzB_Connect1.Size = New System.Drawing.Size(1042, 31)
    Me.EzB_Connect1.TabIndex = 11
    Me.EzB_Connect1.TCPPassword = Nothing
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1042, 646)
    Me.Controls.Add(Me.groupBox1)
    Me.Controls.Add(Me.EzB_Connect1)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.groupBox1.ResumeLayout(False)
    Me.groupBox1.PerformLayout()
    CType(Me.tbMinObjectSize, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.tbBrightness, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents tbMinObjectSize As System.Windows.Forms.TrackBar
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents tbBrightness As System.Windows.Forms.TrackBar
    Private WithEvents comboBox3 As System.Windows.Forms.ComboBox
    Private WithEvents tbLog As System.Windows.Forms.TextBox
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents label1 As System.Windows.Forms.Label
  Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
  Friend WithEvents EzB_Connect1 As EZ_B.UCEZB_Connect

End Class
