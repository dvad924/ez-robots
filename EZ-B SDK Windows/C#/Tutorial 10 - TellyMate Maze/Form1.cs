using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_10___TellyMate_Maze {

  public partial class Form1 : Form {

    EZB _ezb = new EZB();

    string _map;
    int _x;
    int _y;

    public Form1() {

      InitializeComponent();

      panel1.Enabled = false;
      textBox1.ReadOnly = true;

      cbMap.Items.Clear();
      cbMap.Items.Add("Map 1");
      textBox2.Text = "Click and use arrow keys";
    }

    private void putDude() {

      _ezb.TellyMate.MoveCursor(_x, _y);
      _ezb.TellyMate.SendText("!");
    }

    private void eraseDude() {

      _ezb.TellyMate.MoveCursor(_x, _y);
      _ezb.TellyMate.SendText(" ");
    }

    private void populateMap(string map) {

      int y = 0;

      foreach (string line in Regex.Split(map, "\r\n")) {

        textBox1.AppendText(string.Format("{0} {1}", y, line));
        textBox1.AppendText(Environment.NewLine);

        if (line.Contains('!')) {

          _x = line.IndexOf('!');
          _y = y;
        }

        y++;
      }

      debugLocation();

      _map = map.Replace('!', ' ');
      _ezb.TellyMate.SendCommand(TellyMate.CmdEnum.Clear_Screen);
      _ezb.TellyMate.SendText(_map);

      putDude();
    }


    private void cbMap_SelectedIndexChanged(object sender, EventArgs e) {

      if (cbMap.SelectedIndex == 0)
        populateMap(Resource1.Map1);
    }

    private bool isPositionFree(int x, int y) {

      string [] lines = Regex.Split(_map, Environment.NewLine);

      if (lines[y][x] == ' ')
        return true;

      return false;
    }

    private void debugLocation() {

      textBox1.AppendText(string.Format("x:{0} y:{1}", _x, _y));
      textBox1.AppendText(Environment.NewLine);
    }

    private void button2_Click(object sender, EventArgs e) {

      if (isPositionFree(_x, _y - 1)) {

        eraseDude();
        _y--;
        putDude();
      }

      debugLocation();
    }

    private void button4_Click(object sender, EventArgs e) {

      if (isPositionFree(_x + 1, _y)) {

        eraseDude();
        _x++;
        putDude();
      }

      debugLocation();
    }

    private void button3_Click(object sender, EventArgs e) {

      if (isPositionFree(_x - 1, _y)) {

        eraseDude();
        _x--;
        putDude();
      }

      debugLocation();
    }

    private void button5_Click(object sender, EventArgs e) {

      if (isPositionFree(_x, _y + 1)) {

        eraseDude();
        _y++;
        putDude();
      }

      debugLocation();
    }

    private void button2_KeyUp(object sender, KeyEventArgs e) {

      if (e.KeyCode == Keys.Up)
        button2_Click(this, new EventArgs());
      else if (e.KeyCode == Keys.Left)
        button3_Click(this, new EventArgs());
      else if (e.KeyCode == Keys.Right)
        button4_Click(this, new EventArgs());
      else if (e.KeyCode == Keys.Down)
        button5_Click(this, new EventArgs());
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.EZB = _ezb;
    }
  }
}

