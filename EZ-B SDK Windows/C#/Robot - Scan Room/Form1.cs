using System;
using System.Drawing;
using System.Windows.Forms;
using EZ_B;

namespace Serial_Test {

  public partial class Form1 : Form {

    private EZB _ezb             = new EZB();
    DateTime               _lastDateTime    = DateTime.Now;
    private readonly int   _pixelsPerSecond = 8;
    private int            _lastX           = 75;
    private int            _lastY           = 75;
    private int            _degrees         = 135;
    private bool           _collision       = false;

    public Form1() {

      InitializeComponent();
    }

    delegate void SetLogCallback(string text, params object[] vals);
    private void SetLog(string text, params object[] vals) {

      if (this.textBox1.InvokeRequired) {

        SetLogCallback d = new SetLogCallback(SetLog);
        this.Invoke(d, new object[] { text, vals });
      } else {

        this.textBox1.AppendText(string.Format(text, vals));
        this.textBox1.AppendText(Environment.NewLine);
      }
    }

    void Worker_OnLog(string logTxt) {

      SetLog(logTxt);
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

      _ezb.Disconnect();

      if (_ezb.IsConnected) {

        SetLog("Can not close port");

        e.Cancel = true;
      }
    }

    private void button8_Click(object sender, EventArgs e) {

      textBox1.Clear();
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.EZB = _ezb;

      _ezb.OnLog += new EZB.OnLogHandler(Worker_OnLog);

      pictureBox1.Image = (Image)new Bitmap(500, 500);
    }

    int xDeg(int deg, int diam) {

      deg = deg - 90;

      return Convert.ToInt32(System.Math.Cos(deg / (180 / System.Math.PI)) * diam);
    }

    int yDeg(int deg, int diam) {

      deg = deg - 90;

      return Convert.ToInt32(System.Math.Sin(deg / (180 / System.Math.PI)) * diam);
    }

    void _ezRobot_OnAutoCollision(int EyeValue) {

      _collision = true;

      int seconds = DateTime.Now.Subtract(_lastDateTime).Seconds;
      int pixels = _pixelsPerSecond * seconds;
      int newX   = _lastX + xDeg(_degrees, pixels);
      int newY   = _lastY + yDeg(_degrees, pixels);
      
      SetLog(string.Empty);
      SetLog("Auto Collision Detected. Eye: {0}", EyeValue);
      SetLog("LastX: {0}, LastY: {1}", _lastX, _lastY);
      SetLog("NewX: {0}, NewY: {1}", newX, newY);
      SetLog("Moved {0} seconds ({1} pixels)", seconds, pixels);

      drawOnPicture(newX, newY, Color.Red, 4);

      _ezb.Movement.GoStop();
      System.Threading.Thread.Sleep(500);
      _ezb.Movement.GoReverse();
      System.Threading.Thread.Sleep(700);
      _ezb.Movement.GoLeft();
      System.Threading.Thread.Sleep(2500);

      _degrees = _degrees + 225;
      if (_degrees > 360)
        _degrees = _degrees - 360;

      SetLog("Heading {0} degrees", _degrees);

      _lastX = newX;
      _lastY = newY;

      _lastDateTime = DateTime.Now;
      _ezb.Movement.GoForward();

      _collision = false;
    }

    private void button2_Click(object sender, EventArgs e) {

      timer1.Interval = 1000;
      timer1.Start();

      drawOnPicture(_lastX, _lastY, Color.Green, 4);

      _lastDateTime = DateTime.Now;
      _ezb.Movement.GoForward();
    }

    private void drawOnPicture(int x, int y, Color color, int size) {

      Graphics graphics = Graphics.FromImage(pictureBox1.Image);
      graphics.DrawRectangle(new Pen(color, 1), x, y, size, size);

      graphics.Save();
      graphics.Dispose();

      try {

        pictureBox1.Refresh();
      } catch {
      }
    }

    private void button3_Click(object sender, EventArgs e) {

      timer1.Stop();

      _ezb.Movement.GoStop();
    }

    private void timer1_Tick(object sender, EventArgs e) {

      if (_collision)
        return;

      int seconds = DateTime.Now.Subtract(_lastDateTime).Seconds;
      int pixels = _pixelsPerSecond * seconds;
      int newX   = _lastX + xDeg(_degrees, pixels);
      int newY   = _lastY + yDeg(_degrees, pixels);

      drawOnPicture(newX, newY, Color.DarkSlateGray, 1);
    }
  }
}

