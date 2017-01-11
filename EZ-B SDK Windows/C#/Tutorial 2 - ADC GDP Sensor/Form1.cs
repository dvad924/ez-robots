using System;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_2___ADC_GDP_Sensor {

  public partial class Form1 : Form {

    EZB _ezb = new EZB();

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.EZB = _ezb;

      timer1.Interval = 500;
      timer1.Start();
    }

    private void timer1_Tick(object sender, EventArgs e) {

      if (!_ezb.IsConnected)
        return;

      int adcValue = _ezb.ADC.GetADCValue(ADC.ADCPortEnum.ADC0);

      label1.Text = string.Format("Value: {0}", adcValue);
    }
  }
}
