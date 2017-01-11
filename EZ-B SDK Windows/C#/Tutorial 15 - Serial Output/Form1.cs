using System;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_15___Serial_Output {

  public partial class Form1 : Form {

    Timer timer = new Timer();

    public Form1() {

      InitializeComponent();

      comboBox1.Items.Clear();
      foreach (Digital.DigitalPortEnum item in Enum.GetValues(typeof(Digital.DigitalPortEnum)))
        comboBox1.Items.Add(item);

      comboBox2.Items.Clear();
      foreach (Uart.BAUD_RATE_ENUM item in Enum.GetValues(typeof(Uart.BAUD_RATE_ENUM)))
        comboBox2.Items.Add(item);
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.Port = "COM9";

      timer.Interval = 2000;
      timer.Tick += new EventHandler(timer_Tick);
      timer.Start();
    }

    void timer_Tick(object sender, EventArgs e) {

      if (!checkBox1.Checked)
        return;

      if (!ezB_Connect1.EZB.IsConnected)
        return;

      textBox2.AppendText("Start");
      textBox2.AppendText(Environment.NewLine);

      Uart.BAUD_RATE_ENUM baudRate = (Uart.BAUD_RATE_ENUM)comboBox2.SelectedItem;

      foreach (Digital.DigitalPortEnum item in Enum.GetValues(typeof(Digital.DigitalPortEnum)))
        ezB_Connect1.EZB.Uart.SendSerial(item, baudRate, textBox1.Text + Environment.NewLine);

      textBox2.AppendText("Done");
      textBox2.AppendText(Environment.NewLine);
    }

    private void button1_Click(object sender, EventArgs e) {

      if (!ezB_Connect1.EZB.IsConnected)
        return;

      Digital.DigitalPortEnum serialPort = (Digital.DigitalPortEnum)comboBox1.SelectedItem;
      Uart.BAUD_RATE_ENUM baudRate = (Uart.BAUD_RATE_ENUM)comboBox2.SelectedItem;

      ezB_Connect1.EZB.Uart.SendSerial(serialPort, baudRate, textBox1.Text + Environment.NewLine);

      textBox1.Focus();

      textBox2.AppendText("Done");
      textBox2.AppendText(Environment.NewLine);
    }

    private void button2_Click(object sender, EventArgs e) {

      if (!ezB_Connect1.EZB.IsConnected)
        return;

      textBox2.AppendText("Start");
      textBox2.AppendText(Environment.NewLine);

      Uart.BAUD_RATE_ENUM baudRate = (Uart.BAUD_RATE_ENUM)comboBox2.SelectedItem;

      foreach (Digital.DigitalPortEnum item in Enum.GetValues(typeof(Digital.DigitalPortEnum)))
        ezB_Connect1.EZB.Uart.SendSerial(item, baudRate, textBox1.Text + Environment.NewLine);

      textBox2.AppendText("Done");
      textBox2.AppendText(Environment.NewLine);
    }
  }
}
