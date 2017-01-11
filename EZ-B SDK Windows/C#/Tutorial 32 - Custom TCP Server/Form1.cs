using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tutorial_32___Custom_TCP_Server {

  public partial class Form1 : Form {

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.EZB.TCPServer.OnConnection += new EZ_B.TCPServer.OnConnectionHandler(TCPServer_OnConnection);
      ezB_Connect1.EZB.TCPServer.OnCommandReceived += new EZ_B.TCPServer.OnCommandReceivedHandler(TCPServer_OnCommandReceived);
      ezB_Connect1.EZB.TCPServer.Start(23);

      eztcpClientManager1.SetEZB = ezB_Connect1.EZB;

      SetLog("Listening on {0}", ezB_Connect1.EZB.TCPServer.Port);
    }

    void TCPServer_OnConnection(System.Net.Sockets.TcpClient tcpClient, System.Net.Sockets.NetworkStream clientStream, int id) {

      SetLog("Connection on TTY {0}", id);

      string response = "> ";

      clientStream.Write(System.Text.ASCIIEncoding.ASCII.GetBytes(response), 0, response.Length);
    }

    void TCPServer_OnCommandReceived(string command, System.Net.Sockets.NetworkStream clientStream, int id) {

      SetLog("TTY{0} Received: {1}", id, command);

      command = command.ToLower();

      string response = string.Empty;

      try {

        string [] parts = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (parts[0] == "exit") {

          ezB_Connect1.EZB.TCPServer.CloseClientById(id);

          return;
        } else if (parts[0] == "servo") {

          int servoPos = Convert.ToInt16(parts[1]);

          ezB_Connect1.EZB.Servo.SetServoPosition(EZ_B.Servo.ServoPortEnum.D1, servoPos);

          response = string.Format("Servo moved to {0}", servoPos);
          response += Environment.NewLine;
        } else {

          throw new Exception();
        }
      } catch {

        response = Environment.NewLine +
        "Type: " + Environment.NewLine +
        " servo 30" + Environment.NewLine +
        "or" + Environment.NewLine +
        " servo 10" + Environment.NewLine +
        "or" + Environment.NewLine +
        " exit" + Environment.NewLine;
      }

      response += "> ";

      clientStream.Write(System.Text.ASCIIEncoding.ASCII.GetBytes(response), 0, response.Length);
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

      ezB_Connect1.EZB.TCPServer.Stop();
    }

    delegate void SetLogCallBack(string txt, params object[] parameters);
    private void SetLog(string txt, params object[] parameters) {

      if (tbLog.InvokeRequired) {

        SetLogCallBack d = new SetLogCallBack(SetLog);
        this.Invoke(d, new object[] { txt, parameters });
      } else {

        tbLog.AppendText(string.Format(txt, parameters));
        tbLog.AppendText(Environment.NewLine);
      }
    }
  }
}
