using System;
using System.Drawing;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_9___Radar_Scanner {

  public partial class Form1 : Form {

    EZB _ezb      = new EZB();
    Graphics       _graphics;
    bool           _dir      = true;
    int         [] _values   = new int[Servo.SERVO_MAX];

    public Form1() {

      InitializeComponent();

      timer1.Interval = 250;
      timer1.Start();

      numericUpDown1.Maximum = Servo.SERVO_MAX;
      numericUpDown1.Minimum = Servo.SERVO_MIN;

      numericUpDown2.Maximum = Servo.SERVO_MAX;
      numericUpDown2.Minimum = Servo.SERVO_MIN;

      pictureBox1.Image = (Image)new Bitmap(pictureBox1.Width, pictureBox1.Height);
      _graphics = Graphics.FromImage(pictureBox1.Image);
      _graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      drawRadarImage(3);
    }

    private void timer1_Tick(object sender, EventArgs e) {

      if (!_ezb.IsConnected)
        return;

      int position = _ezb.Servo.GetServoPosition(Servo.ServoPortEnum.D12);

      if (position == 0)
        position = (int)numericUpDown1.Value;

      if (position <= numericUpDown1.Value)
        _dir = true;

      if (position >= numericUpDown2.Value)
        _dir = false;

      if (_dir)
        position++;
      else
        position--;

      _ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D12, position);

      int val = _ezb.ADC.GetADCValue(ADC.ADCPortEnum.ADC0);

      position = Servo.SERVO_MAX - position;

      _values[position] = val;

      drawRadarImage(position);
    }

    private void drawRadarImage(int position) {

      int centerX = pictureBox1.Width / 2;

      _graphics.FillRectangle(new SolidBrush(Color.Black), 0, 0, pictureBox1.Width, pictureBox1.Height);

      Point [] backPoints = { new Point(10, 0),
                              new Point(pictureBox1.Width - 15, 0),
                              new Point(centerX, pictureBox1.Height  + 100),
                              new Point(10, 0)};

      _graphics.FillPolygon(
        new SolidBrush(Color.FromArgb(10, 50, 10)),
        backPoints);

      for (int x=1; x < Servo.SERVO_MAX; x++) {

        Pen pen;

        if (x == position)
          pen = new Pen(Color.FromArgb(50, 255, 50), 1);
        else
          pen = new Pen(Color.FromArgb(50, 100, 50), 1);

        _graphics.DrawLine(
          pen,
          centerX,
          pictureBox1.Height + 100,
          x * (pictureBox1.Width / Servo.SERVO_MAX),
          0);

        if (_values[x] > 50)
          _graphics.FillEllipse(
            new SolidBrush(Color.FromArgb(100, Color.Red)),
            x * (pictureBox1.Width / Servo.SERVO_MAX),
            pictureBox1.Height - (180 - _values[x]),
            10, 10);
      }

      // draw center ball at bottm of screen
      for (int x=0; x < 50; x++)
        _graphics.DrawEllipse(
          new Pen(Color.FromArgb(100, 0, 255 - (x * 5), 0), 2),
          (centerX - 50) + x,
          (pictureBox1.Height - 50) + x,
          100 - x,
          100 - x);

      pictureBox1.Refresh();

      label3.Text = string.Format("Head Position: {0}  Value: {1}", position, _values[position]);
    }

    private void button2_Click(object sender, EventArgs e) {

      _ezb.ShowDebugWindow();
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.EZB = _ezb;
    }
  }
}
