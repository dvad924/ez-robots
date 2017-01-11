using System;
using System.Text;
using System.Windows.Forms;
using EZ_B;

namespace Serial_Test {

  public partial class Form1 : Form {

    private HTTPDServer    _httpdServer;
    private EZB _ezb = new EZB();

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

      timer1.Stop();

      _ezb.Disconnect();

      if (_ezb.IsConnected) {

        SetLog("Can not close port");

        e.Cancel = true;
      }
    }

    private void trackBar3_Scroll(object sender, EventArgs e) {

      _ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D10, trackBar3.Value);
    }

    private void button2_Click_1(object sender, EventArgs e) {

      StringBuilder sb = new StringBuilder();

      foreach (ADC.ADCPortEnum item in Enum.GetValues(typeof(ADC.ADCPortEnum)))
        sb.AppendFormat("{0}: {1}", item.ToString(), _ezb.ADC.GetADCValue(item)).AppendLine();

      SetLog(sb.ToString());
    }

    private void button7_Click(object sender, EventArgs e) {

      _ezb.Movement.GoStop();
    }

    private void button3_Click(object sender, EventArgs e) {

      _ezb.Movement.GoForward();
    }

    private void button4_Click(object sender, EventArgs e) {

      _ezb.Movement.GoLeft();
    }

    private void button5_Click(object sender, EventArgs e) {

      _ezb.Movement.GoRight();
    }

    private void button6_Click(object sender, EventArgs e) {

      _ezb.Movement.GoReverse();
    }

    private void button8_Click(object sender, EventArgs e) {

      textBox1.Clear();
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e) {

      timer1.Interval = 250;
      timer1.Enabled = checkBox3.Checked;
    }

    private void timer1_Tick(object sender, EventArgs e) {

      if (!_ezb.IsConnected)
        checkBox3.Checked = false;

      textBox2.Text = _ezb.ADC.GetADCValue(ADC.ADCPortEnum.ADC0).ToString();
    }

    private void button10_Click(object sender, EventArgs e) {

      StringBuilder sb = new StringBuilder();

      foreach (Digital.DigitalPortEnum item in Enum.GetValues(typeof(Digital.DigitalPortEnum)))
        sb.AppendFormat("{0}: {1}", item.ToString(), _ezb.Digital.GetDigitalPort(item)).AppendLine();

      SetLog(sb.ToString());
    }

    private void trackBar1_Scroll(object sender, EventArgs e) {

      _ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D11, trackBar1.Maximum - trackBar1.Value);
    }

    private void checkBox4_CheckedChanged(object sender, EventArgs e) {

      _ezb.Digital.SetDigitalPort(Digital.DigitalPortEnum.D2, checkBox4.Checked);
      _ezb.Digital.SetDigitalPort(Digital.DigitalPortEnum.D3, checkBox4.Checked);
    }

    private void trackBar2_Scroll(object sender, EventArgs e) {

      _ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D12, trackBar2.Value);
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.EZB = _ezb;

      _ezb.OnLog += new EZB.OnLogHandler(Worker_OnLog);

      _httpdServer = new HTTPDServer(_ezb);

      trackBar1.Maximum = Servo.SERVO_MAX;
      trackBar1.Minimum = Servo.SERVO_MIN;
      trackBar1.Value = Servo.SERVO_CENTER;

      trackBar2.Maximum = Servo.SERVO_MAX;
      trackBar2.Minimum = Servo.SERVO_MIN;
      trackBar2.Value = Servo.SERVO_CENTER;

      trackBar3.Maximum = Servo.SERVO_MAX;
      trackBar3.Minimum = Servo.SERVO_MIN;
      trackBar3.Value = Servo.SERVO_CENTER;

      SetLog(Resource1.Intro);
    }

    void _ezRobot_OnAutoCollision(int EyeValue) {

      _ezb.Movement.GoStop();

      SetLog(string.Format("Auto Collision Detected. Eye: {0}", EyeValue));
    }

    private void cbWebServer_CheckedChanged(object sender, EventArgs e) {

      if (cbWebServer.Checked) {

        _httpdServer.StartServer(80);

        SetLog(string.Format("HTTP Server enabled on port {0}", _httpdServer.tcpPort));

        SetLog(string.Format("URL: http://127.0.0.1:{0}", _httpdServer.tcpPort));

      } else {

        _httpdServer.StopServer();

        SetLog("HTTP Server disabled");
      }
    }

    private void button9_Click(object sender, EventArgs e) {

      StringBuilder sb = new StringBuilder();

      foreach (ADC.ADCPortEnum item in Enum.GetValues(typeof(ADC.ADCPortEnum)))
        sb.AppendFormat("{0}: {1}", item.ToString(), _ezb.ADC.GetADCVoltage(item)).AppendLine();

      SetLog(sb.ToString());
    }

    private void cbVerboseLogging_CheckedChanged(object sender, EventArgs e) {

      _ezb.VerboseLogging = cbVerboseLogging.Checked;
    }

    private void button2_Click(object sender, EventArgs e) {
      _ezb.Servo.ReleaseAllServos();
    }
  }
}
