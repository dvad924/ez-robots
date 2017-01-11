using System;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_3___Move_Servo_With_ADC {

  public partial class Form1 : Form {

    EZB _ezb = new EZB();

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.EZB = _ezb;

      timer1.Interval = 250;
      timer1.Start();
    }

    private void timer1_Tick(object sender, EventArgs e) {

      if (!_ezb.IsConnected)
        return;

      int adc = _ezb.ADC.GetADCValue(ADC.ADCPortEnum.ADC0);

      int servoPosition = Convert.ToInt16(Functions.GetScalarFromRange(180, 255, 0) * adc);

      label1.Text = string.Format("{0} / {1}", adc, servoPosition);

      _ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D14, servoPosition);
    }
  }
}
