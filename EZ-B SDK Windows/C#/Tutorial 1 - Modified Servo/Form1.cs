using System;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_1___Modified_Servo {

  public partial class Form1 : Form {

    EZB _ezb = new EZB();

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.EZB = _ezb;

      panel1.Enabled = false;

      _ezb.Movement.MovementType = Movement.MovementTypeEnum.ModifiedServo;
      _ezb.Movement.ServoWheelLeftModifiedPort = Servo.ServoPortEnum.D14;
      _ezb.Movement.ServoWheelRightModifiedPort = Servo.ServoPortEnum.D13;

      // Optionally enable these lines of code below if the modified servo requires a stop PWM to be sent
      //_ezb.Movement.ModifiedServoLeftStopValue = 108;
      //_ezb.Movement.ModifiedServoRightStopValue = 108;
      //_ezb.Movement.ModifiedServoUseStopValue = true;
    }

    private void btnForward_Click(object sender, EventArgs e) {

      _ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D14, Servo.SERVO_MAX);
    }

    private void btnStop_Click(object sender, EventArgs e) {

      _ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D14, Servo.SERVO_OFF);
    }

    private void btnReverse_Click(object sender, EventArgs e) {

      _ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D14, Servo.SERVO_MIN);
    }

    private void button1_Click(object sender, EventArgs e) {

      _ezb.Movement.GoForward();
    }

    private void button4_Click(object sender, EventArgs e) {

      _ezb.Movement.GoLeft();
    }

    private void button2_Click(object sender, EventArgs e) {

      _ezb.Movement.GoRight();
    }

    private void button3_Click(object sender, EventArgs e) {

      _ezb.Movement.GoReverse();
    }

    private void button5_Click(object sender, EventArgs e) {

      _ezb.Movement.GoStop();
    }
  }
}
