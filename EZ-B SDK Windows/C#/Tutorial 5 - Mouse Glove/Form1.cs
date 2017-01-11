using System;
using System.Drawing;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_5___Mouse_Glove {

  public partial class Form1 : Form {

    EZB _ezb = new EZB();

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.EZB = _ezb;

      timer1.Interval = 100;
      timer1.Start();
    }

    private void timer1_Tick(object sender, EventArgs e) {

      if (!_ezb.IsConnected)
        return;

      int x = _ezb.ADC.GetADCValue(ADC.ADCPortEnum.ADC0);
      int y = _ezb.ADC.GetADCValue(ADC.ADCPortEnum.ADC1);

      if (x == 0)
        return;

      int xRel = (Screen.PrimaryScreen.WorkingArea.Width / 130) * x;
      int yRel = (Screen.PrimaryScreen.WorkingArea.Height / 130) * y;

      Cursor.Position = new Point(xRel, yRel);
    }
  }
}
