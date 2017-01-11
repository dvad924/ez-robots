using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tutorial_41___Set_Digital {
  public partial class Form1 : Form {

    public Form1() {

      InitializeComponent();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e) {

      ezB_Connect1.EZB.Digital.SetDigitalPort(EZ_B.Digital.DigitalPortEnum.D0, checkBox1.Checked);
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e) {

      ezB_Connect1.EZB.Digital.SetDigitalPort(EZ_B.Digital.DigitalPortEnum.D1, checkBox2.Checked);
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e) {

      ezB_Connect1.EZB.Digital.SetDigitalPort(EZ_B.Digital.DigitalPortEnum.D2, checkBox3.Checked);
    }
  }
}
