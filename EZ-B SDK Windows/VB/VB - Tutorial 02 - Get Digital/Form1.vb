Public Class Form1

    Private Sub EzB_Connect1_OnConnection() Handles EzB_Connect1.OnConnection

        Timer1.Interval = 250

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        If (EzB_Connect1.EZB.IsConnected = False) Then

            Return
        End If

        CheckBox1.Checked = EzB_Connect1.EZB.Digital.GetDigitalPort(EZ_B.Digital.DigitalPortEnum.D0)
        CheckBox2.Checked = EzB_Connect1.EZB.Digital.GetDigitalPort(EZ_B.Digital.DigitalPortEnum.D1)
        CheckBox3.Checked = EzB_Connect1.EZB.Digital.GetDigitalPort(EZ_B.Digital.DigitalPortEnum.D2)
        CheckBox4.Checked = EzB_Connect1.EZB.Digital.GetDigitalPort(EZ_B.Digital.DigitalPortEnum.D3)
        CheckBox5.Checked = EzB_Connect1.EZB.Digital.GetDigitalPort(EZ_B.Digital.DigitalPortEnum.D4)
    End Sub
End Class
