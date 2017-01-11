using System;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_7___TellyMate_ADC {

  public partial class Form1 : Form {

    EZB _ezb    = new EZB();
    int            _oldCol = 10;

    public Form1() {

      InitializeComponent();
    }

    private void timer1_Tick(object sender, EventArgs e) {

      if (!_ezb.IsConnected)
        return;

      int adcVal = _ezb.ADC.GetADCValue(ADC.ADCPortEnum.ADC0);
      float adcVoltage = _ezb.ADC.GetADCVoltageFromValue(adcVal);

      _ezb.TellyMate.MoveCursor(9, 0);
      _ezb.TellyMate.SendText(adcVal.ToString());
      _ezb.TellyMate.MoveCursor(9, 1);
      _ezb.TellyMate.SendText(string.Format("{0:0.00}", adcVoltage));

      _ezb.TellyMate.MoveCursor(_oldCol, 2);
      _ezb.TellyMate.SendText(" ");

      int newCol = 10 + (adcVal / 5);

      _ezb.TellyMate.MoveCursor(newCol, 2);

      _oldCol = newCol;

      _ezb.TellyMate.SendText("*");
    }

    private void ezB_Connect1_OnConnection() {

      timer1.Interval = 250;
      timer1.Start();

      _ezb.TellyMate.SendCommand(TellyMate.CmdEnum.Clear_Screen);
      _ezb.TellyMate.MoveCursor(0, 0);
      _ezb.TellyMate.SendText("Value:");
      _ezb.TellyMate.MoveCursor(0, 1);
      _ezb.TellyMate.SendText("Voltage:");
      _ezb.TellyMate.MoveCursor(0, 2);
      _ezb.TellyMate.SendText("Position:");
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.EZB = _ezb;
    }
  }
}
