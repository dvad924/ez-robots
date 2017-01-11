namespace Tutorial_26___Recorder {
  partial class Form1 {
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
      this.ezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.ezServo1 = new EZ_B.UCEZServo();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // ezB_Connect1
      // 
      this.ezB_Connect1.Location = new System.Drawing.Point(16, 15);
      this.ezB_Connect1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.ezB_Connect1.Name = "ezB_Connect1";
      this.ezB_Connect1.Port = "";
      this.ezB_Connect1.ShowDebugButton = true;
      this.ezB_Connect1.Size = new System.Drawing.Size(377, 38);
      this.ezB_Connect1.TabIndex = 0;
      this.ezB_Connect1.TCPPassword = null;
      // 
      // ezServo1
      // 
      this.ezServo1.Location = new System.Drawing.Point(16, 92);
      this.ezServo1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.ezServo1.Name = "ezServo1";
      this.ezServo1.SetMaximum = 70;
      this.ezServo1.SetMinimum = 1;
      this.ezServo1.SetOrientation = System.Windows.Forms.Orientation.Horizontal;
      this.ezServo1.SetServoPort = EZ_B.Servo.ServoPortEnum.D0;
      this.ezServo1.SetValue = 1;
      this.ezServo1.Size = new System.Drawing.Size(200, 54);
      this.ezServo1.TabIndex = 1;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(32, 154);
      this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(76, 21);
      this.checkBox1.TabIndex = 2;
      this.checkBox1.Text = "Record";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(328, 119);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(100, 55);
      this.button1.TabIndex = 3;
      this.button1.Text = "Play Forward";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(16, 182);
      this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(743, 349);
      this.textBox1.TabIndex = 4;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(436, 119);
      this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(100, 55);
      this.button2.TabIndex = 5;
      this.button2.Text = "Play Reverse";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(789, 546);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.ezServo1);
      this.Controls.Add(this.ezB_Connect1);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private EZ_B.UCEZB_Connect ezB_Connect1;
    private EZ_B.UCEZServo ezServo1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button2;
  }
}

