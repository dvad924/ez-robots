using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tutorial_34___Vuzix_Virtual_Reality {

  public partial class Form1 : Form {

    Timer _timer = new Timer();

    readonly int _xMax = 70;
    readonly int _xMin = 1;
    readonly int _yMax = 70;
    readonly int _yMin = 1;

    public Form1() {

      InitializeComponent();

      _timer.Interval = 50;
      _timer.Tick += new EventHandler(_timer_Tick);
      _timer.Start();

      try {

        ezB_Connect1.EZB.Vuzix.Open();
      } catch (Exception e) {

        textBox1.AppendText("Error: " + e.Message);
        textBox1.AppendText(Environment.NewLine);
      }
    }

    void _timer_Tick(object sender, EventArgs e) {

      if (!ezB_Connect1.EZB.Vuzix.Connected)
        return;

      EZ_B.Classes.VuzixPosition pos = ezB_Connect1.EZB.Vuzix.Poll();

      ezB_Connect1.EZB.Servo.SetServoPositionScalar(EZ_B.Servo.ServoPortEnum.D7, _xMin, _xMax, -15000f, 15000f, pos.Pitch, false);

      ezB_Connect1.EZB.Servo.SetServoPositionScalar(EZ_B.Servo.ServoPortEnum.D6, _yMin, _yMax, -15000f, 15000f, pos.Roll, false);

      textBox1.AppendText(pos.ToString());
      textBox1.AppendText(Environment.NewLine);
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

      ezB_Connect1.EZB.Vuzix.Close();
    }

    private void button1_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Vuzix.SetToZero();
    }
  }
}
