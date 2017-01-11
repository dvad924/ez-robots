using System;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_58___v4_Camera_Settings {

  public partial class Form1 : Form {

    EZB       _ezb;
    Camera   _camera;
    int      _frameCnt = 0;
    System.Timers.Timer _timer = new System.Timers.Timer();

    int _frames = 0;
    decimal _frameCntTotal = 0;

    public Form1() {

      InitializeComponent();

      for (int x = 0; x < 8; x++) {

        int b = 7 - x;

        CheckBox cb = new CheckBox();
        cb.Name = b.ToString();
        cb.Text = string.Format("Bit {0}", b);
        cb.CheckStateChanged += cb_CheckStateChanged;
        cb.Top = x * cb.Height;

        panel1.Controls.Add(cb);
      }

      _ezb = new EZB();
      _ezb.OnLog += _ezb_OnLog;

      _camera = new Camera(_ezb);
      _camera.OnNewFrame += _camera_OnNewFrame;
      _camera.OnStart += _camera_OnStart;
      _camera.OnStop += _camera_OnStop;

      _timer.Elapsed += _timer_Elapsed;
      _timer.Interval = 2000;
      _timer.Start();

      cbVideoDevices.Items.Clear();
      cbVideoDevices.Items.AddRange(Camera.GetVideoCaptureDevices());
    }

    void cb_CheckStateChanged(object sender, EventArgs e) {

      int result = 0;

      foreach (CheckBox cb in panel1.Controls) {

        int b = Convert.ToInt16(cb.Name);

        if (cb.Checked)
          result += (1 << b);
      }

      tbRegisterValue.Text = string.Format("0x{0:X2}", result);
    }

    void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {

      if (_camera.IsActive)
        Invokers.SetAppendText(textBox1, true, "Size: {0:###,###}", _camera.GetEZBv4CameraImageSize);
    }

    void _ezb_OnLog(DateTime datetime, string logTxt) {

      Invokers.SetAppendText(textBox1, true, logTxt);
    }

    void _camera_OnStop() {

      Invokers.SetText(button7, "Start");
    }

    void _camera_OnStart() {

      Invokers.SetText(button7, "Stop");

      _sw.Start();
    }


    System.Diagnostics.Stopwatch _sw = new System.Diagnostics.Stopwatch();

    void _camera_OnNewFrame() {

      _frameCnt++;

      if (_sw.ElapsedMilliseconds > 1000) {

        decimal fps = (decimal)_frameCnt / (decimal)((decimal)_sw.ElapsedMilliseconds / 1000m);

        _frames++;

        _frameCntTotal += fps;

        Invokers.SetText(label1, "{0:#.0} fps (Avg: {1:#.0})",
          fps,
          _frameCntTotal / (decimal)_frames);

        _frameCnt = 0;

        _sw.Restart();
      }
    }

    private void button7_Click(object sender, EventArgs e) {

      if (_camera.IsActive) {

        _camera.StopCamera();
      } else {

        ValuePair vp = (ValuePair)cbVideoDevices.SelectedItem;

        _camera.StartCamera(vp, pnlImage, 640, 480);
      }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

      _camera.Dispose();

      _ezb.Dispose();
    }

    private void button1_Click(object sender, EventArgs e) {

      _camera.SetEZBv4CameraSettings(EZBv4Video.CameraSettingsEnum.Res160x120);
    }

    private void button2_Click(object sender, EventArgs e) {

      _camera.SetEZBv4CameraSettings(EZBv4Video.CameraSettingsEnum.Res320x240);
    }

    private void button3_Click(object sender, EventArgs e) {

      _camera.SetEZBv4CameraSettings(EZBv4Video.CameraSettingsEnum.Res640x480);
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e) {

      if (checkBox1.Checked)
        _camera.SetEZBv4CameraSettings(EZBv4Video.CameraSettingsEnum.BacklightOn);
      else
        _camera.SetEZBv4CameraSettings(EZBv4Video.CameraSettingsEnum.BacklightOff);
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e) {

      if (checkBox2.Checked)
        _camera.SetEZBv4CameraSettings(EZBv4Video.CameraSettingsEnum.IndoorForce);
      else
        _camera.SetEZBv4CameraSettings(EZBv4Video.CameraSettingsEnum.IndoorAuto);
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e) {

      if (checkBox8.Checked)
        _camera.SetEZBv4CameraSettings(EZBv4Video.CameraSettingsEnum.FreqAuto);
      else if (checkBox3.Checked)
        _camera.SetEZBv4CameraSettings(EZBv4Video.CameraSettingsEnum.Freq50hz);
      else if (!checkBox3.Checked)
        _camera.SetEZBv4CameraSettings(EZBv4Video.CameraSettingsEnum.Freq60hz);
    }

    private void checkBox4_CheckedChanged(object sender, EventArgs e) {

      if (checkBox4.Checked)
        _camera.SetEZBv4CameraSettings(EZBv4Video.CameraSettingsEnum.MirrorEnable);
      else
        _camera.SetEZBv4CameraSettings(EZBv4Video.CameraSettingsEnum.MirrorDisable);
    }

    private void trackBar1_Scroll(object sender, EventArgs e) {

      _camera.SetEZBv4CameraCompression((byte)trackBar1.Value);

      label2.Text = trackBar1.Value.ToString();
    }

    private void tbBrightness_Scroll(object sender, EventArgs e) {

      _camera.SetEZBv4CameraBrightness((byte)tbBrightness.Value);

      label3.Text = tbBrightness.Value.ToString();
    }

    private void checkBox5_CheckedChanged(object sender, EventArgs e) {

      _camera.SetEZBv4CameraLED(checkBox1.Checked, checkBox2.Checked, checkBox3.Checked);
    }

    private void tbExposure_Scroll(object sender, EventArgs e) {

      _camera.SetEZBv4CameraExposureMode((EZBv4Video.CameraExposureMode)tbExposure.Value);
    }

    private void button4_Click(object sender, EventArgs e) {

      _camera.SetEZBv4CameraSetRegisterValue(0xff, 0x00);
      _camera.SetEZBv4CameraSetRegisterValue(0x7c, 0x00);
      _camera.SetEZBv4CameraSetRegisterValue(0x7d, 0x04);
      _camera.SetEZBv4CameraSetRegisterValue(0x7c, 0x09);
      _camera.SetEZBv4CameraSetRegisterValue(0x7d, 200);      // 200   
      _camera.SetEZBv4CameraSetRegisterValue(0x7d, 0x00);
    }

    private byte getAddress(string text) {

      try {

        string l = text.ToLower().Trim();

        l = l.Replace("0x", "");

        return Byte.Parse(l, System.Globalization.NumberStyles.HexNumber);
      } catch {

        MessageBox.Show("Invalid address format. Should be formatted like 0x0A");

        return 0x0A;
      }
    }

    private void btnSetRegister_Click(object sender, EventArgs e) {

      if (!cbBank.Checked)
        _camera.SetEZBv4CameraSetRegisterValue(0xff, 0x00);
      else
        _camera.SetEZBv4CameraSetRegisterValue(0xff, 0x01);

      _camera.SetEZBv4CameraSetRegisterValue(getAddress(tbRegister.Text), getAddress(tbRegisterValue.Text));
    }

    private void btnBlackandWhite_Click(object sender, EventArgs e) {

      _camera.SetEZBv4CameraSetRegisterValue(0xff, 0x00);

      _camera.SetEZBv4CameraSetRegisterValue(0x7c, 0x00);

      _camera.SetEZBv4CameraSetRegisterValue(0x7d, 0x04);

      _camera.SetEZBv4CameraSetRegisterValue(0x7c, 0x07);

      _camera.SetEZBv4CameraSetRegisterValue(0x7d, 0x20);

      _camera.SetEZBv4CameraSetRegisterValue(0x7d, 0xff);  // 1

      _camera.SetEZBv4CameraSetRegisterValue(0x7d, 0x00);  // 2

      _camera.SetEZBv4CameraSetRegisterValue(0x7d, 0x06);
    }

    private void tbVal1_Scroll(object sender, EventArgs e) {

      _camera.SetEZBv4CameraSetRegisterValue(0xff, 0x00);

      _camera.SetEZBv4CameraSetRegisterValue(0x7c, 0x00);

      _camera.SetEZBv4CameraSetRegisterValue(0x7d, 0x04);

      _camera.SetEZBv4CameraSetRegisterValue(0x7c, 0x07);

      _camera.SetEZBv4CameraSetRegisterValue(0x7d, 0x20);

      _camera.SetEZBv4CameraSetRegisterValue(0x7d, (byte)tbVal1.Value);  // 1

      _camera.SetEZBv4CameraSetRegisterValue(0x7d, (byte)tbVal2.Value);  // 2

      _camera.SetEZBv4CameraSetRegisterValue(0x7d, 0x06);
    }

    private void button5_Click(object sender, EventArgs e) {

    }

    private void button8_Click(object sender, EventArgs e) {

      _frames = 0;
      _frameCntTotal = 0;
    }
  }
}
