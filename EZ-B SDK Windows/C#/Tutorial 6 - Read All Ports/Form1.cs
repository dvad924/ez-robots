using System;
using System.Text;
using System.Windows.Forms;
using EZ_B;

namespace Serial_Test {

  public partial class Form1 : Form {

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

    void Worker_OnLog(DateTime datetime, string logTxt) {

      SetLog(logTxt);
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

      _ezb.Disconnect();

      if (_ezb.IsConnected) {

        SetLog("Can not close port");

        e.Cancel = true;
      }
    }

    private void button2_Click_1(object sender, EventArgs e) {

      StringBuilder sb = new StringBuilder();

      foreach (ADC.ADCPortEnum item in Enum.GetValues(typeof(ADC.ADCPortEnum)))
        sb.AppendFormat("{0}: {1}", item.ToString(), _ezb.ADC.GetADCValue(item)).AppendLine();

      SetLog(sb.ToString());
    }

    private void button8_Click(object sender, EventArgs e) {

      textBox1.Clear();
    }

    private void button10_Click(object sender, EventArgs e) {

      StringBuilder sb = new StringBuilder();

      foreach (Digital.DigitalPortEnum item in Enum.GetValues(typeof(Digital.DigitalPortEnum)))
        sb.AppendFormat("{0}: {1}", item.ToString(), _ezb.Digital.GetDigitalPort(item)).AppendLine();

      SetLog(sb.ToString());
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.EZB = _ezb;

      _ezb.OnLog += new EZB.OnLogHandler(Worker_OnLog);
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

    private void ezB_Connect1_OnConnection() {

    }
  }
}
