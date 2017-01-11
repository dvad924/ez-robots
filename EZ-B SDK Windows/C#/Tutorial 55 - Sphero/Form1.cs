using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_55___Sphero {

  public partial class Form1 : Form {

    EZB     _ezb;
    Sphero _sphero;

    public Form1() {

      InitializeComponent();

      _ezb = new EZB();

      _sphero = new Sphero(_ezb);
      _sphero.OnConnectionStatusChange += _sphero_OnConnectionStatusChange;
    }

    private void log(object o, params object[] param) {

      textBox1.AppendText(string.Format(o.ToString(), param));
      textBox1.AppendText(Environment.NewLine);
    }

    private void Form1_Load(object sender, EventArgs e) {

      cbPorts.Items.Clear();
      cbPorts.Items.AddRange(EZB.GetAvailableCommunicationPorts(false));
    }

    void _sphero_OnConnectionStatusChange(bool connected) {

      if (connected)
        log("Connection: {0}", connected);

      Invokers.SetEnabled(cbPorts, !connected);

      Invokers.SetText(btnConnect, connected ? "Disconnect" : "Connect");

      Invokers.SetEnabled(gbSpheroCommands, connected);
    }

    private void btnConnect_Click(object sender, EventArgs e) {

      if (_sphero.IsConnected)
        _sphero.Disconnect();
      else
        _sphero.Connect(cbPorts.SelectedItem.ToString());
    }

    private void huePicker1_ValuesChanged(object sender, EventArgs e) {

      AForge.Imaging.RGB rgb = new AForge.Imaging.RGB();

      AForge.Imaging.HSL hsl = new AForge.Imaging.HSL(huePicker1.Value, 0.5f, 0.5f);

      AForge.Imaging.HSL.ToRGB(hsl, rgb);

      log("Sending r:{0} g:{1} b:{2}", rgb.Red, rgb.Green, rgb.Blue);

      _sphero.SetRGBColor(rgb.Red, rgb.Green, rgb.Blue);

      log("Sent");
    }

    private void button1_Click(object sender, EventArgs e) {

      _sphero.Roll(100, 100);
    }

    private void button2_Click(object sender, EventArgs e) {

      _sphero.Roll(200, 100);
    }

    private void button3_Click(object sender, EventArgs e) {

    }
  }
}
