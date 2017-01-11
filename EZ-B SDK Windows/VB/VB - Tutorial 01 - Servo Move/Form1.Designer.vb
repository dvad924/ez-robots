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
        Me.components = New System.ComponentModel.Container
    Me.EzB_Connect1 = New EZ_B.UCEZB_Connect
        Me.TrackBar1 = New System.Windows.Forms.TrackBar
        Me.btnGetADC = New System.Windows.Forms.Button
        Me.lblADCVal = New System.Windows.Forms.Label
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EzB_Connect1
        '
        Me.EzB_Connect1.Location = New System.Drawing.Point(0, 0)
        Me.EzB_Connect1.Name = "EzB_Connect1"
        Me.EzB_Connect1.Size = New System.Drawing.Size(283, 31)
        Me.EzB_Connect1.TabIndex = 0
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(121, 102)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(177, 45)
        Me.TrackBar1.TabIndex = 1
        '
        'btnGetADC
        '
        Me.btnGetADC.Location = New System.Drawing.Point(12, 185)
        Me.btnGetADC.Name = "btnGetADC"
        Me.btnGetADC.Size = New System.Drawing.Size(75, 23)
        Me.btnGetADC.TabIndex = 2
        Me.btnGetADC.Text = "Get ADC"
        Me.btnGetADC.UseVisualStyleBackColor = True
        '
        'lblADCVal
        '
        Me.lblADCVal.AutoSize = True
        Me.lblADCVal.Location = New System.Drawing.Point(93, 190)
        Me.lblADCVal.Name = "lblADCVal"
        Me.lblADCVal.Size = New System.Drawing.Size(39, 13)
        Me.lblADCVal.TabIndex = 3
        Me.lblADCVal.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 378)
        Me.Controls.Add(Me.lblADCVal)
        Me.Controls.Add(Me.btnGetADC)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.EzB_Connect1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents EzB_Connect1 As EZ_B.UCEZB_Connect
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents btnGetADC As System.Windows.Forms.Button
    Friend WithEvents lblADCVal As System.Windows.Forms.Label

End Class
