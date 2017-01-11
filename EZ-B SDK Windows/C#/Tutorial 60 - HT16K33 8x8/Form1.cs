using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_60___HT16K33_8x8 {

  public partial class Form1 : Form {

    HT16K33 _ht;

    public Form1() {

      InitializeComponent();

      int btnWidth = panel1.ClientSize.Width / 8;
      int btnHeight = panel1.ClientSize.Height / 8;

      for (int row = 0; row < 8; row++)
        for (int col = 0; col < 8; col++) {

          LEDButton btn = new LEDButton(row, col);
          btn.Click += btn_Click;
          btn.Text = string.Format("{0}:{1}", row, col);
          btn.Width = btnWidth;
          btn.Height = btnHeight;
          btn.Left = row * btnWidth;
          btn.Top = col * btnHeight;
          btn.ForeColor = Color.Red;
          btn.BackColor = Color.Black;

          panel1.Controls.Add(btn);
        }

      _ht = new HT16K33(ucezB_Connect1.EZB);
    }

    void btn_Click(object sender, EventArgs e) {

      LEDButton btn = (LEDButton)sender;

      if (_ht.GetLED(btn.Row, btn.Col)) {

        btn.BackColor = Color.Black;
       
        _ht.SetLED(btn.Row, btn.Col, false);
      } else {

        btn.BackColor = Color.White;
        
        _ht.SetLED(btn.Row, btn.Col, true);
      }

      _ht.UpdateLEDs();
    }

    private void button1_Click(object sender, EventArgs e) {

      _ht.Init();
    }

    private void button2_Click(object sender, EventArgs e) {

      _ht.SetAllStatus(false);

      _ht.UpdateLEDs();

      foreach (Control c in panel1.Controls)
        c.BackColor = Color.Black;
    }
  }
}
