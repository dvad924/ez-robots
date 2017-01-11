using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Tutorial_36___Serial_Cmd_Relay {

  public partial class Form1 : Form {

    readonly string _TXT_START  = "Start Listening";
    readonly string _TXT_STOP   = "Stop Listening";
    readonly int    _BUFFERSIZE = 128;

    EZ_B.Servo.ServoPortEnum _ARM_LEFT  = EZ_B.Servo.ServoPortEnum.D8;
    EZ_B.Servo.ServoPortEnum _ARM_RIGHT = EZ_B.Servo.ServoPortEnum.D9;
    EZ_B.Servo.ServoPortEnum _NECK_HOR  = EZ_B.Servo.ServoPortEnum.D6;
    EZ_B.Servo.ServoPortEnum _NECK_VER  = EZ_B.Servo.ServoPortEnum.D7;

    SerialPort _serialPort = new SerialPort();

    public Form1() {

      InitializeComponent();

      button1.Text = _TXT_START;
      _serialPort.BaudRate = 9600;
      _serialPort.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceived);
      _serialPort.ReadBufferSize = _BUFFERSIZE;

      comboBox1.Items.Clear();
      comboBox1.Items.AddRange(EZ_B.EZB.GetAvailableCommunicationPorts(false));

      ezB_Connect1.EZB.Movement.ServoWheelRightModifiedPort = EZ_B.Servo.ServoPortEnum.D14;
      ezB_Connect1.EZB.Movement.ServoWheelLeftModifiedPort = EZ_B.Servo.ServoPortEnum.D13;
      ezB_Connect1.EZB.Movement.MovementType = EZ_B.Movement.MovementTypeEnum.ModifiedServo;

      ezB_Connect1.OnConnection += new EZ_B.UCEZB_Connect.OnConnectionHandler(ezB_Connect1_OnConnection);
    }

    void ezB_Connect1_OnConnection() {

      ezB_Connect1.EZB.Servo.SetServoPosition(_NECK_HOR, 51);
      ezB_Connect1.EZB.Servo.SetServoPosition(_NECK_VER, 64);

      ezB_Connect1.EZB.Servo.SetServoPosition(_ARM_LEFT, 14);
      ezB_Connect1.EZB.Servo.SetServoPosition(_ARM_RIGHT, 77);
    }

    private void button1_Click(object sender, EventArgs e) {

      if (button1.Text == _TXT_START)
        connect();
      else
        disconnect();
    }

    private void connect() {

      try {

        disconnect();

        _serialPort.PortName = comboBox1.SelectedItem.ToString();
        _serialPort.Open();

        button1.Text = _TXT_STOP;

        _serialPort.WriteLine(string.Empty);
        _serialPort.WriteLine(string.Empty);
        _serialPort.WriteLine("EZ-Robot");
        _serialPort.WriteLine(string.Empty);
      } catch (Exception ex) {

        SetLog(string.Format("Error: {0}", ex), true);
      }
    }

    private void disconnect() {

      try {

        _serialPort.Close();

        button1.Text = _TXT_START;
      } catch (Exception ex) {

        SetLog(string.Format("Error: {0}", ex), true);
      }
    }

    delegate void SetLogCallback(string text, bool newLine);
    private void SetLog(string text, bool newLine) {

      if (this.tbLog.InvokeRequired) {

        SetLogCallback d = new SetLogCallback(SetLog);
        this.Invoke(d, new object[] { text, newLine });
      } else {

        this.tbLog.AppendText(text);

        if (newLine)
          this.tbLog.AppendText(Environment.NewLine);
      }
    }

    void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e) {

      if (e.EventType != SerialData.Chars)
        return;

        char [] buffer = new char[_BUFFERSIZE];

      int read = _serialPort.Read(buffer, 0, _serialPort.BytesToRead);

      for (int pos=0; pos < read; pos++) {

        char c = buffer[pos];

        SetLog(string.Format("Received: {0}", c), true);

        switch (char.ToLower(c)) {
          case 'w':
            ezB_Connect1.EZB.Movement.GoForward();
            break;
          case ' ':
            ezB_Connect1.EZB.Movement.GoStop();
            break;
          case 's':
            ezB_Connect1.EZB.Movement.GoReverse();
            break;
          case 'a':
            ezB_Connect1.EZB.Movement.GoLeft();
            break;
          case 'd':
            ezB_Connect1.EZB.Movement.GoRight();
            break;
          case '.':
            ezB_Connect1.EZB.Servo.SetServoPosition(_NECK_HOR, ezB_Connect1.EZB.Servo.GetServoPosition(_NECK_HOR) + 5);
            break;
          case ',':
            ezB_Connect1.EZB.Servo.SetServoPosition(_NECK_HOR, ezB_Connect1.EZB.Servo.GetServoPosition(_NECK_HOR) - 5);
            break;
          case ';':
            ezB_Connect1.EZB.Servo.SetServoPosition(_NECK_VER, ezB_Connect1.EZB.Servo.GetServoPosition(_NECK_VER) + 5);
            break;
          case '/':
            ezB_Connect1.EZB.Servo.SetServoPosition(_NECK_VER, ezB_Connect1.EZB.Servo.GetServoPosition(_NECK_VER) - 5);
            break;
          case 'h':
            _serialPort.Write(Resource1.Help);
            break;
        }
      }
    }
  }
}
