using System;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_18___Follow_Motion {

  public partial class Form1 : Form {

    Camera _camera;

    public Form1() {

      InitializeComponent();

      _camera = new Camera(ezB_Connect1.EZB);
      _camera.OnNewFrame += new Camera.OnNewFrameHandler(_camera_OnNewFrame);

      comboBox1.Items.Clear();
      comboBox1.Items.AddRange(Camera.GetVideoCaptureDevices());
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

      _camera.StartCamera((ValuePair)comboBox1.SelectedItem, panel1, 160, 120);
    }

    void _camera_OnNewFrame() {

      if (!_camera.IsActive)
        return;

      ObjectLocation [] objectLocations = _camera.CameraMotionDetection.GetMotionDetection(30, 70, 0);

      if (objectLocations.Length == 0)
        return;

      ObjectLocation objectLocation = objectLocations[0];

      if (ezB_Connect1.EZB.IsConnected) {

        int position = ezB_Connect1.EZB.Servo.GetServoPosition(Servo.ServoPortEnum.D12);

        if (objectLocation.HorizontalLocation == ObjectLocation.HorizontalLocationEnum.Left)
          position++;
        else if (objectLocation.HorizontalLocation == ObjectLocation.HorizontalLocationEnum.Right)
          position--;

        ezB_Connect1.EZB.Servo.SetServoPosition(Servo.ServoPortEnum.D12, position);
      }

      string logMsg = string.Format("Object found at {0} {1}", objectLocation.HorizontalLocation, objectLocation.VerticalLocation);

      SetAppendText(tbLog, true, logMsg);
    }


    delegate void SetAppendTextCallback1(TextBox control, bool newLine, string text, params object[] param);
    public static void SetAppendText(TextBox control, bool newLine, string text, params object[] param) {

      try {

        if (control.InvokeRequired) {

          SetAppendTextCallback1 d = new SetAppendTextCallback1(SetAppendText);
          control.Invoke(d, new object[] { control, newLine, text, param });
        } else {

          control.AppendText(string.Format(text, param));

          if (newLine)
            control.AppendText(Environment.NewLine);
        }
      } catch {
      }
    }

    delegate void SetAppendTextCallback2(TextBox control, bool newLine, int maxLineCount, string text, params object[] param);
    public static void SetAppendText(TextBox control, bool newLine, int maxLineCount, string text, params object[] param) {

      if (control.InvokeRequired) {

        SetAppendTextCallback2 d = new SetAppendTextCallback2(SetAppendText);
        control.Invoke(d, new object[] { control, newLine, maxLineCount, text, param });
      } else {

        if (!control.IsDisposed && control.Lines.Length > maxLineCount)
          control.Clear();

        if (!control.IsDisposed)
          control.AppendText(string.Format(text, param));

        if (!control.IsDisposed && newLine)
          control.AppendText(Environment.NewLine);
      }
    }

  }
}
