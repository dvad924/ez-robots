using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tutorial_47___Joystick {

  public partial class Form1 : Form {

    EZ_B.Joystick.Joystick _joystick = null;

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      btnRefresh_Click(null, null);
    }

    private void btnRefresh_Click(object sender, EventArgs e) {

      if (_joystick != null) {

        _joystick.Dispose();
        _joystick = null;

        Invokers.SetAppendText(textBox1, true, "Disconnected");
      }

      cbJoysticks.Items.Clear();
      cbJoysticks.Items.AddRange(EZ_B.Joystick.Joystick.GetAvailableDevices());
    }

    private void cbJoysticks_SelectedIndexChanged(object sender, EventArgs e) {

      EZ_B.Joystick.JoystickDevice jd = (EZ_B.Joystick.JoystickDevice)cbJoysticks.SelectedItem;

      _joystick = new EZ_B.Joystick.Joystick(jd, ezB_Connect1.EZB);
      _joystick.OnControllerAction += new EZ_B.Joystick.Joystick.OnJoystickMoveHandler(_joystick_OnControllerAction);
      _joystick.StartEventWatcher();

      Invokers.SetAppendText(textBox1, true, "Connected");
    }

    void _joystick_OnControllerAction() {

      if (_joystick.ButtonPressed(1)) {

        Invokers.SetAppendText(textBox1, true, "You pressed #1");
      }

      if (_joystick.AxisXStateChanged())
        ezB_Connect1.EZB.Servo.SetServoPositionScalar(EZ_B.Servo.ServoPortEnum.D8, EZ_B.Servo.SERVO_MIN, EZ_B.Servo.SERVO_MAX, -1f, 1f, _joystick.GetAxisX, false);

      if (_joystick.AxisYStateChanged())
        ezB_Connect1.EZB.Servo.SetServoPositionScalar(EZ_B.Servo.ServoPortEnum.D9, EZ_B.Servo.SERVO_MIN, EZ_B.Servo.SERVO_MAX, -1f, 1f, _joystick.GetAxisY, false);
    }
  }
}
