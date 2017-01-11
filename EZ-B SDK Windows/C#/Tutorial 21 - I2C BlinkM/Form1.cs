using System;
using System.Windows.Forms;

namespace Tutorial_21___I2C_BlinkM {
  
  public partial class Form1 : Form {

    public Form1() {

      InitializeComponent();
    }

    private void BlinkM(byte red, byte green, byte blue) {      

      ezB_Connect1.EZB.BlinkM.ChangeToColor(0x09, red, green, blue);
    }

    private void trackBar1_Scroll(object sender, EventArgs e) {

      if (checkBox1.Checked) {

        trackBar2.Value = trackBar1.Value;
        trackBar3.Value = trackBar1.Value;
      }

      BlinkM((byte)trackBar1.Value, (byte)trackBar2.Value, (byte)trackBar3.Value);
    }

    private void trackBar2_Scroll(object sender, EventArgs e) {

      if (checkBox1.Checked) {

        trackBar1.Value = trackBar2.Value;
        trackBar3.Value = trackBar2.Value;
      }

      BlinkM((byte)trackBar1.Value, (byte)trackBar2.Value, (byte)trackBar3.Value);
    }

    private void trackBar3_Scroll(object sender, EventArgs e) {

      if (checkBox1.Checked) {

        trackBar1.Value = trackBar3.Value;
        trackBar2.Value = trackBar3.Value;
      }

      BlinkM((byte)trackBar1.Value, (byte)trackBar2.Value, (byte)trackBar3.Value);
    }
  }
}
