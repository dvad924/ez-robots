using System;
using System.Windows.Forms;

namespace Test___Benchmark {

  public partial class Form1 : Form {

    readonly int COUNT = 200;

    public Form1() {

      InitializeComponent();
    }

    private void writeStats(string desc, int count, DateTime start, DateTime end) {

      TimeSpan ts = end - start;

      decimal stat = ((decimal)count / (decimal)ts.TotalSeconds);

      textBox1.AppendText(string.Format("{0} took {1} to execute {2} commands", desc, ts, count));
      textBox1.AppendText(Environment.NewLine);
      textBox1.AppendText(string.Format("({0:0.00} commands per second)", stat));
      textBox1.AppendText(Environment.NewLine);
      textBox1.AppendText(Environment.NewLine);
    }

    private void button1_Click(object sender, EventArgs e) {

      if (!ezB_Connect1.EZB.IsConnected)
        return;

      DateTime start = DateTime.Now;

      for (int x=0; x < COUNT; x++)
        ezB_Connect1.EZB.ADC.GetADCValue(EZ_B.ADC.ADCPortEnum.ADC0);

      DateTime end = DateTime.Now;

      writeStats("Read ADC", COUNT, start, end);
    }

    private void button2_Click(object sender, EventArgs e) {

      if (!ezB_Connect1.EZB.IsConnected)
        return;

      DateTime start = DateTime.Now;

      for (int x=0; x < COUNT; x++)
        ezB_Connect1.EZB.Servo.SetServoPosition(EZ_B.Servo.ServoPortEnum.D0, 1);

      DateTime end = DateTime.Now;

      writeStats("Servo Position", COUNT, start, end);
    }

    private void button3_Click(object sender, EventArgs e) {

      if (!ezB_Connect1.EZB.IsConnected)
        return;

      DateTime start = DateTime.Now;

      for (int x=0; x < COUNT; x++)
        ezB_Connect1.EZB.Digital.SetDigitalPort(EZ_B.Digital.DigitalPortEnum.D0, true);

      DateTime end = DateTime.Now;

      writeStats("Set Digital", COUNT, start, end);
    }

    private void button4_Click(object sender, EventArgs e) {

      if (!ezB_Connect1.EZB.IsConnected)
        return;

      DateTime start = DateTime.Now;

      for (int x=0; x < COUNT; x++)
        ezB_Connect1.EZB.Digital.GetDigitalPort(EZ_B.Digital.DigitalPortEnum.D0);

      DateTime end = DateTime.Now;

      writeStats("Read Digital", COUNT, start, end);
    }
  }
}
