using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tutorial_43___HBridge_4_Wire {

  public partial class Form1 : Form {

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      ezB_Connect1.EZB.Movement.MovementType = EZ_B.Movement.MovementTypeEnum.HBridge;
      ezB_Connect1.EZB.Movement.HBridgeLeftWheelTriggerA = EZ_B.Digital.DigitalPortEnum.D1;
      ezB_Connect1.EZB.Movement.HBridgeLeftWheelTriggerB = EZ_B.Digital.DigitalPortEnum.D2;
      ezB_Connect1.EZB.Movement.HBridgeRightWheelTriggerA = EZ_B.Digital.DigitalPortEnum.D3;
      ezB_Connect1.EZB.Movement.HBridgeRightWheelTriggerB = EZ_B.Digital.DigitalPortEnum.D4;

      // If PWM is configured, uncomment the line below to configure the speed
      ezB_Connect1.EZB.PWM.SetPWM(EZ_B.Digital.DigitalPortEnum.D0, EZ_B.PWM.PWM_MAX);
      ezB_Connect1.EZB.PWM.SetPWM(EZ_B.Digital.DigitalPortEnum.D5, EZ_B.PWM.PWM_MAX);

      ezMovement1.SetEZB = ezB_Connect1.EZB;      
    }

    private void button1_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Movement.GoForward();
    }

    private void button4_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Movement.GoStop();
    }

    private void button2_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Movement.GoRight();
    }

    private void button3_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Movement.GoLeft();
    }

    private void button5_Click(object sender, EventArgs e) {

      ezB_Connect1.EZB.Movement.GoReverse();
    }
  }
}
