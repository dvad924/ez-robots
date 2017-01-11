using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tutorial_23___i2c_Dual_Axis_Magnetic_Compass {

  public partial class Form1 : Form {

    Timer _timer = new Timer();

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      _timer.Interval = 250;
      _timer.Tick += new EventHandler(_timer_Tick);
      _timer.Start();
    }

    void _timer_Tick(object sender, EventArgs e) {

      if (!ezB_Connect1.EZB.IsConnected)
        return;

      ezB_Connect1.EZB.SureDualAxisCompass.Update();

      label3.Text = ezB_Connect1.EZB.SureDualAxisCompass.CompassData.X.ToString();
      label4.Text = ezB_Connect1.EZB.SureDualAxisCompass.CompassData.Y.ToString();
      label6.Text = string.Format("{0:0}", ezB_Connect1.EZB.SureDualAxisCompass.CompassData.Degrees);
    }
  }
}
