using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tutorial_30___SDK_Client {

  public partial class Form1 : Form {

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.Port = "127.0.0.1:6666";

      trackBar1.Value = EZ_B.Servo.SERVO_MIN;
      trackBar1.Minimum = 0;
      trackBar1.Maximum = EZ_B.Servo.SERVO_MAX;
    }

    private void trackBar1_Scroll(object sender, EventArgs e) {

      ezB_Connect1.EZB.Servo.SetServoPosition(EZ_B.Servo.ServoPortEnum.D0, trackBar1.Value);
    }
  }
}
