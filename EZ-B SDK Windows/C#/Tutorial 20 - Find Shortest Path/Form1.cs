using System;
using System.Windows.Forms;

namespace Tutorial_20___Find_Shortest_Path {

  public partial class Form1 : Form {

    // Used in timer to avoid double entry
    bool         _inProgress     = false; 

    // Servo port of scanner
    readonly EZ_B.Servo.ServoPortEnum _SCAN_SERVO_PIN = EZ_B.Servo.ServoPortEnum.D14;

    // HC-SR04 Sensor Pins
    readonly EZ_B.Digital.DigitalPortEnum _PING_TRIGGER_PIN = EZ_B.Digital.DigitalPortEnum.D0;
    readonly EZ_B.Digital.DigitalPortEnum _PING_ECHO_PIN = EZ_B.Digital.DigitalPortEnum.D1;

    // False scans right, True scans left
    bool         _scanDir        = false;

    // Array of distance values
    int [] _markDirArray = new int[EZ_B.Servo.SERVO_MAX + 1];

    public Form1() {

      InitializeComponent();

      timer1.Interval = 200;
      timer1.Start();
    }

    delegate void SetLogCallback(string text, params object[] vals);
    private void Log(string text, params object[] vals) {

      if (this.tbLog.InvokeRequired) {

        SetLogCallback d = new SetLogCallback(Log);
        this.Invoke(d, new object[] { text, vals });
      } else {

        this.tbLog.AppendText(string.Format(text, vals));
        this.tbLog.AppendText(Environment.NewLine);
      }
    }

    private void doSweepServo() {

      int currentPosition = ezb.EZB.Servo.GetServoPosition(_SCAN_SERVO_PIN);

      _markDirArray[currentPosition] = ezb.EZB.HC_SR04.GetValue(_PING_TRIGGER_PIN, _PING_ECHO_PIN);

      Log("Position: {0}, Distance: {1}", currentPosition, _markDirArray[currentPosition]);

      if (_scanDir)
        currentPosition++;
      else
        currentPosition--;

      ezb.EZB.Servo.SetServoPosition(_SCAN_SERVO_PIN, currentPosition);

      if (currentPosition == EZ_B.Servo.SERVO_MAX)
        _scanDir = false;
      else if (currentPosition == EZ_B.Servo.SERVO_MIN)
        _scanDir = true;
    }

    private void timer1_Tick(object sender, EventArgs e) {

      if (!ezb.EZB.IsConnected)
        return;

      if (_inProgress)
        return;

      _inProgress = true;

      doSweepServo();

      _inProgress = false;
    }
  }
}
