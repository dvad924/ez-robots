using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_59___Auto_Position {

  public partial class Form1 : Form {

    string ActionGUID1 = string.Empty;
    string ActionGUID2 = string.Empty;

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      // Assign the EZB instance to a variable so the code looks cleaner
      EZB ezb = ucezB_Connect1.EZB;

      // These are events from the auto positions
      ezb.AutoPosition.OnComplete += AutoPosition_OnComplete;
      ezb.AutoPosition.OnStartAction += AutoPosition_OnStartAction;
      ezb.AutoPosition.OnStartFrame += AutoPosition_OnStartFrame;

      // First we define the servos
      ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D0); // 0
      ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D1); // 1
      ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D2); // 2
      ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D3); // 3

      // Add a frame. The number of positions must match the number of servos. First position is for the first servo, second position is for the second servo, etc..
      // In this example, this frame sets all servos to position 90
      string frame1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 90, 90 });

      // Now we will add more frames...
      string frame2 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 70, 20, 40, 10 });
      string frame3 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 170, 140, 80, 160 });
      string frame4 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 20, 70, 150, 100 });

      // Create an action by assigning a bunch of frames to it. 
      // Rather than a frame being assigned to an action directly, it gets wrapped in an ActionFrame which allows you to specify parameters
      // the parameters are Delay, Steps and Speed
      // The Delay is how long in MS to delay between steps
      // The Steps is how large of a step to take (1 moves the servo 1 position per step, 2 moves the servo 2 positions per step, etc..)
      // The Speed is how fast to set the ServoSpeed. A -1 means do not change the speed. 0 means move the speed to 0, etc...
      ActionGUID1 = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction(
        "Test Action 1",
        true,
        true,
        new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(frame1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(frame2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(frame3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(frame4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(frame3, 35, 1, -1),
          new EZ_B.Classes.AutoPositionActionFrame(frame2, 35, 1, -1),
          new EZ_B.Classes.AutoPositionActionFrame(frame1, 35, 1, -1),
        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      // Let's create a second action
      ActionGUID2 = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction(
        "Test Action 2",
        true,
        true,
        new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(frame1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(frame3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(frame3, 25, 5, -1),
          new EZ_B.Classes.AutoPositionActionFrame(frame2, 25, 5, -1),
        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));
    }

    void AutoPosition_OnStartFrame(AutoPosition sender, EZ_B.Classes.AutoPositionFrame frame, EZ_B.Classes.AutoPositionActionFrame actionFrame) {

      Invokers.SetAppendText(textBox1, true, "Frame {0}  (Steps: {1}, Speed: {2}, Delay: {3})", frame.Title, actionFrame.Steps, actionFrame.ServoSpeed, actionFrame.Delay);
    }

    void AutoPosition_OnStartAction(AutoPosition sender, EZ_B.Classes.AutoPositionAction action) {

      Invokers.SetAppendText(textBox1, true, "Action Started: {0}", action.Title);
    }

    void AutoPosition_OnComplete(AutoPosition sender) {

      Invokers.SetAppendText(textBox1, true, "Action Stopped");
    }

    private void btnStart_Click(object sender, EventArgs e) {

      ucezB_Connect1.EZB.AutoPosition.ExecAction(ActionGUID1);
    }

    private void btnStop_Click(object sender, EventArgs e) {

      ucezB_Connect1.EZB.AutoPosition.Stop();
    }

    private void button1_Click(object sender, EventArgs e) {

      ucezB_Connect1.EZB.AutoPosition.ExecAction(ActionGUID2);
    }
  }
}
