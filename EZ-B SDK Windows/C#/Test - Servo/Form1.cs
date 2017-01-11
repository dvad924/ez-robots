using System;
using System.Windows.Forms;
using EZ_B;

namespace Test___Servo {

  public partial class Form1 : Form {

    public Form1() {

      InitializeComponent();

      trackBar1.Minimum = Servo.SERVO_MIN;
      trackBar1.Maximum = Servo.SERVO_MAX;
    }

    private void trackBar1_Scroll(object sender, EventArgs e) {

      int value = trackBar1.Value;

      label2.Text = value.ToString();

      eZ_Z_Connect1.EZB.Servo.SetServoPosition(Servo.ServoPortEnum.D0, value, (int)numericUpDown1.Value);

      return;

      foreach (Servo.ServoPortEnum item in Enum.GetValues(typeof(Servo.ServoPortEnum)))
        eZ_Z_Connect1.EZB.Servo.SetServoPosition(item, trackBar1.Value);
    }

    private void button1_Click(object sender, EventArgs e) {

      eZ_Z_Connect1.EZB.Servo.ReleaseAllServos();
    }

    private void button2_Click(object sender, EventArgs e) {

      foreach (Servo.ServoPortEnum item in Enum.GetValues(typeof(Servo.ServoPortEnum)))
        eZ_Z_Connect1.EZB.Servo.SetServoPosition(item, 20);
    }
  }
}
