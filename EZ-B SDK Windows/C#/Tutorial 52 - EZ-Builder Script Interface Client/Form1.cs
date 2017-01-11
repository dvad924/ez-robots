using System;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Tutorial_52___EZ_Builder_Script_Interface_Client {

  public partial class Form1 : Form {

    TcpClient _tcpClient = null;

    public Form1() {

      InitializeComponent();

      disconnect();
    }

    private void Log(object txt, params object[] vals) {

      tbLog.AppendText(string.Format(txt.ToString(), vals));
      tbLog.AppendText(Environment.NewLine);
    }

    private void button1_Click(object sender, EventArgs e) {

      try {

        if (_tcpClient != null)
          disconnect();
        else
          connect();
      } catch (Exception ex) {

        Log("Error performing connection action: {0}", ex);
      }
    }

    private void disconnect() {

      if (_tcpClient != null)
        _tcpClient.Close();

      _tcpClient = null;

      btnConnect.Text = "Connect";

      groupBox1.Enabled = false;

      Log("Disconnected");
    }

    private void connect() {

      int port = Convert.ToInt32(tbPort.Text);

      Log("Attempting Connection to {0}:{1}", tbAddress.Text, port);

      _tcpClient = new TcpClient();

      IAsyncResult ar = _tcpClient.BeginConnect(tbAddress.Text, port, null, null);

      System.Threading.WaitHandle wh = ar.AsyncWaitHandle;

      try {

        if (!ar.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(3), false)) {

          _tcpClient.Close();

          throw new TimeoutException();
        }

        _tcpClient.EndConnect(ar);
      } finally {

        wh.Close();
      }

      _tcpClient.NoDelay = true;
      _tcpClient.ReceiveTimeout = 2000;
      _tcpClient.SendTimeout = 2000;

      groupBox1.Enabled = true;

      btnConnect.Text = "Disconnect";

      Log("Connected");

      Log(readResponseLine());
    }

    /// <summary>
    /// Send command string to the EZ-Builder connection.
    /// The input buffer will be cleared, then it will send the command, finally it reads the response.
    /// There is always a response from the EZ-Builder Script Interface:
    ///  - If you are expecting to receive data, the response will be the received data.
    ///  - If you are not expecting to receive data, the response will be "OK"
    /// </summary>
    private string sendCommand(string cmd) {

      try {

        Log("Sending: {0}", cmd);

        clearInputBuffer();

        _tcpClient.Client.Send(System.Text.Encoding.ASCII.GetBytes(cmd + Environment.NewLine));

        return readResponseLine();
      } catch (Exception ex) {

        Log("Command Error: {0}", ex);

        disconnect();
      }

      return string.Empty;
    }

    /// <summary>
    /// Clears any data in the tcp incoming buffer by reading the buffer into an empty byte array.
    /// </summary>
    private void clearInputBuffer() {

      if (_tcpClient.Available > 0)
        _tcpClient.GetStream().Read(new byte[_tcpClient.Available], 0, _tcpClient.Available);
    }

    /// <summary>
    /// Blocks and waits for a string of data to be sent. The string is terminated with a \r\n
    /// </summary>
    private string readResponseLine() {

      string str = string.Empty;

      do {

        byte [] tmpBuffer = new byte[1024];

        _tcpClient.GetStream().Read(tmpBuffer, 0, tmpBuffer.Length);

        str += System.Text.Encoding.ASCII.GetString(tmpBuffer);
      } while (!str.Contains(Environment.NewLine));

      // Return only the first line if multiple lines were received

      return str.Substring(0, str.IndexOf(Environment.NewLine));
    }

    private void btnSetX_Click(object sender, EventArgs e) {

      sendCommand(string.Format("$x = {0}", tbX.Text));
    }

    private void btnGetX_Click(object sender, EventArgs e) {

      string retVal = sendCommand("print($x)");

      Log(retVal);
    }

    private void btnStartCamera_Click(object sender, EventArgs e) {

      sendCommand("ControlCommand(\"Camera\", CameraStart)");
    }

    private void btnStopCamera_Click(object sender, EventArgs e) {

      sendCommand("ControlCommand(\"Camera\", CameraStop)");
    }

    private void btnSpeakTime_Click(object sender, EventArgs e) {

      sendCommand("Say(\"The time is \" + $time)");
    }

    private void btnSpeakX_Click(object sender, EventArgs e) {

      sendCommand("Say(\"X equals \" + $x)");
    }
  }
}
