Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TrackBar1.Minimum = EZ_B.Servo.SERVO_MIN
        TrackBar1.Maximum = EZ_B.Servo.SERVO_MAX
        TrackBar1.Value = EZ_B.Servo.SERVO_CENTER
    End Sub


    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll

        EzB_Connect1.EZB.Servo.SetServoPosition(EZ_B.Servo.ServoPortEnum.D14, TrackBar1.Value)
    End Sub

    Private Sub btnGetADC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetADC.Click

        lblADCVal.Text = String.Format("{0} Volts", EzB_Connect1.EZB.ADC.GetADCVoltage(EZ_B.ADC.ADCPortEnum.ADC0))
    End Sub
End Class
