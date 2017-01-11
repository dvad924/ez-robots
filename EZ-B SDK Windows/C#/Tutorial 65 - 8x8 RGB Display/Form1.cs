using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_65___8x8_RGB_Display {

  public partial class Form1 : Form {

    Timer _timer;

    EZ_B.RGB8x8 _rgb;

    Button _selectedButton = null;

    public Form1() {

      InitializeComponent();

      ucezB_Connect1.Port = "192.168.0.171:23";

      //ucezB_Connect1.EZB.ShowDebugWindow();
      //ucezB_Connect1.EZB.VerboseLogging = true;

      _rgb = new EZ_B.RGB8x8(ucezB_Connect1.EZB);

      int index = 0;
      for (int y = 0; y < 8; y++)
        for (int x = 0; x < 8; x++) {

          int width  = pnlButtons.Width / 8;
          int height = pnlButtons.Height / 8;
          int left   = x * width;
          int top    = y * height;

          Button b = new Button();
          b.Text = string.Empty;
          b.Name = index.ToString();
          b.Width = width;
          b.Height = height;
          b.Left = left;
          b.Top = top;
          b.Click += b_Click;
          b.Show();

          pnlButtons.Controls.Add(b);

          index++;
        }
    }

    void b_Click(object sender, EventArgs e) {

      _selectedButton = (Button)sender;

      for (int cnt=0; cnt < pnlButtons.Controls.Count; cnt++) {

        Button b = (Button)pnlButtons.Controls[cnt];

        if (b.Name == _selectedButton.Name)
          b.Text = "[]";
        else
          b.Text = string.Empty;
      }

      checkBox1_CheckedChanged(null, null);
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e) {

      if (_selectedButton == null)
        return;

      int pos = Convert.ToInt32(_selectedButton.Name);

      _rgb.SetColor(pos, cbRed.Checked, cbGreen.Checked, cbBlue.Checked);
    }

    private void button2_Click(object sender, EventArgs e) {

      _rgb.SetAllColor(true, false, false);
    }

    private void button1_Click(object sender, EventArgs e) {

      _rgb.SetAllColor(false, true, false);
    }

    private void button4_Click(object sender, EventArgs e) {

      _rgb.SetAllColor(false, false, true);
    }

    private void button3_Click(object sender, EventArgs e) {

      _rgb.SetAllColor(false, false, false);
    }

    private void button5_Click(object sender, EventArgs e) {

      button7_Click(null, null);

      _timer = new Timer();
      _timer.Interval = 50;
      _timer.Tick += _timer_Tick_Animation1;
      _timer.Start();
    }

    void _timer_Tick_Animation1(object sender, EventArgs e) {

      int x = ucezB_Connect1.EZB.GetRandomNumber(0, 8);
      int y = ucezB_Connect1.EZB.GetRandomNumber(0, 8);
      bool r = ucezB_Connect1.EZB.GetRandomNumber(0, 2) == 1 ? true : false;
      bool g = ucezB_Connect1.EZB.GetRandomNumber(0, 2) == 1 ? true : false;
      bool b = ucezB_Connect1.EZB.GetRandomNumber(0, 2) == 1 ? true : false;

      _rgb.SetColor(x, y, r, g, b);
    }

    private void button7_Click(object sender, EventArgs e) {

      if (_timer == null)
        return;

      _timer.Stop();
      _timer.Dispose();
      _timer = null;
    }

    private void button6_Click(object sender, EventArgs e) {

      button7_Click(null, null);

      _timer = new Timer();
      _timer.Interval = 25;
      _timer.Tick += _timer_Tick_Animation2;
      _timer.Start();
    }

    int _an2X     = 0;
    int _an2Y     = 0;
    int _an2Color = 0;
    void _timer_Tick_Animation2(object sender, EventArgs e) {

      bool r = false;
      bool g = false;
      bool b = false;

      switch (_an2Color) {
        case 0:
          r = true;
          break;
        case 1:
          g = true;
          break;
        case 2:
          b = true;
          break;
        case 3:
          r = true;
          b = true;
          break;
        case 4:
          r = true;
          g = true;
          break;
        case 5:
          g = true;
          b = true;
          break;
        default:
          _an2Color = 0;
          break;
      }

      _rgb.SetColor(_an2X, _an2Y, r, g, b);

      _an2X++;

      if (_an2X > 7) {

        _an2X = 0;
        _an2Y++;
      }

      if (_an2Y > 7) {

        _an2Color++;

        _an2X = 0;
        _an2Y = 0;
      }
    }
  }
}
