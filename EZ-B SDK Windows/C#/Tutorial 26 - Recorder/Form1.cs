using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_26___Recorder {

  public partial class Form1 : Form {

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezServo1.SetEZB = ezB_Connect1.EZB;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e) {

      if (checkBox1.Checked)
        ezB_Connect1.EZB.Recorder.StartRecording();
      else
        ezB_Connect1.EZB.Recorder.StopRecording();
    }

    private void button1_Click(object sender, EventArgs e) {

      textBox1.Clear();
      textBox1.AppendText("Started Script");
      textBox1.AppendText(Environment.NewLine);

      ezB_Connect1.EZB.Recorder.Play();

      textBox1.AppendText("Ended Script");
      textBox1.AppendText(Environment.NewLine);
    }

    private void button2_Click(object sender, EventArgs e) {

      textBox1.Clear();
      textBox1.AppendText("Started Script");
      textBox1.AppendText(Environment.NewLine);

      ezB_Connect1.EZB.Recorder.Play(Recorder.PlayDirectionEnum.Reverse);

      textBox1.AppendText("Ended Script");
      textBox1.AppendText(Environment.NewLine);
    }
  }
}
