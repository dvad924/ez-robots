using System;
using System.Windows.Forms;
using EZ_B;

namespace Serial_Test {

  public partial class Form1 : Form {

    private Random         _random   = new Random();

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

    }

    private void buttonStop_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Movement.GoStop();
    }

    private void buttonForward_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Movement.GoForward();

      System.Threading.Thread.Sleep(250);

      buttonStop_Click(this, new EventArgs());
    }

    private void buttonLeft_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Movement.GoLeft();

      System.Threading.Thread.Sleep(250);

      buttonStop_Click(this, new EventArgs());
    }

    private void buttonRight_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Movement.GoRight();

      System.Threading.Thread.Sleep(250);

      buttonStop_Click(this, new EventArgs());
    }

    private void button8_Click(object sender, EventArgs e) {

      textBox1.Clear();
    }

    void _ezRobot_OnAutoCollision(int EyeValue) {

      buttonStop_Click(this, new EventArgs());

      SetLog(string.Format("Auto Collision Detected. Eye: {0}", EyeValue));
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.EZB.Movement.HBridgeLeftWheelTriggerA = Digital.DigitalPortEnum.D13;
      ezB_Connect1.EZB.Movement.HBridgeRightWheelTriggerA = Digital.DigitalPortEnum.D14;
      ezB_Connect1.EZB.Movement.MovementType = Movement.MovementTypeEnum.HBridge;

      ezB_Connect1.EZB.OnLog += new EZB.OnLogHandler(Worker_OnLog);

      groupBox2.Enabled = false;

      SetLog(Resource1.Intro);
    }

    private void cbVerboseLogging_CheckedChanged(object sender, EventArgs e) {

      ezB_Connect1.EZB.VerboseLogging = cbVerboseLogging.Checked;
    }

    private void buttonAutonomous_Click(object sender, EventArgs e) {

      if (!timer1.Enabled) {

        timer1.Interval = 1000;
        timer1.Start();

        buttonAutonomous.Text = "Stop Autonomous";
      } else {

        timer1.Stop();

        buttonStop_Click(this, new EventArgs());

        buttonAutonomous.Text = "Go Autonomous";
      }
    }

    private void timer1_Tick(object sender, EventArgs e) {

      int adc =  ezB_Connect1.EZB.ADC.GetADCValue(ADC.ADCPortEnum.ADC0);

      if (adc > 30) {

        if (_random.Next(1, 10) > 5)
          buttonRight_Click(this, new EventArgs());
        else
          buttonLeft_Click(this, new EventArgs());
      } else {

        buttonForward_Click(this, new EventArgs());
      }

      System.Threading.Thread.Sleep(_random.Next(100, 300));

      buttonStop_Click(this, new EventArgs());

      timer1.Interval = _random.Next(500, 3000);
    }

    private void textBox2_KeyUp(object sender, KeyEventArgs e) {

      if (e.KeyCode == Keys.Up)
        buttonForward_Click(this, new EventArgs());
      else if (e.KeyCode == Keys.Right)
        buttonRight_Click(this, new EventArgs());
      else if (e.KeyCode == Keys.Left)
        buttonLeft_Click(this, new EventArgs());
      else if (e.KeyCode == Keys.Down)
        buttonStop_Click(this, new EventArgs());
    }
  }
}
