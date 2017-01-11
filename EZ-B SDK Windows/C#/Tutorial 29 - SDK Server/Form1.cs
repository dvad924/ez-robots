using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_29___SDK_Server {

  public partial class Form1 : Form {

    Timer _timer = new Timer();

    public Form1() {

      InitializeComponent();

      trackBar1.Value = EZ_B.Servo.SERVO_MIN;
      trackBar1.Minimum = 0;
      trackBar1.Maximum = EZ_B.Servo.SERVO_MAX;

      _timer.Interval = 250;
      _timer.Tick += new EventHandler(_timer_Tick);
      _timer.Start();
    }

    void _timer_Tick(object sender, EventArgs e) {

      if (!ezB_Connect1.EZB.IsConnected)
        return;

      trackBar1.Value = ezB_Connect1.EZB.Servo.GetServoPosition(Servo.ServoPortEnum.D0);
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.EZB.TCPServer.Start(6666);
    }

    private void trackBar1_Scroll(object sender, EventArgs e) {

      ezB_Connect1.EZB.Servo.SetServoPosition(EZ_B.Servo.ServoPortEnum.D0, trackBar1.Value);
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

      ezB_Connect1.EZB.TCPServer.Stop();
    }
  }
}
