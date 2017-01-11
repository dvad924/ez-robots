namespace Tutorial_31___AR_Drone {
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
      this.button1 = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.button9 = new System.Windows.Forms.Button();
      this.button11 = new System.Windows.Forms.Button();
      this.button12 = new System.Windows.Forms.Button();
      this.button13 = new System.Windows.Forms.Button();
      this.button14 = new System.Windows.Forms.Button();
      this.button15 = new System.Windows.Forms.Button();
      this.button16 = new System.Windows.Forms.Button();
      this.button17 = new System.Windows.Forms.Button();
      this.button18 = new System.Windows.Forms.Button();
      this.button19 = new System.Windows.Forms.Button();
      this.button20 = new System.Windows.Forms.Button();
      this.ezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button21 = new System.Windows.Forms.Button();
      this.tbLog = new System.Windows.Forms.TextBox();
      this.button22 = new System.Windows.Forms.Button();
      this.cbDroneVersion = new System.Windows.Forms.ComboBox();
      this.cbMovementTracking = new System.Windows.Forms.CheckBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(15, 69);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 48);
      this.button1.TabIndex = 1;
      this.button1.Text = "Connect to AR Drone";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(302, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(281, 208);
      this.panel1.TabIndex = 3;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(12, 255);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = "Disconnect";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(12, 168);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 5;
      this.button3.Text = "Flash LEDS";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(105, 168);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(91, 23);
      this.button4.TabIndex = 6;
      this.button4.Text = "Start Engines";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button5
      // 
      this.button5.BackColor = System.Drawing.Color.Red;
      this.button5.Location = new System.Drawing.Point(105, 255);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(91, 23);
      this.button5.TabIndex = 7;
      this.button5.Text = "Emergency";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button6
      // 
      this.button6.Location = new System.Drawing.Point(12, 197);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(75, 23);
      this.button6.TabIndex = 8;
      this.button6.Text = "Start Video";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // button7
      // 
      this.button7.Location = new System.Drawing.Point(12, 226);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(75, 23);
      this.button7.TabIndex = 9;
      this.button7.Text = "Stop Video";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new System.EventHandler(this.button7_Click);
      // 
      // button8
      // 
      this.button8.Location = new System.Drawing.Point(105, 139);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(91, 23);
      this.button8.TabIndex = 11;
      this.button8.Text = "Flat Trim";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new System.EventHandler(this.button8_Click);
      // 
      // button9
      // 
      this.button9.Location = new System.Drawing.Point(105, 197);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(91, 23);
      this.button9.TabIndex = 15;
      this.button9.Text = "Hover";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Click += new System.EventHandler(this.button9_Click);
      // 
      // button11
      // 
      this.button11.Location = new System.Drawing.Point(640, 12);
      this.button11.Name = "button11";
      this.button11.Size = new System.Drawing.Size(45, 39);
      this.button11.TabIndex = 21;
      this.button11.Text = "^";
      this.button11.UseVisualStyleBackColor = true;
      this.button11.Click += new System.EventHandler(this.btnForward_Click);
      // 
      // button12
      // 
      this.button12.Location = new System.Drawing.Point(589, 57);
      this.button12.Name = "button12";
      this.button12.Size = new System.Drawing.Size(45, 39);
      this.button12.TabIndex = 22;
      this.button12.Text = "<";
      this.button12.UseVisualStyleBackColor = true;
      this.button12.Click += new System.EventHandler(this.btnLeft_Click);
      // 
      // button13
      // 
      this.button13.Location = new System.Drawing.Point(687, 57);
      this.button13.Name = "button13";
      this.button13.Size = new System.Drawing.Size(45, 39);
      this.button13.TabIndex = 23;
      this.button13.Text = ">";
      this.button13.UseVisualStyleBackColor = true;
      this.button13.Click += new System.EventHandler(this.btnRight_Click);
      // 
      // button14
      // 
      this.button14.Location = new System.Drawing.Point(640, 99);
      this.button14.Name = "button14";
      this.button14.Size = new System.Drawing.Size(45, 39);
      this.button14.TabIndex = 24;
      this.button14.Text = "v";
      this.button14.UseVisualStyleBackColor = true;
      this.button14.Click += new System.EventHandler(this.btnReverse_Click);
      // 
      // button15
      // 
      this.button15.Location = new System.Drawing.Point(749, 20);
      this.button15.Name = "button15";
      this.button15.Size = new System.Drawing.Size(75, 23);
      this.button15.TabIndex = 25;
      this.button15.Text = "Up";
      this.button15.UseVisualStyleBackColor = true;
      this.button15.Click += new System.EventHandler(this.button15_Click);
      // 
      // button16
      // 
      this.button16.Location = new System.Drawing.Point(749, 107);
      this.button16.Name = "button16";
      this.button16.Size = new System.Drawing.Size(75, 23);
      this.button16.TabIndex = 26;
      this.button16.Text = "Down";
      this.button16.UseVisualStyleBackColor = true;
      this.button16.Click += new System.EventHandler(this.button16_Click);
      // 
      // button17
      // 
      this.button17.Location = new System.Drawing.Point(640, 57);
      this.button17.Name = "button17";
      this.button17.Size = new System.Drawing.Size(45, 39);
      this.button17.TabIndex = 27;
      this.button17.UseVisualStyleBackColor = true;
      this.button17.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // button18
      // 
      this.button18.Location = new System.Drawing.Point(12, 289);
      this.button18.Name = "button18";
      this.button18.Size = new System.Drawing.Size(86, 40);
      this.button18.TabIndex = 28;
      this.button18.Text = "Next Camera";
      this.button18.UseVisualStyleBackColor = true;
      this.button18.Click += new System.EventHandler(this.button18_Click);
      // 
      // button19
      // 
      this.button19.Location = new System.Drawing.Point(105, 226);
      this.button19.Name = "button19";
      this.button19.Size = new System.Drawing.Size(91, 23);
      this.button19.TabIndex = 29;
      this.button19.Text = "Land";
      this.button19.UseVisualStyleBackColor = true;
      this.button19.Click += new System.EventHandler(this.button19_Click);
      // 
      // button20
      // 
      this.button20.Location = new System.Drawing.Point(12, 139);
      this.button20.Name = "button20";
      this.button20.Size = new System.Drawing.Size(75, 23);
      this.button20.TabIndex = 30;
      this.button20.Text = "Set Defaults";
      this.button20.UseVisualStyleBackColor = true;
      this.button20.Click += new System.EventHandler(this.button20_Click);
      // 
      // ezB_Connect1
      // 
      this.ezB_Connect1.Location = new System.Drawing.Point(0, 0);
      this.ezB_Connect1.Name = "ezB_Connect1";
      this.ezB_Connect1.Port = "COM4";
      this.ezB_Connect1.ShowDebugButton = true;
      this.ezB_Connect1.Size = new System.Drawing.Size(283, 31);
      this.ezB_Connect1.TabIndex = 0;
      this.ezB_Connect1.TCPPassword = null;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Controls.Add(this.button21);
      this.groupBox1.Location = new System.Drawing.Point(302, 261);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(227, 68);
      this.groupBox1.TabIndex = 31;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "WiFi Name";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(6, 28);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(134, 20);
      this.textBox1.TabIndex = 1;
      // 
      // button21
      // 
      this.button21.Location = new System.Drawing.Point(146, 19);
      this.button21.Name = "button21";
      this.button21.Size = new System.Drawing.Size(75, 43);
      this.button21.TabIndex = 0;
      this.button21.Text = "Rename WiFi";
      this.button21.UseVisualStyleBackColor = true;
      this.button21.Click += new System.EventHandler(this.button21_Click);
      // 
      // tbLog
      // 
      this.tbLog.Location = new System.Drawing.Point(627, 197);
      this.tbLog.Multiline = true;
      this.tbLog.Name = "tbLog";
      this.tbLog.Size = new System.Drawing.Size(242, 132);
      this.tbLog.TabIndex = 32;
      // 
      // button22
      // 
      this.button22.Location = new System.Drawing.Point(627, 168);
      this.button22.Name = "button22";
      this.button22.Size = new System.Drawing.Size(75, 23);
      this.button22.TabIndex = 33;
      this.button22.Text = "Get Config";
      this.button22.UseVisualStyleBackColor = true;
      this.button22.Click += new System.EventHandler(this.button22_Click);
      // 
      // cbDroneVersion
      // 
      this.cbDroneVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbDroneVersion.FormattingEnabled = true;
      this.cbDroneVersion.Location = new System.Drawing.Point(96, 84);
      this.cbDroneVersion.Name = "cbDroneVersion";
      this.cbDroneVersion.Size = new System.Drawing.Size(121, 21);
      this.cbDroneVersion.TabIndex = 34;
      // 
      // cbMovementTracking
      // 
      this.cbMovementTracking.AutoSize = true;
      this.cbMovementTracking.Location = new System.Drawing.Point(302, 226);
      this.cbMovementTracking.Name = "cbMovementTracking";
      this.cbMovementTracking.Size = new System.Drawing.Size(186, 17);
      this.cbMovementTracking.TabIndex = 35;
      this.cbMovementTracking.Text = "Track Red Object with Movement";
      this.cbMovementTracking.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(881, 336);
      this.Controls.Add(this.cbMovementTracking);
      this.Controls.Add(this.cbDroneVersion);
      this.Controls.Add(this.button22);
      this.Controls.Add(this.tbLog);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.button20);
      this.Controls.Add(this.button19);
      this.Controls.Add(this.button18);
      this.Controls.Add(this.button17);
      this.Controls.Add(this.button16);
      this.Controls.Add(this.button15);
      this.Controls.Add(this.button14);
      this.Controls.Add(this.button13);
      this.Controls.Add(this.button12);
      this.Controls.Add(this.button11);
      this.Controls.Add(this.button9);
      this.Controls.Add(this.button8);
      this.Controls.Add(this.button7);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.ezB_Connect1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private EZ_B.UCEZB_Connect ezB_Connect1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Button button11;
    private System.Windows.Forms.Button button12;
    private System.Windows.Forms.Button button13;
    private System.Windows.Forms.Button button14;
    private System.Windows.Forms.Button button15;
    private System.Windows.Forms.Button button16;
    private System.Windows.Forms.Button button17;
    private System.Windows.Forms.Button button18;
    private System.Windows.Forms.Button button19;
    private System.Windows.Forms.Button button20;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button21;
    private System.Windows.Forms.TextBox tbLog;
    private System.Windows.Forms.Button button22;
    private System.Windows.Forms.ComboBox cbDroneVersion;
    private System.Windows.Forms.CheckBox cbMovementTracking;
  }
}

