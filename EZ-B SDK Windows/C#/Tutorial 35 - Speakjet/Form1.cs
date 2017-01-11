using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tutorial_35___Speakjet {

  public partial class Form1 : Form {

    public Form1() {

      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {

      byte [] helloWorld = new byte[] { 
        20, 127, 
        21, 100, 
        22, 88, 
        23, 5,
        183, 
//        7, 
        159, 
        146, 
        164, 
        01, // pause 100ms
        147, 
        151, 
        145, 
        176 };

      byte [] eZRobot = new byte [] {
      20, 96, 21, 114, 22, 88, 23, 5, 183, 7, 159, 146, 164, 147, 151, 145, 176, 157, 132, 132, 140, 8, 128, 167, 7, 128, 148, 7, 137, 7, 164, 18, 171, 136, 191        
      };

      ezB_Connect1.EZB.Speakjet.SpeakCode(EZ_B.Digital.DigitalPortEnum.D0, eZRobot);
    }

    private void button2_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Speakjet.SpeakString(EZ_B.Digital.DigitalPortEnum.D0, textBox1.Text);
    }

    private void button3_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Speakjet.PlayNote(EZ_B.Digital.DigitalPortEnum.D0, EZ_B.Speakjet.OscillatorEnum.Osc1, trackBar1.Value, 31);
    }

    private void button4_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Speakjet.PlayNote(EZ_B.Digital.DigitalPortEnum.D0, EZ_B.Speakjet.OscillatorEnum.Osc2, trackBar1.Value, 31);
    }

    private void button5_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Speakjet.SetEnvelope(EZ_B.Digital.DigitalPortEnum.D0, EZ_B.Speakjet.EnvelopeType.Sine, 100, true, false);
    }

    private void trackBar1_Scroll(object sender, EventArgs e) {

      ezB_Connect1.EZB.Speakjet.PlayNote(EZ_B.Digital.DigitalPortEnum.D0, EZ_B.Speakjet.OscillatorEnum.Osc1, trackBar1.Value, 31);
    }

    private void Form1_Load(object sender, EventArgs e) {

    }
  }
}
