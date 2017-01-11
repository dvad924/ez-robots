using System;
using System.Linq;
using System.Windows.Forms;
using EZ_B;

namespace Test_Connection {

  public partial class Form1 : Form {

    public Form1() {

      InitializeComponent();

      ezB_Connect1.EZB.ShowDebugWindow();
      ezB_Connect1.EZB.VerboseLogging = true;

      trackBar1.Minimum = Servo.SERVO_MIN;
      trackBar1.Maximum = Servo.SERVO_MAX;
      trackBar1.Value = Servo.SERVO_CENTER;
    }

    private void Form1_Load(object sender, EventArgs e) {

    }

    private void trackBar1_Scroll(object sender, EventArgs e) {

      if (!ezB_Connect1.EZB.IsConnected)
        return;
      
      foreach (Servo.ServoPortEnum item in Enum.GetValues(typeof(Servo.ServoPortEnum)))
        ezB_Connect1.EZB.Servo.SetServoPosition(item, (int)trackBar1.Value);
    }

    private void button2_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Servo.ReleaseAllServos();
    }
  }
}
