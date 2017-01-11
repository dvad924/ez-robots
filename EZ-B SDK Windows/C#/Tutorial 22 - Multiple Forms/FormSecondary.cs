using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_22___Multiple_Forms {

  public partial class FormSecondary : Form {

    EZB _ezb = new EZB();

    public FormSecondary(EZB ezb) {

      InitializeComponent();

      _ezb = ezb;

      _ezb.Movement.MovementType = Movement.MovementTypeEnum.ModifiedServo;
      _ezb.Movement.ServoWheelLeftModifiedPort = Servo.ServoPortEnum.D1;
      _ezb.Movement.ServoWheelRightModifiedPort = Servo.ServoPortEnum.D2;
      ezMovement1.SetEZB = _ezb;

      ezServo1.SetEZB = _ezb;
      ezServo1.SetServoPort = Servo.ServoPortEnum.D0;
    }
  }
}
