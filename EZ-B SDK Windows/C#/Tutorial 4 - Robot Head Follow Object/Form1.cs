using System;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_4___Robot_Head_Follow_Object {

  public partial class Form1 : Form {

    EZB _ezb = new EZB();
    bool _headDir = true;

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

      int headPosition = _ezb.Servo.GetServoPosition(Servo.ServoPortEnum.D14);

      label1.Text = string.Format("{0} / {1}", adc, headPosition);

      if (adc > 80)
        return;

      if (headPosition == 5)
        _headDir = true;

      if (headPosition == 17)
        _headDir = false;

      if (_headDir)
        headPosition++;
      else
        headPosition--;

      _ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D14, headPosition);
    }
  }
}
