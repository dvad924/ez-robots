using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_25___ITG_3200 {

  public partial class Form1 : Form {

    Graphics _graphics;

    Timer _timer = new Timer();

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      _graphics = panel1.CreateGraphics();

      _timer.Tick += new EventHandler(_timer_Tick);
      _timer.Interval = 250;
      _timer.Start();
    }

    private void button1_Click(object sender, EventArgs e) {

      if (!ezB_Connect1.EZB.IsConnected)
        return;

      textBox1.AppendText("Who Am I: ");
      textBox1.AppendText(ezB_Connect1.EZB.MMA7455.WhoAmI().ToString());
      textBox1.AppendText(Environment.NewLine);

      // Set mode
      ezB_Connect1.EZB.MMA7455.Init(MMA7455.SensitivityEnum.Sensitivity_2g);

      textBox1.AppendText("Get Mode: ");
      textBox1.AppendText(Functions.ByteToBinaryString(ezB_Connect1.EZB.MMA7455.GetMode()));
      textBox1.AppendText(Environment.NewLine);
    }

    void _timer_Tick(object sender, EventArgs e) {

      if (!checkBox1.Checked)
        return;

      if (!ezB_Connect1.EZB.IsConnected) {

        checkBox1.Checked = false;
        return;
      }

      byte x = ezB_Connect1.EZB.MMA7455.GetX();
      byte y = ezB_Connect1.EZB.MMA7455.GetY();
      byte z = ezB_Connect1.EZB.MMA7455.GetZ();

      lblX.Text = x.ToString();
      lblY.Text = y.ToString();
      lblZ.Text = z.ToString();

      _graphics.Clear(Color.Black);

      _graphics.FillEllipse(new SolidBrush(Color.Red), x, y, 10, 10);

      _graphics.Save();
    }
  }
}




