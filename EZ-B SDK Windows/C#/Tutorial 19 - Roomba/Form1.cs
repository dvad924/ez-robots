using System;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_19___Roomba {

  public partial class Form1 : Form {

    Random _random = new Random();

    public Form1() {

      InitializeComponent();

      groupBox1.Enabled = false;
    }

    private void ezB_Connect1_OnConnection() {

      groupBox1.Enabled = true;

      timer1.Interval = 250;
      timer1.Start();
    }

    private void button1_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Roomba.PowerOff();
    }

    private void button3_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Roomba.SpotClean();
    }

    private void button4_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Roomba.PlaySong(
        new RoombaSong(RoombaSong.NoteEnum.C1, 15),
        new RoombaSong(RoombaSong.NoteEnum.D1, 15),
        new RoombaSong(RoombaSong.NoteEnum.E1, 15),
        new RoombaSong(RoombaSong.NoteEnum.G1, 15),
        new RoombaSong(RoombaSong.NoteEnum.G1, 15),
        new RoombaSong(RoombaSong.NoteEnum.A1, 15),
        new RoombaSong(RoombaSong.NoteEnum.G1, 15),
        new RoombaSong(RoombaSong.NoteEnum.E1, 15),
        new RoombaSong(RoombaSong.NoteEnum.C1, 15),
        new RoombaSong(RoombaSong.NoteEnum.D1, 15),
        new RoombaSong(RoombaSong.NoteEnum.E1, 15),
        new RoombaSong(RoombaSong.NoteEnum.E1, 15),
        new RoombaSong(RoombaSong.NoteEnum.D1, 15),
        new RoombaSong(RoombaSong.NoteEnum.C1, 15),
        new RoombaSong(RoombaSong.NoteEnum.D1, 15));
    }

    private void button5_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Roomba.Stop();
    }

    private void timer1_Tick(object sender, EventArgs e) {

      if (!checkBox1.Checked)
        return;

      if (!ezB_Connect1.EZB.IsConnected)
        return;

      ezB_Connect1.EZB.Roomba.PowerLED((byte)_random.Next(1, 200), (byte)_random.Next(1, 200));
    }

    private void button6_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Roomba.Forward((byte)trackBar1.Value);
    }

    private void button7_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Roomba.Left((byte)trackBar1.Value);
    }

    private void button8_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Roomba.Right((byte)trackBar1.Value);
    }

    private void button9_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Roomba.Reverse((byte)trackBar1.Value);
    }
  }
}
