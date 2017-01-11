using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EZ_B;
using NAudio.Wave;
using EZ_B.Classes;

namespace Tutorial_57___Hand_Audio_Demo {

  public partial class Form1 : Form {

    enum SelectedModesEnum {
      none,
      selecting,
      selected
    }

    List<Rectangle> _rects = new List<Rectangle>();

    readonly decimal _LOW = 0.0m;

    Camera    _camera;
    EZB       _ezb;

    CustomColorConfig _config = new CustomColorConfig();

    AudioFileReader audio1;
    AudioFileReader audio2;
    AudioFileReader audio3;
    AudioFileReader audio4;
    AudioFileReader audio5;
    AudioFileReader audio6;

    LoopStream loop1;
    LoopStream loop2;
    LoopStream loop3;
    LoopStream loop4;
    LoopStream loop5;
    LoopStream loop6;

    IWavePlayer player1;
    IWavePlayer player2;
    IWavePlayer player3;
    IWavePlayer player4;
    IWavePlayer player5;
    IWavePlayer player6;

    Rectangle                 _selectedRect1 = new Rectangle();
    Rectangle                 _selectedRect2 = new Rectangle();
    Rectangle                 _selectedRect3 = new Rectangle();
    Rectangle                 _selectedRect4 = new Rectangle();
    Rectangle                 _selectedRect5 = new Rectangle();
    Rectangle                 _selectedRect6 = new Rectangle();
    SelectedModesEnum         _selectedMode1 = SelectedModesEnum.selected;
    SelectedModesEnum         _selectedMode2 = SelectedModesEnum.selected;
    SelectedModesEnum         _selectedMode3 = SelectedModesEnum.selected;
    SelectedModesEnum         _selectedMode4 = SelectedModesEnum.selected;
    SelectedModesEnum         _selectedMode5 = SelectedModesEnum.selected;
    SelectedModesEnum         _selectedMode6 = SelectedModesEnum.selected;
    List<string>              _audios        = new List<string>();

    decimal _volume1 = 1m;
    decimal _volume2 = 1m;
    decimal _volume3 = 1m;
    decimal _volume4 = 1m;
    decimal _volume5 = 1m;
    decimal _volume6 = 1m;

    public Form1() {

      InitializeComponent();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

    }

    private void Form1_Load(object sender, EventArgs e) {

      _audios.Clear();

      foreach (string file in Directory.GetFiles("Audio", "*.wav"))
        _audios.Add(file);

      if (_audios.Count != 6) {

        log("Audio files not all found: {0}", _audios.Count);

        return;
      }

      for (decimal x = 1m; x > 0; x -= 0.01m)
        comboBox1.Items.Add(x);

      comboBox1.SelectedItem = 0.1m;

      audio1 = new AudioFileReader(_audios[0]);
      loop1 = new LoopStream(audio1);
      player1 = new WaveOut();
      player1.Init(loop1);
      volume1 = 1m;
      player1.Play();

      audio2 = new AudioFileReader(_audios[1]);
      loop2 = new LoopStream(audio2);
      player2 = new WaveOut();
      player2.Init(loop2);
      volume2 = 1m;
      player2.Play();

      audio3 = new AudioFileReader(_audios[2]);
      loop3 = new LoopStream(audio3);
      player3 = new WaveOut();
      player3.Init(loop3);
      volume3 = 1m;
      player3.Play();

      audio4 = new AudioFileReader(_audios[3]);
      loop4 = new LoopStream(audio4);
      player4 = new WaveOut();
      player4.Init(loop4);
      volume4 = 1m;
      player4.Play();

      audio5 = new AudioFileReader(_audios[4]);
      loop5 = new LoopStream(audio5);
      player5 = new WaveOut();
      player5.Init(loop5);
      volume5 = 1m;
      player5.Play();

      audio6 = new AudioFileReader(_audios[5]);
      loop6 = new LoopStream(audio6);
      player6 = new WaveOut();
      player6.Init(loop6);
      volume6 = 1m;
      player6.Play();

      _ezb = new EZB();
      _ezb.OnLog += _ezb_OnLog;

      _camera = new Camera(_ezb);
      _camera.OnNewFrame += _camera_OnNewFrame;

      cbVideoDevices.Items.Clear();
      cbVideoDevices.Items.AddRange(Camera.GetVideoCaptureDevices());

      for (int x = 1; x < 200; x++) {

        cbSensitivity.Items.Add(x);
        cbMotionSize.Items.Add(x);
        cbFrameSkip.Items.Add(x);
      }

      cbSensitivity.SelectedIndex = 30;
      cbMotionSize.SelectedIndex = 20;
      cbFrameSkip.SelectedIndex = 0;

      cbColorDiff.Items.Clear();
      for (byte x = 1; x < 250; x++)
        cbColorDiff.Items.Add(x);
      cbColorDiff.SelectedIndex = 72;

      cbColorSize.Items.Clear();
      for (int x = 1; x < 250; x++)
        cbColorSize.Items.Add(x);
      cbColorSize.SelectedIndex = 30;
    }

    void log(object txt, params object[] vals) {

      Invokers.SetAppendText(tbLog, true, txt.ToString(), vals);
    }

    void _ezb_OnLog(DateTime datetime, string logTxt) {

      Invokers.SetAppendText(tbLog, true, logTxt);
    }

    private void cbVideoDevices_SelectedIndexChanged(object sender, EventArgs e) {

      _camera.StartCamera((ValuePair)cbVideoDevices.SelectedItem, pnlCamera, 640, 480);
    }

    void _camera_OnNewFrame() {

      try {

        ObjectLocation [] objectLocations = new ObjectLocation[] { };

        if (Invokers.GetCheckedValue(rbCustomColorMode)) {

          objectLocations = _camera.CameraCustomColorDetection.GetObjectLocationByColor(true, _config, _rects.ToArray());
        } else if (Invokers.GetCheckedValue(rbMotionMode)) {

          objectLocations = _camera.CameraMotionDetection.GetMotionDetection(
            (int)Invokers.GetComboBoxSelectedItem(cbSensitivity),
            (int)Invokers.GetComboBoxSelectedItem(cbMotionSize),
            (int)Invokers.GetComboBoxSelectedItem(cbFrameSkip),
            _rects.ToArray());
        } else if (Invokers.GetCheckedValue(rbSkinColorMode)) {

          objectLocations = _camera.CameraBasicColorDetection.GetObjectLocationByColor(
              false,
              EZ_B.CameraDetection.ColorDetection.ColorEnum.Red,
              (int)Invokers.GetComboBoxSelectedItem(cbColorSize),
              (byte)Invokers.GetComboBoxSelectedItem(cbColorDiff),
              _rects.ToArray());
        }

        bool isFound1 = false;
        bool isFound2 = false;
        bool isFound3 = false;
        bool isFound4 = false;
        bool isFound5 = false;
        bool isFound6 = false;

        using (Graphics g = pnlCamera.CreateGraphics()) {

          g.DrawRectangle(Pens.White, _selectedRect1);
          g.DrawRectangle(Pens.White, _selectedRect2);
          g.DrawRectangle(Pens.White, _selectedRect3);
          g.DrawRectangle(Pens.White, _selectedRect4);
          g.DrawRectangle(Pens.White, _selectedRect5);
          g.DrawRectangle(Pens.White, _selectedRect6);

          foreach (ObjectLocation objectLocation in objectLocations) {

            Point pointCenter = new Point(
              objectLocation.Rect.X + (objectLocation.Rect.Width / 2),
              objectLocation.Rect.Y + (objectLocation.Rect.Height / 2));

            if (_selectedRect1.Contains(pointCenter)) {

              g.FillRectangle(Brushes.White, pointCenter.X, pointCenter.Y, 10, 10);

              volume1 = 1m;

              Invokers.SetAppendText(tbLog, true, "Note: 0");

              isFound1 = true;
            }

            if (_selectedRect2.Contains(pointCenter)) {

              g.FillRectangle(Brushes.White, pointCenter.X, pointCenter.Y, 10, 10);

              volume2 = 1m;

              Invokers.SetAppendText(tbLog, true, "Note: 1");

              isFound2 = true;
            }

            if (_selectedRect3.Contains(pointCenter)) {

              g.FillRectangle(Brushes.White, pointCenter.X, pointCenter.Y, 10, 10);

              volume3 = 1m;

              Invokers.SetAppendText(tbLog, true, "Note: 2");

              isFound3 = true;
            }

            if (_selectedRect4.Contains(pointCenter)) {

              g.FillRectangle(Brushes.White, pointCenter.X, pointCenter.Y, 10, 10);

              volume4 = 1m;

              Invokers.SetAppendText(tbLog, true, "Note: 3");

              isFound4 = true;
            }

            if (_selectedRect5.Contains(pointCenter)) {

              g.FillRectangle(Brushes.White, pointCenter.X, pointCenter.Y, 10, 10);

              volume5 = 1m;

              Invokers.SetAppendText(tbLog, true, "Note: 4");

              isFound5 = true;
            }

            if (_selectedRect6.Contains(pointCenter)) {

              g.FillRectangle(Brushes.White, pointCenter.X, pointCenter.Y, 10, 10);

              volume6 = 1m;

              Invokers.SetAppendText(tbLog, true, "Note: 5");

              isFound6 = true;
            }
          }
        }

        decimal decrement = 0.1m;

        if (Invokers.GetComboBoxSelectedIndex(comboBox1) > 0)
          decrement = (decimal)Invokers.GetComboBoxSelectedItem(comboBox1);

        if (!isFound1)
          volume1 -= decrement;

        if (!isFound2)
          volume2 -= decrement;

        if (!isFound3)
          volume3 -= decrement;

        if (!isFound4)
          volume4 -= decrement;

        if (!isFound5)
          volume5 -= decrement;

        if (!isFound6)
          volume6 -= decrement;
      } catch (Exception ex) {

        log("New Frame Error: {0}", ex);
      }
    }

    private void pnlCamera_MouseClick(object sender, MouseEventArgs e) {

      if (_selectedMode1 == SelectedModesEnum.none) {

        _selectedRect1.X = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X);
        _selectedRect1.Y = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y);

        _selectedMode1 = SelectedModesEnum.selecting;
      } else if (_selectedMode1 == SelectedModesEnum.selecting) {

        _selectedMode1 = SelectedModesEnum.selected;

        _selectedRect1.Width = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X) - _selectedRect1.X;
        _selectedRect1.Height = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y) - _selectedRect1.Y;

        resetButtons();

        updateRects();
      }

      if (_selectedMode2 == SelectedModesEnum.none) {

        _selectedRect2.X = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X);
        _selectedRect2.Y = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y);

        _selectedMode2 = SelectedModesEnum.selecting;
      } else if (_selectedMode2 == SelectedModesEnum.selecting) {

        _selectedMode2 = SelectedModesEnum.selected;

        _selectedRect2.Width = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X) - _selectedRect2.X;
        _selectedRect2.Height = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y) - _selectedRect2.Y;

        resetButtons();

        updateRects();
      }

      if (_selectedMode3 == SelectedModesEnum.none) {

        _selectedRect3.X = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X);
        _selectedRect3.Y = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y);

        _selectedMode3 = SelectedModesEnum.selecting;
      } else if (_selectedMode3 == SelectedModesEnum.selecting) {

        _selectedMode3 = SelectedModesEnum.selected;

        _selectedRect3.Width = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X) - _selectedRect3.X;
        _selectedRect3.Height = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y) - _selectedRect3.Y;

        resetButtons();

        updateRects();
      }

      if (_selectedMode4 == SelectedModesEnum.none) {

        _selectedRect4.X = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X);
        _selectedRect4.Y = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y);

        _selectedMode4 = SelectedModesEnum.selecting;
      } else if (_selectedMode4 == SelectedModesEnum.selecting) {

        _selectedMode4 = SelectedModesEnum.selected;

        _selectedRect4.Width = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X) - _selectedRect4.X;
        _selectedRect4.Height = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y) - _selectedRect4.Y;

        resetButtons();

        updateRects();
      }

      if (_selectedMode5 == SelectedModesEnum.none) {

        _selectedRect5.X = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X);
        _selectedRect5.Y = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y);

        _selectedMode5 = SelectedModesEnum.selecting;
      } else if (_selectedMode5 == SelectedModesEnum.selecting) {

        _selectedMode5 = SelectedModesEnum.selected;

        _selectedRect5.Width = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X) - _selectedRect5.X;
        _selectedRect5.Height = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y) - _selectedRect5.Y;

        resetButtons();

        updateRects();
      }

      if (_selectedMode6 == SelectedModesEnum.none) {

        _selectedRect6.X = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X);
        _selectedRect6.Y = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y);

        _selectedMode6 = SelectedModesEnum.selecting;
      } else if (_selectedMode6 == SelectedModesEnum.selecting) {

        _selectedMode6 = SelectedModesEnum.selected;

        _selectedRect6.Width = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X) - _selectedRect6.X;
        _selectedRect6.Height = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y) - _selectedRect6.Y;

        resetButtons();

        updateRects();
      }
    }

    private void pnlCamera_MouseMove(object sender, MouseEventArgs e) {

      if (_selectedMode1 == SelectedModesEnum.selecting) {

        _selectedRect1.Width = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X) - _selectedRect1.X;
        _selectedRect1.Height = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y) - _selectedRect1.Y;
      }

      if (_selectedMode2 == SelectedModesEnum.selecting) {

        _selectedRect2.Width = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X) - _selectedRect2.X;
        _selectedRect2.Height = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y) - _selectedRect2.Y;
      }

      if (_selectedMode3 == SelectedModesEnum.selecting) {

        _selectedRect3.Width = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X) - _selectedRect3.X;
        _selectedRect3.Height = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y) - _selectedRect3.Y;
      }

      if (_selectedMode4 == SelectedModesEnum.selecting) {

        _selectedRect4.Width = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X) - _selectedRect4.X;
        _selectedRect4.Height = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y) - _selectedRect4.Y;
      }

      if (_selectedMode5 == SelectedModesEnum.selecting) {

        _selectedRect5.Width = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X) - _selectedRect5.X;
        _selectedRect5.Height = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y) - _selectedRect5.Y;
      }

      if (_selectedMode6 == SelectedModesEnum.selecting) {

        _selectedRect6.Width = (int)(Functions.GetScalarFromRange(_camera.CaptureWidth, pnlCamera.Width, 0) * e.X) - _selectedRect6.X;
        _selectedRect6.Height = (int)(Functions.GetScalarFromRange(_camera.CaptureHeight, pnlCamera.Height, 0) * e.Y) - _selectedRect6.Y;
      }
    }

    private void resetButtons() {

      pnlCamera.Cursor = Cursors.Arrow;

      Invokers.SetBackColor(btnArea1, SystemColors.Control);
      Invokers.SetBackColor(btnArea2, SystemColors.Control);
      Invokers.SetBackColor(btnArea3, SystemColors.Control);
      Invokers.SetBackColor(btnArea4, SystemColors.Control);
      Invokers.SetBackColor(btnArea5, SystemColors.Control);
      Invokers.SetBackColor(btnArea6, SystemColors.Control);
    }

    private void updateRects() {

      _rects.Clear();
      _rects.Add(_selectedRect1);
      _rects.Add(_selectedRect2);
      _rects.Add(_selectedRect3);
      _rects.Add(_selectedRect4);
      _rects.Add(_selectedRect5);
      _rects.Add(_selectedRect6);
    }

    private void button1_Click(object sender, EventArgs e) {

      resetButtons();

      pnlCamera.Cursor = Cursors.Cross;

      Invokers.SetBackColor(btnArea1, Color.Green);

      _selectedRect1 = new Rectangle();
      _selectedMode1 = SelectedModesEnum.none;
    }

    private void button4_Click(object sender, EventArgs e) {

      resetButtons();

      pnlCamera.Cursor = Cursors.Cross;

      Invokers.SetBackColor(btnArea2, Color.Green);

      _selectedRect2 = new Rectangle();
      _selectedMode2 = SelectedModesEnum.none;
    }

    private void button6_Click(object sender, EventArgs e) {

      resetButtons();

      pnlCamera.Cursor = Cursors.Cross;

      Invokers.SetBackColor(btnArea3, Color.Green);

      _selectedRect3 = new Rectangle();
      _selectedMode3 = SelectedModesEnum.none;
    }

    private void button8_Click(object sender, EventArgs e) {

      resetButtons();

      pnlCamera.Cursor = Cursors.Cross;

      Invokers.SetBackColor(btnArea4, Color.Green);

      _selectedRect4 = new Rectangle();
      _selectedMode4 = SelectedModesEnum.none;
    }

    private void button10_Click(object sender, EventArgs e) {

      resetButtons();

      pnlCamera.Cursor = Cursors.Cross;

      Invokers.SetBackColor(btnArea5, Color.Green);

      _selectedRect5 = new Rectangle();
      _selectedMode5 = SelectedModesEnum.none;
    }

    private void button12_Click(object sender, EventArgs e) {

      resetButtons();

      pnlCamera.Cursor = Cursors.Cross;

      Invokers.SetBackColor(btnArea6, Color.Green);

      _selectedRect6 = new Rectangle();
      _selectedMode6 = SelectedModesEnum.none;
    }

    decimal volume1 {
      set {

        _volume1 = Math.Max(value, _LOW);
        audio1.Volume = (float)_volume1;
        Invokers.SetText(label4, _volume1);
      }
      get {
        return _volume1;
      }
    }

    decimal volume2 {
      set {

        _volume2 = Math.Max(value, _LOW);
        audio2.Volume = (float)_volume2;
        Invokers.SetText(label5, _volume2);
      }
      get {
        return _volume2;
      }
    }

    decimal volume3 {
      set {

        _volume3 = Math.Max(value, _LOW);
        audio3.Volume = (float)_volume3;
        Invokers.SetText(label6, _volume3);
      }
      get {
        return _volume3;
      }
    }

    decimal volume4 {
      set {

        _volume4 = Math.Max(value, _LOW);
        audio4.Volume = (float)_volume4;
        Invokers.SetText(label7, _volume4);
      }
      get {
        return _volume4;
      }
    }

    decimal volume5 {
      set {

        _volume5 = Math.Max(value, _LOW);
        audio5.Volume = (float)_volume5;
        Invokers.SetText(label8, _volume5);
      }
      get {
        return _volume5;
      }
    }

    decimal volume6 {
      set {

        _volume6 = Math.Max(value, _LOW);
        audio6.Volume = (float)_volume6;
        Invokers.SetText(label9, _volume6);
      }
      get {
        return _volume6;
      }
    }

    private void button2_Click(object sender, EventArgs e) {

      _camera.OnNewFrame -= _camera_OnNewFrame;

      using (FormCameraCustomColor fc = new FormCameraCustomColor(_camera)) {

        fc.Configuration = _config;

        if (fc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
          _config = fc.Configuration;

        _camera.SetPreviewControl = pnlCamera;
      }

      _camera.OnNewFrame += _camera_OnNewFrame;
    }

    private void rbSkinColorMode_CheckedChanged(object sender, EventArgs e) {

      gbSkinColorMode.Enabled = rbSkinColorMode.Checked;
      gbCustomColorMode.Enabled = rbCustomColorMode.Checked;
      gbMotionMode.Enabled = rbMotionMode.Checked;
    }

    private void rbCustomColorMode_CheckedChanged(object sender, EventArgs e) {

      gbSkinColorMode.Enabled = rbSkinColorMode.Checked;
      gbCustomColorMode.Enabled = rbCustomColorMode.Checked;
      gbMotionMode.Enabled = rbMotionMode.Checked;
    }

    private void rbMotionMode_CheckedChanged(object sender, EventArgs e) {

      gbSkinColorMode.Enabled = rbSkinColorMode.Checked;
      gbCustomColorMode.Enabled = rbCustomColorMode.Checked;
      gbMotionMode.Enabled = rbMotionMode.Checked;
    }

    private void btnCopyLog_Click(object sender, EventArgs e) {

      tbLog.SelectAll();
      tbLog.Copy();
      tbLog.SelectionLength = 0;
    }

    private void button1_Click_1(object sender, EventArgs e) {

      tbLog.Clear();
    }
  }
}
