using System;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_7___TellyMate {

  public partial class Form1 : Form {

    EZB _ezb = new EZB();

    public Form1() {

      InitializeComponent();

      panel1.Enabled = false;

      lbFontAttrib.Items.Clear();
      foreach (TellyMate.FontAttribEnum item in Enum.GetValues(typeof(TellyMate.FontAttribEnum)))
        lbFontAttrib.Items.Add(item);

      lbCommands.Items.Clear();
      foreach (TellyMate.CmdEnum item in Enum.GetValues(typeof(TellyMate.CmdEnum)))
        lbCommands.Items.Add(item);

      lbGraphics.Items.Clear();
      lbGraphics.Items.Add("EZ-B");
      lbGraphics.Items.Add("EZ-B Rocks");
      lbGraphics.Items.Add("EZ-B 3D");
      lbGraphics.Items.Add("BLOCK");
      lbGraphics.Items.Add("Robot");
      lbGraphics.Items.Add("Dalek");
      lbGraphics.Items.Add("Alien");
      lbGraphics.Items.Add("Woman");
    }

    private void btnSend_Click(object sender, EventArgs e) {

      sendText();
    }

    private void textBox1_KeyUp(object sender, KeyEventArgs e) {

      if (e.KeyCode == Keys.Enter)
        sendText();
    }

    private void sendText() {

      _ezb.TellyMate.SendText(textBox1.Text, true);

      textBox1.Clear();
    }

    private void button1_Click(object sender, EventArgs e) {

      _ezb.TellyMate.SendCommand(TellyMate.CmdEnum.Cursor_Up);
    }

    private void button2_Click(object sender, EventArgs e) {

      _ezb.TellyMate.SendCommand(TellyMate.CmdEnum.Cursor_Right);
    }

    private void button3_Click(object sender, EventArgs e) {

      _ezb.TellyMate.SendCommand(TellyMate.CmdEnum.Cursor_Left);
    }

    private void button4_Click(object sender, EventArgs e) {

      _ezb.TellyMate.SendCommand(TellyMate.CmdEnum.Cursor_Down);
    }

    private void lbFontAttrib_SelectedIndexChanged(object sender, EventArgs e) {

      TellyMate.FontAttribEnum fontAttrib = (TellyMate.FontAttribEnum)lbFontAttrib.SelectedItem;

      _ezb.TellyMate.SetFontAttrib(fontAttrib);
    }

    private void lbCommands_SelectedIndexChanged(object sender, EventArgs e) {

      TellyMate.CmdEnum cmd = (TellyMate.CmdEnum)lbCommands.SelectedItem;

      _ezb.TellyMate.SendCommand(cmd);
    }

    private void button6_Click(object sender, EventArgs e) {

      if (textBox1.Text.Length == 0)
        textBox1.Text = "Hello World";

      Random r = new Random();

      for (int x=0; x < 20; x++) {

        _ezb.TellyMate.MoveCursor(r.Next(30), r.Next(30));
        _ezb.TellyMate.SendText(textBox1.Text);
      }
    }

    private void lbGraphics_SelectedIndexChanged(object sender, EventArgs e) {

      _ezb.TellyMate.SetFontAttrib(TellyMate.FontAttribEnum.SingleWidth_SingleHeight);
      _ezb.TellyMate.SendCommand(TellyMate.CmdEnum.Clear_Screen);

      switch (lbGraphics.SelectedIndex) {

        case 0:
          _ezb.TellyMate.SendText(Resource1.EZB);
          break;
        case 1:
          _ezb.TellyMate.SendText(Resource1.EZB_Rocks);
          break;
        case 2:
          _ezb.TellyMate.SendText(Resource1.EZB3D);
          break;
        case 3:
          _ezb.TellyMate.SendText(Resource1.Block);
          break;
        case 4:
          _ezb.TellyMate.SendText(Resource1.Robot1);
          break;
        case 5:
          _ezb.TellyMate.SendText(Resource1.Dalek);
          break;
        case 6:
          _ezb.TellyMate.SendText(Resource1.Alien);
          break;
        case 7:
          _ezb.TellyMate.SendText(Resource1.Woman);
          break;
      }
    }

    private void button5_Click(object sender, EventArgs e) {

      _ezb.ShowDebugWindow();
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.EZB = _ezb;
    }

    private void ezB_Connect1_OnConnection() {

      panel1.Enabled = true;
    }
  }
}
