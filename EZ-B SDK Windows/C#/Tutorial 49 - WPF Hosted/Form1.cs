using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tutorial_49___WPF_Hosted {

  public partial class Form1 : Form {
  
    public Form1() {

      InitializeComponent();
    }

    private void trackBar1_Scroll(object sender, EventArgs e) {

      userControl11.DOIT(trackBar1.Value-50);
    }
  }
}
