using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_38___ez430_Chronos {

  public partial class Form1 : Form {

    readonly string _TXT_START = "Start Listening";
    readonly string _TXT_STOP  = "Stop Listening";

    Timer _timer = new Timer();
    EZ430 _ez430;

    public Form1() {

      InitializeComponent();

      button1.Text = _TXT_START;

      comboBox1.Items.Clear();
      comboBox1.Items.AddRange(EZB.GetAvailableCommunicationPorts(false));

      _ez430 = new EZ430(ezB_Connect1.EZB);

      ezB_Connect1.EZB.ShowDebugWindow();

      _timer.Interval = 250;
      _timer.Tick += new EventHandler(_timer_Tick);
    }

    void _timer_Tick(object sender, EventArgs e) {

      EZ_B.Classes.EZ430Data data = _ez430.GetAccData();

      SetLog(string.Format("x: {0}, y: {1}, z: {2}", data.X, data.Y, data.Z), true);
    }

    private void button1_Click(object sender, EventArgs e) {

      if (button1.Text == _TXT_START)
        connect();
      else
        disconnect();
    }


    private void connect() {

      try {

        tbLog.Clear();

        _ez430.PortName = comboBox1.SelectedItem.ToString();
        _ez430.Start();

        button1.Text = _TXT_STOP;

        SetLog("Started", true);

        SetLog(string.Format("Watch Address: {0}", _ez430.Address), true);

        _timer.Start();
      } catch (Exception ex) {

        SetLog(string.Format("Error: {0}", ex), true);
      }
    }

    private void disconnect() {

      try {

        _timer.Stop();

        _ez430.Stop();

        button1.Text = _TXT_START;

        SetLog("Stopped", true);
      } catch (Exception ex) {

        SetLog(string.Format("Error: {0}", ex), true);
      }
    }

    delegate void SetLogCallback(string text, bool newLine);
    private void SetLog(string text, bool newLine) {

      if (this.tbLog.InvokeRequired) {

        SetLogCallback d = new SetLogCallback(SetLog);
        this.Invoke(d, new object[] { text, newLine });
      } else {

        this.tbLog.AppendText(text);

        if (newLine)
          this.tbLog.AppendText(Environment.NewLine);
      }
    }
  }
}
