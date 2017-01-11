using System;
using System.Diagnostics;
using System.Windows.Forms;
using EZ_B;
using EZ_B.CameraDetection;
using System.Drawing;

namespace Tutorial_11___Follow_Red_Object {

  public partial class Form1 : Form {

    Stopwatch _stopWatch = new Stopwatch();
    Camera    _camera;

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      _camera = new Camera(ezB_Connect1.EZB);
      _camera.OnNewFrame += new Camera.OnNewFrameHandler(_camera_OnNewFrame);

      comboBox1.Items.Clear();
      comboBox1.Items.AddRange(Camera.GetVideoCaptureDevices());

      scLumMax.Value = 1f;
      scSatMax.Value = 1f;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

      ValuePair videoCaptureDeviceName = (ValuePair) comboBox1.SelectedItem;

      _camera.StartCamera(videoCaptureDeviceName, panel1, panel2, 320, 240);

      Log("Video started: {0}", videoCaptureDeviceName.Text);
    }

    private void Log(object txt, params object[] values) {

      Invokers.SetAppendText(tbLog, true, txt.ToString(), values);
    }

    void _camera_OnNewFrame() {

      try {

        //_stopWatch.Restart();

        ObjectLocation [] objectLocations = _camera.CameraCustomColorDetection.GetObjectLocationByColor(
          Invokers.GetCheckedValue(cbPreviewDetect),
          Invokers.GetTrackBarValue(tbMinObjectSize),
          huePicker1.Min,
          huePicker1.Max,
          scSatMin.Value,
          scSatMax.Value,
          scLumMin.Value,
          scLumMax.Value);

        //ObjectLocation objectLocation = _camera.CameraBasicColorDetection.GetObjectLocationByColor(
        //  Invokers.GetCheckedValue(cbPreviewDetect),
        //  ColorDetection.ColorEnum.Red,
        //   Invokers.GetTrackBarValue(tbMinObjectSize),
        //  (byte)Invokers.GetTrackBarValue(trackBar1));

        //ObjectLocation objectLocation = _camera.CameraFaceDetection.GetFaceDetection();
        //ObjectLocation objectLocation = _camera.CameraMotionDetection.GetMotionDetection(30, 80);
        //ObjectLocation objectLocation = _camera.CameraShapeDetection.GetShapeDetection();

        //_stopWatch.Stop();

        //Log("Detection Took: {0} ticks ({1}ms)", _stopWatch.ElapsedTicks, _stopWatch.ElapsedMilliseconds);

        if (objectLocations.Length != 0) {

          ObjectLocation objectLocation = objectLocations[0];

          Log("Object found at {0} {1}", objectLocation.HorizontalLocation, objectLocation.VerticalLocation);

          if (ezB_Connect1.EZB.IsConnected) {

            int position = ezB_Connect1.EZB.Servo.GetServoPosition(Servo.ServoPortEnum.D12);

            if (objectLocation.HorizontalLocation == ObjectLocation.HorizontalLocationEnum.Left)
              position++;
            else if (objectLocation.HorizontalLocation == ObjectLocation.HorizontalLocationEnum.Right)
              position--;

            ezB_Connect1.EZB.Servo.SetServoPosition(Servo.ServoPortEnum.D12, position);
          }
        }
      } catch (Exception ex) {

        Log(ex);
      }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

      _camera.StopCamera();
    }
  }
}
