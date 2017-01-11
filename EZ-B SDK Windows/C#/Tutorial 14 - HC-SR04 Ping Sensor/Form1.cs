using System;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_14___HC_SR04_Ping_Sensor {

  public partial class Form1 : Form {

    public Form1() {

      InitializeComponent();

      timer1.Interval = 250;
      timer1.Enabled = true;

      comboBox1.Items.Clear();
      comboBox2.Items.Clear();
      foreach (Digital.DigitalPortEnum item in Enum.GetValues(typeof(Digital.DigitalPortEnum))) {

        comboBox1.Items.Add(item);
        comboBox2.Items.Add(item);
      }

      comboBox1.SelectedItem = Digital.DigitalPortEnum.D0;
      comboBox2.SelectedItem = Digital.DigitalPortEnum.D1;
    }

    private void timer1_Tick(object sender, EventArgs e) {

      if (!uC_EZ_Connect1.EZB.IsConnected)
        return;

      Digital.DigitalPortEnum triggerPort = (Digital.DigitalPortEnum)comboBox1.SelectedItem;
      Digital.DigitalPortEnum echoPort = (Digital.DigitalPortEnum)comboBox2.SelectedItem;

      int val = uC_EZ_Connect1.EZB.HC_SR04.GetValue(triggerPort, echoPort);

      progressBar1.Value = val;
      label3.Text = val.ToString() + "\"";
    }
  }
}
