using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tutorial_42___PWM {

  public partial class Form1 : Form {

    public Form1() {

      InitializeComponent();

      trackBar1.Minimum = EZ_B.PWM.PWM_MIN;
      trackBar1.Maximum = EZ_B.PWM.PWM_MAX;
      trackBar1.SmallChange = 5;
      trackBar1.LargeChange = 10;
      trackBar1.TickFrequency = 10;
      trackBar1.Value = EZ_B.PWM.PWM_MIN;
    }

    private void trackBar1_Scroll(object sender, EventArgs e) {

      label1.Text = string.Format("{0}%", trackBar1.Value);

      ezB_Connect1.EZB.PWM.SetPWM(EZ_B.Digital.DigitalPortEnum.D0, trackBar1.Value);
    }
  }
}
