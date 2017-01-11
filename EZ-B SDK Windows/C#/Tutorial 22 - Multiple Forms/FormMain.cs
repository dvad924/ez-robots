using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_22___Multiple_Forms {

  public partial class FormMain : Form {

    public FormMain() {

      InitializeComponent();
    }

    private void FormMain_Load(object sender, EventArgs e) {

      FormSecondary fs = new FormSecondary(ezB_Connect1.EZB);
      fs.Show();
      fs.Left = this.Left + this.Width;
      fs.Top = this.Top;
    }
  }
}
