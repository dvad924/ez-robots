namespace Tutorial_22___Multiple_Forms {
  partial class FormSecondary {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.ezMovement1 = new EZ_B.EZMovement();
      this.ezServo1 = new EZ_B.UCEZServo();
      this.SuspendLayout();
      // 
      // ezMovement1
      // 
      this.ezMovement1.Location = new System.Drawing.Point(52, 12);
      this.ezMovement1.Name = "ezMovement1";
      this.ezMovement1.Size = new System.Drawing.Size(174, 129);
      this.ezMovement1.TabIndex = 0;
      // 
      // ezServo1
      // 
      this.ezServo1.Location = new System.Drawing.Point(63, 177);
      this.ezServo1.Name = "ezServo1";
      this.ezServo1.SetMaximum = 36;
      this.ezServo1.SetMinimum = 1;
      this.ezServo1.SetOrientation = System.Windows.Forms.Orientation.Horizontal;
      this.ezServo1.SetServoPort = ((EZ_B.Servo.ServoPortEnum)((EZ_B.Servo.ServoPortEnum.D4 | EZ_B.Servo.ServoPortEnum.D16)));
      this.ezServo1.SetValue = 1;
      this.ezServo1.Size = new System.Drawing.Size(163, 59);
      this.ezServo1.TabIndex = 1;
      // 
      // FormSecondary
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 262);
      this.Controls.Add(this.ezServo1);
      this.Controls.Add(this.ezMovement1);
      this.Name = "FormSecondary";
      this.Text = "FormSecondary";
      this.ResumeLayout(false);

    }

    #endregion

    private EZ_B.EZMovement ezMovement1;
    private EZ_B.UCEZServo ezServo1;

  }
}