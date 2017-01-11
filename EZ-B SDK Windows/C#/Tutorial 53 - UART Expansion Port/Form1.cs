using System;
using System.Text;
using System.Windows.Forms;

namespace Tutorial_53___UART_Expansion_Port {

  public partial class Form1 : Form {

    Timer _timer = new Timer();

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      _timer.Interval = 500;
      _timer.Tick += _timer_Tick;
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

      _timer.Dispose();

      _timer = null;
    }

    void _timer_Tick(object sender, EventArgs e) {

      if (!ezB_Connect1.EZB.IsConnected) {

        _timer.Stop();

        return;
      }

      int bytesAvailable = ezB_Connect1.EZB.Uart.UARTExpansionAvailableBytes(0);

      if (bytesAvailable == 0)
        return;

      byte [] data = ezB_Connect1.EZB.Uart.UARTExpansionRead(0, bytesAvailable);

      tbComm.AppendText(Encoding.ASCII.GetString(data));
    }

    private void button1_Click(object sender, EventArgs e) {

      _timer.Stop();

      if (!ezB_Connect1.EZB.IsConnected)
        return;

      try {

        ezB_Connect1.EZB.Uart.UARTExpansionInit(0, Convert.ToUInt32(tbBaudRate.Text));

        _timer.Start();
      } catch (Exception ex) {

        MessageBox.Show("Not a valid baud rate: " + ex.Message);
      }
    }

    private void tbComm_KeyPress(object sender, KeyPressEventArgs e) {

      if (!ezB_Connect1.EZB.IsConnected)
        return;

      bool passed = false;

      if (e.KeyChar == 10 || e.KeyChar == 13)
        passed = true;

      if (e.KeyChar >= 32 && e.KeyChar <= 126)
        passed = true;

      if (e.KeyChar >= 1 && e.KeyChar <= 26)
        passed = true;

      if (e.KeyChar == 27)
        passed = true;

      if (!passed)
        return;

      ezB_Connect1.EZB.Uart.UARTExpansionWrite(0, new byte[] { (byte)e.KeyChar });     
    }
  }
}
