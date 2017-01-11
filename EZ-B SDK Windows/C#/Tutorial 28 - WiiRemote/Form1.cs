using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_28___WiiRemote {

  public partial class Form1 : Form {

    EZ_B.WiimoteLib.Wiimote _wm;
    Graphics                _graphics;
    Timer                   _timer =new Timer();

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      _graphics = panel1.CreateGraphics();

      cbX.Items.Clear();
      cbY.Items.Clear();
      foreach (EZ_B.Servo.ServoPortEnum item in Enum.GetValues(typeof(EZ_B.Servo.ServoPortEnum))) {

        cbX.Items.Add(item);
        cbY.Items.Add(item);
      }

      cbX.SelectedItem = Servo.ServoPortEnum.D8;
      cbY.SelectedItem = Servo.ServoPortEnum.D7;

      _timer.Interval = 100;
      _timer.Tick += new EventHandler(_timer_Tick);
    }

    private void cbWii_SelectedIndexChanged(object sender, EventArgs e) {

      if (cbWii.SelectedIndex < 0)
        return;

      _wm = ezB_Connect1.EZB.WiiRemote.GetWiiRemoteByHID(cbWii.SelectedItem.ToString());
      _wm.Connect();
      _wm.SetReportType(EZ_B.WiimoteLib.InputReport.IRAccel, true);
      _wm.SetLEDs(false, true, true, false);

      cbWii.Enabled = false;
      _timer.Start();
    }

    void _timer_Tick(object sender, EventArgs e) {

      if (_wm == null)
        return;

      _graphics.Clear(Color.Black);

      float x = _wm.WiimoteState.AccelState.Values.X;
      float y = _wm.WiimoteState.AccelState.Values.Y;

      int xPos = (int)(x * Functions.GetScalarFromRange(panel1.Width, 1f, -1f)) + (panel1.Width / 2);
      int yPos = (int)(y * Functions.GetScalarFromRange(panel1.Height, 1f, -1f)) + (panel1.Height / 2);

      _graphics.FillEllipse(new SolidBrush(Color.Red), xPos, yPos, 10, 10);

      _graphics.Save();

      if (ezB_Connect1.EZB.IsConnected) {

        Servo.ServoPortEnum servoXPort = (Servo.ServoPortEnum)cbX.SelectedItem;
        Servo.ServoPortEnum servoYPort = (Servo.ServoPortEnum)cbY.SelectedItem;

        float servoScalar = Functions.GetScalarFromRange(Servo.SERVO_MAX, 1f, -1f);

        ezB_Connect1.EZB.Servo.SetServoPosition(servoXPort, (int)(x * servoScalar) + (Servo.SERVO_MAX / 2));
        ezB_Connect1.EZB.Servo.SetServoPosition(servoYPort, (int)(y * servoScalar) + (Servo.SERVO_MAX / 2));
      }
    }


    private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

      _timer.Dispose();

      _graphics.Dispose();

      if (_wm != null) {

        _wm.Disconnect();
        _wm.Dispose();
      }
    }

    private void btnRefreshREmotes_Click(object sender, EventArgs e) {

      cbWii.Items.Clear();
      foreach (string id in ezB_Connect1.EZB.WiiRemote.GetAllWiiRemoteIDs())
        cbWii.Items.Add(id);
    }
  }
}
