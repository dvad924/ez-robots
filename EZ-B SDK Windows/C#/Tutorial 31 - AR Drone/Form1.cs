using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_31___AR_Drone {

  public partial class Form1 : Form {

    float moveSensitivivivity = 0.20f;
    int   moveSleepTime       = 400;

    Camera _camera;

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.EZB.ShowDebugWindow();

      _camera = new Camera(ezB_Connect1.EZB);
      _camera.OnNewFrame += _camera_OnNewFrame;

      button2.Enabled = false;

      cbDroneVersion.Items.Clear();
      cbDroneVersion.Items.Add(EZ_B.ARDrone.ARDrone.ARDroneVersionEnum.V1);
      cbDroneVersion.Items.Add(EZ_B.ARDrone.ARDrone.ARDroneVersionEnum.V2);
    }

    void _camera_OnNewFrame() {

      if (cbMovementTracking.Checked) {

        ObjectLocation [] objectLocations = _camera.CameraBasicColorDetection.GetObjectLocationByColor(true, EZ_B.CameraDetection.ColorDetection.ColorEnum.Red, 50, 100);

        if (objectLocations.Length == 0)
          return;

        ObjectLocation objectLocation = objectLocations[0];

        if (objectLocation.HorizontalLocation == ObjectLocation.HorizontalLocationEnum.Left)
          btnLeft_Click(null, null);
        else if (objectLocation.HorizontalLocation == ObjectLocation.HorizontalLocationEnum.Right)
          btnRight_Click(null, null);
      }
    }

    private void button1_Click(object sender, EventArgs e) {

      if (cbDroneVersion.SelectedItem == null) {

        MessageBox.Show("Select the version of your Drone");

        return;
      }

      EZ_B.ARDrone.ARDrone.ARDroneVersionEnum version = (EZ_B.ARDrone.ARDrone.ARDroneVersionEnum)cbDroneVersion.SelectedItem;

      ezB_Connect1.EZB.ARDrone.Connect(version);

      button1.Enabled = false;
      button2.Enabled = true;
    }

    private void button2_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.ARDrone.Disconnect();

      button1.Enabled = true;
      button2.Enabled = false;
    }

    private void button3_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.ARDrone.PlayLedAnimation(EZ_B.ARDrone.Commands.LedAnimationEnum.BlinkRed, 2, 10);
    }

    private void button4_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.ARDrone.TakeOff();
    }

    private void button5_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.ARDrone.Emergency();
    }

    private void button6_Click(object sender, EventArgs e) {

      _camera.StartCamera(
        new ValuePair(Camera.CAMERA_NAME_AR_DRONE, Camera.CAMERA_NAME_AR_DRONE),
        panel1,
        320,
        240);

      ezB_Connect1.EZB.ARDrone.StartVideo();
    }

    private void button7_Click(object sender, EventArgs e) {

      _camera.StopCamera();

      ezB_Connect1.EZB.ARDrone.StopVideo();
    }

    private void button8_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.ARDrone.SetFlatTrim();
    }

    private void button9_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.ARDrone.Hover();
    }

    private void btnForward_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.ARDrone.SetProgressiveInputValues(0, -moveSensitivivivity, 0, 0);

      System.Threading.Thread.Sleep(moveSleepTime);

      ezB_Connect1.EZB.ARDrone.Hover();
    }

    private void btnReverse_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.ARDrone.SetProgressiveInputValues(0, moveSensitivivivity, 0, 0);

      System.Threading.Thread.Sleep(moveSleepTime);

      ezB_Connect1.EZB.ARDrone.Hover();
    }

    private void btnRight_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.ARDrone.SetProgressiveInputValues(0, 0, 0, moveSensitivivivity);

      System.Threading.Thread.Sleep(moveSleepTime);

      ezB_Connect1.EZB.ARDrone.Hover();
    }

    private void btnLeft_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.ARDrone.SetProgressiveInputValues(0, 0, 0, -moveSensitivivivity);

      System.Threading.Thread.Sleep(moveSleepTime);

      ezB_Connect1.EZB.ARDrone.Hover();
    }

    private void btnStop_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.ARDrone.Hover();
    }

    private void button15_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.ARDrone.SetProgressiveInputValues(0, 0, moveSensitivivivity, 0);

      System.Threading.Thread.Sleep(moveSleepTime);

      ezB_Connect1.EZB.ARDrone.Hover();
    }

    private void button16_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.ARDrone.SetProgressiveInputValues(0, 0, -moveSensitivivivity, 0);

      System.Threading.Thread.Sleep(moveSleepTime);

      ezB_Connect1.EZB.ARDrone.Hover();
    }

    private void button18_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.ARDrone.SwitchVideoChannel(EZ_B.ARDrone.Commands.VideoChannelEnum.Next);
    }

    private void button19_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.ARDrone.Land();
    }

    private void button20_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.ARDrone.SendDefaultValues();
    }

    private void button21_Click(object sender, EventArgs e) {

      if (MessageBox.Show("Are you sure? This will rename your Drone's Wifi to the specified name", string.Empty, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
        return;

      ezB_Connect1.EZB.ARDrone.SetWiFiNetworkName(textBox1.Text);

      MessageBox.Show("You have to reboot the device for changes");
    }

    private void button22_Click(object sender, EventArgs e) {

      tbLog.Text = ezB_Connect1.EZB.ARDrone.GetControlConfig();
    }
  }
}
