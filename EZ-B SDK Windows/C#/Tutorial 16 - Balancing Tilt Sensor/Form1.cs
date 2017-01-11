using System;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_16___Balancing_Tilt_Sensor {

  public partial class Form1 : Form {

    public Form1() {

      InitializeComponent();

      timer1.Interval = 100;
      timer1.Start();
    }

    private void timer1_Tick(object sender, EventArgs e) {

      if (!ezB_Connect1.EZB.IsConnected)
        return;

      int pos = ezB_Connect1.EZB.Servo.GetServoPosition(Servo.ServoPortEnum.D14);

      if (ezB_Connect1.EZB.Digital.GetDigitalPort(Digital.DigitalPortEnum.D15))
        pos++;

      if (ezB_Connect1.EZB.Digital.GetDigitalPort(Digital.DigitalPortEnum.D16))
        pos--;

      ezB_Connect1.EZB.Servo.SetServoPosition(Servo.ServoPortEnum.D14, pos);
    }
  }
}
