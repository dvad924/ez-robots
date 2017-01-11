using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tutorial_24___BV4615_RC_5_Infrared_Decoder {

  public partial class Form1 : Form {

    Timer _timer = new Timer();

    public Form1() {

      InitializeComponent();

      _timer.Interval = 250;
      _timer.Tick += new EventHandler(_timer_Tick);
      _timer.Start();
    }

    void _timer_Tick(object sender, EventArgs e) {

      if (!ezB_Connect1.EZB.IsConnected)
        return;

      EZ_B.Classes.BV4615Response r = ezB_Connect1.EZB.BV4615.GetData();

      if (r.IsValid) {

        textBox1.AppendText(string.Format("{0} {1} {2}", r.Value, r.Byte1BinaryStr, r.Byte2BinaryStr));
        textBox1.AppendText(Environment.NewLine);
      }
    }
  }
}
