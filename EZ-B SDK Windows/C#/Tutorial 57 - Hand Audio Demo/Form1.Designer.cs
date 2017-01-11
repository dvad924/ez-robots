namespace Tutorial_57___Hand_Audio_Demo {
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
      this.pnlCamera = new System.Windows.Forms.Panel();
      this.cbVideoDevices = new System.Windows.Forms.ComboBox();
      this.tbLog = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.cbSensitivity = new System.Windows.Forms.ComboBox();
      this.btnArea1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.cbMotionSize = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.cbFrameSkip = new System.Windows.Forms.ComboBox();
      this.btnArea2 = new System.Windows.Forms.Button();
      this.btnArea3 = new System.Windows.Forms.Button();
      this.btnArea4 = new System.Windows.Forms.Button();
      this.btnArea5 = new System.Windows.Forms.Button();
      this.btnArea6 = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.button2 = new System.Windows.Forms.Button();
      this.gbMotionMode = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.gbCustomColorMode = new System.Windows.Forms.GroupBox();
      this.gbSkinColorMode = new System.Windows.Forms.GroupBox();
      this.label11 = new System.Windows.Forms.Label();
      this.cbColorSize = new System.Windows.Forms.ComboBox();
      this.label10 = new System.Windows.Forms.Label();
      this.cbColorDiff = new System.Windows.Forms.ComboBox();
      this.label12 = new System.Windows.Forms.Label();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.rbMotionMode = new System.Windows.Forms.RadioButton();
      this.rbCustomColorMode = new System.Windows.Forms.RadioButton();
      this.rbSkinColorMode = new System.Windows.Forms.RadioButton();
      this.btnCopyLog = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.gbMotionMode.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.gbCustomColorMode.SuspendLayout();
      this.gbSkinColorMode.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlCamera
      // 
      this.pnlCamera.Location = new System.Drawing.Point(21, 39);
      this.pnlCamera.Name = "pnlCamera";
      this.pnlCamera.Size = new System.Drawing.Size(640, 480);
      this.pnlCamera.TabIndex = 0;
      this.pnlCamera.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCamera_MouseClick);
      this.pnlCamera.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCamera_MouseMove);
      // 
      // cbVideoDevices
      // 
      this.cbVideoDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbVideoDevices.FormattingEnabled = true;
      this.cbVideoDevices.Location = new System.Drawing.Point(101, 11);
      this.cbVideoDevices.Name = "cbVideoDevices";
      this.cbVideoDevices.Size = new System.Drawing.Size(236, 21);
      this.cbVideoDevices.TabIndex = 1;
      this.cbVideoDevices.SelectedIndexChanged += new System.EventHandler(this.cbVideoDevices_SelectedIndexChanged);
      // 
      // tbLog
      // 
      this.tbLog.Location = new System.Drawing.Point(667, 385);
      this.tbLog.Multiline = true;
      this.tbLog.Name = "tbLog";
      this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbLog.Size = new System.Drawing.Size(609, 191);
      this.tbLog.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(14, 22);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 12;
      this.label2.Text = "Sensitivity:";
      // 
      // cbSensitivity
      // 
      this.cbSensitivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbSensitivity.FormattingEnabled = true;
      this.cbSensitivity.Location = new System.Drawing.Point(77, 19);
      this.cbSensitivity.Name = "cbSensitivity";
      this.cbSensitivity.Size = new System.Drawing.Size(102, 21);
      this.cbSensitivity.TabIndex = 11;
      // 
      // btnArea1
      // 
      this.btnArea1.Location = new System.Drawing.Point(12, 19);
      this.btnArea1.Name = "btnArea1";
      this.btnArea1.Size = new System.Drawing.Size(112, 23);
      this.btnArea1.TabIndex = 13;
      this.btnArea1.Text = "Select Area #1";
      this.btnArea1.UseVisualStyleBackColor = true;
      this.btnArea1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(41, 49);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(30, 13);
      this.label1.TabIndex = 15;
      this.label1.Text = "Size:";
      // 
      // cbMotionSize
      // 
      this.cbMotionSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbMotionSize.FormattingEnabled = true;
      this.cbMotionSize.Location = new System.Drawing.Point(77, 46);
      this.cbMotionSize.Name = "cbMotionSize";
      this.cbMotionSize.Size = new System.Drawing.Size(102, 21);
      this.cbMotionSize.TabIndex = 14;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(8, 76);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 13);
      this.label3.TabIndex = 17;
      this.label3.Text = "Frame Skip:";
      // 
      // cbFrameSkip
      // 
      this.cbFrameSkip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbFrameSkip.FormattingEnabled = true;
      this.cbFrameSkip.Location = new System.Drawing.Point(77, 73);
      this.cbFrameSkip.Name = "cbFrameSkip";
      this.cbFrameSkip.Size = new System.Drawing.Size(102, 21);
      this.cbFrameSkip.TabIndex = 16;
      // 
      // btnArea2
      // 
      this.btnArea2.Location = new System.Drawing.Point(12, 48);
      this.btnArea2.Name = "btnArea2";
      this.btnArea2.Size = new System.Drawing.Size(112, 23);
      this.btnArea2.TabIndex = 19;
      this.btnArea2.Text = "Select Area #2";
      this.btnArea2.UseVisualStyleBackColor = true;
      this.btnArea2.Click += new System.EventHandler(this.button4_Click);
      // 
      // btnArea3
      // 
      this.btnArea3.Location = new System.Drawing.Point(12, 77);
      this.btnArea3.Name = "btnArea3";
      this.btnArea3.Size = new System.Drawing.Size(112, 23);
      this.btnArea3.TabIndex = 21;
      this.btnArea3.Text = "Select Area #3";
      this.btnArea3.UseVisualStyleBackColor = true;
      this.btnArea3.Click += new System.EventHandler(this.button6_Click);
      // 
      // btnArea4
      // 
      this.btnArea4.Location = new System.Drawing.Point(12, 106);
      this.btnArea4.Name = "btnArea4";
      this.btnArea4.Size = new System.Drawing.Size(112, 23);
      this.btnArea4.TabIndex = 23;
      this.btnArea4.Text = "Select Area #4";
      this.btnArea4.UseVisualStyleBackColor = true;
      this.btnArea4.Click += new System.EventHandler(this.button8_Click);
      // 
      // btnArea5
      // 
      this.btnArea5.Location = new System.Drawing.Point(12, 135);
      this.btnArea5.Name = "btnArea5";
      this.btnArea5.Size = new System.Drawing.Size(112, 23);
      this.btnArea5.TabIndex = 25;
      this.btnArea5.Text = "Select Area #5";
      this.btnArea5.UseVisualStyleBackColor = true;
      this.btnArea5.Click += new System.EventHandler(this.button10_Click);
      // 
      // btnArea6
      // 
      this.btnArea6.Location = new System.Drawing.Point(12, 164);
      this.btnArea6.Name = "btnArea6";
      this.btnArea6.Size = new System.Drawing.Size(112, 23);
      this.btnArea6.TabIndex = 27;
      this.btnArea6.Text = "Select Area #6";
      this.btnArea6.UseVisualStyleBackColor = true;
      this.btnArea6.Click += new System.EventHandler(this.button12_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(130, 24);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(35, 13);
      this.label4.TabIndex = 28;
      this.label4.Text = "label4";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(130, 53);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(35, 13);
      this.label5.TabIndex = 29;
      this.label5.Text = "label5";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(130, 82);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(35, 13);
      this.label6.TabIndex = 30;
      this.label6.Text = "label6";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(130, 111);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(35, 13);
      this.label7.TabIndex = 31;
      this.label7.Text = "label7";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(130, 140);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(35, 13);
      this.label8.TabIndex = 32;
      this.label8.Text = "label8";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(130, 169);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(35, 13);
      this.label9.TabIndex = 33;
      this.label9.Text = "label9";
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(6, 19);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(73, 21);
      this.comboBox1.TabIndex = 34;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(6, 18);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 45);
      this.button2.TabIndex = 35;
      this.button2.Text = "Select Color";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // gbMotionMode
      // 
      this.gbMotionMode.Controls.Add(this.cbSensitivity);
      this.gbMotionMode.Controls.Add(this.label2);
      this.gbMotionMode.Controls.Add(this.cbMotionSize);
      this.gbMotionMode.Controls.Add(this.label1);
      this.gbMotionMode.Controls.Add(this.cbFrameSkip);
      this.gbMotionMode.Controls.Add(this.label3);
      this.gbMotionMode.Enabled = false;
      this.gbMotionMode.Location = new System.Drawing.Point(1027, 276);
      this.gbMotionMode.Name = "gbMotionMode";
      this.gbMotionMode.Size = new System.Drawing.Size(249, 103);
      this.gbMotionMode.TabIndex = 36;
      this.gbMotionMode.TabStop = false;
      this.gbMotionMode.Text = "Motion Mode";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btnArea1);
      this.groupBox2.Controls.Add(this.btnArea2);
      this.groupBox2.Controls.Add(this.btnArea3);
      this.groupBox2.Controls.Add(this.btnArea4);
      this.groupBox2.Controls.Add(this.label9);
      this.groupBox2.Controls.Add(this.btnArea5);
      this.groupBox2.Controls.Add(this.label8);
      this.groupBox2.Controls.Add(this.btnArea6);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Location = new System.Drawing.Point(667, 11);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(332, 191);
      this.groupBox2.TabIndex = 37;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Areas of Capture";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.comboBox1);
      this.groupBox3.Location = new System.Drawing.Point(667, 208);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(332, 45);
      this.groupBox3.TabIndex = 38;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Audio Drop-off Speed";
      // 
      // gbCustomColorMode
      // 
      this.gbCustomColorMode.Controls.Add(this.button2);
      this.gbCustomColorMode.Enabled = false;
      this.gbCustomColorMode.Location = new System.Drawing.Point(1027, 201);
      this.gbCustomColorMode.Name = "gbCustomColorMode";
      this.gbCustomColorMode.Size = new System.Drawing.Size(249, 69);
      this.gbCustomColorMode.TabIndex = 35;
      this.gbCustomColorMode.TabStop = false;
      this.gbCustomColorMode.Text = "Custom Color Mode";
      // 
      // gbSkinColorMode
      // 
      this.gbSkinColorMode.Controls.Add(this.label11);
      this.gbSkinColorMode.Controls.Add(this.cbColorSize);
      this.gbSkinColorMode.Controls.Add(this.label10);
      this.gbSkinColorMode.Controls.Add(this.cbColorDiff);
      this.gbSkinColorMode.Enabled = false;
      this.gbSkinColorMode.Location = new System.Drawing.Point(1027, 117);
      this.gbSkinColorMode.Name = "gbSkinColorMode";
      this.gbSkinColorMode.Size = new System.Drawing.Size(249, 79);
      this.gbSkinColorMode.TabIndex = 39;
      this.gbSkinColorMode.TabStop = false;
      this.gbSkinColorMode.Text = "Skin Color Mode";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(14, 49);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(27, 13);
      this.label11.TabIndex = 3;
      this.label11.Text = "Size";
      // 
      // cbColorSize
      // 
      this.cbColorSize.FormattingEnabled = true;
      this.cbColorSize.Location = new System.Drawing.Point(74, 46);
      this.cbColorSize.Name = "cbColorSize";
      this.cbColorSize.Size = new System.Drawing.Size(121, 21);
      this.cbColorSize.TabIndex = 2;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(14, 22);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(56, 13);
      this.label10.TabIndex = 1;
      this.label10.Text = "Brightness";
      // 
      // cbColorDiff
      // 
      this.cbColorDiff.FormattingEnabled = true;
      this.cbColorDiff.Location = new System.Drawing.Point(74, 19);
      this.cbColorDiff.Name = "cbColorDiff";
      this.cbColorDiff.Size = new System.Drawing.Size(121, 21);
      this.cbColorDiff.TabIndex = 0;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(21, 14);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(74, 13);
      this.label12.TabIndex = 40;
      this.label12.Text = "Video Device:";
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.rbMotionMode);
      this.groupBox6.Controls.Add(this.rbCustomColorMode);
      this.groupBox6.Controls.Add(this.rbSkinColorMode);
      this.groupBox6.Location = new System.Drawing.Point(1027, 11);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(249, 100);
      this.groupBox6.TabIndex = 41;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Tracking Mode Type";
      // 
      // rbMotionMode
      // 
      this.rbMotionMode.AutoSize = true;
      this.rbMotionMode.Location = new System.Drawing.Point(17, 65);
      this.rbMotionMode.Name = "rbMotionMode";
      this.rbMotionMode.Size = new System.Drawing.Size(87, 17);
      this.rbMotionMode.TabIndex = 2;
      this.rbMotionMode.TabStop = true;
      this.rbMotionMode.Text = "Motion Mode";
      this.rbMotionMode.UseVisualStyleBackColor = true;
      this.rbMotionMode.CheckedChanged += new System.EventHandler(this.rbMotionMode_CheckedChanged);
      // 
      // rbCustomColorMode
      // 
      this.rbCustomColorMode.AutoSize = true;
      this.rbCustomColorMode.Location = new System.Drawing.Point(17, 42);
      this.rbCustomColorMode.Name = "rbCustomColorMode";
      this.rbCustomColorMode.Size = new System.Drawing.Size(117, 17);
      this.rbCustomColorMode.TabIndex = 1;
      this.rbCustomColorMode.TabStop = true;
      this.rbCustomColorMode.Text = "Custom Color Mode";
      this.rbCustomColorMode.UseVisualStyleBackColor = true;
      this.rbCustomColorMode.CheckedChanged += new System.EventHandler(this.rbCustomColorMode_CheckedChanged);
      // 
      // rbSkinColorMode
      // 
      this.rbSkinColorMode.AutoSize = true;
      this.rbSkinColorMode.Location = new System.Drawing.Point(17, 19);
      this.rbSkinColorMode.Name = "rbSkinColorMode";
      this.rbSkinColorMode.Size = new System.Drawing.Size(103, 17);
      this.rbSkinColorMode.TabIndex = 0;
      this.rbSkinColorMode.TabStop = true;
      this.rbSkinColorMode.Text = "Skin Color Mode";
      this.rbSkinColorMode.UseVisualStyleBackColor = true;
      this.rbSkinColorMode.CheckedChanged += new System.EventHandler(this.rbSkinColorMode_CheckedChanged);
      // 
      // btnCopyLog
      // 
      this.btnCopyLog.Location = new System.Drawing.Point(667, 356);
      this.btnCopyLog.Name = "btnCopyLog";
      this.btnCopyLog.Size = new System.Drawing.Size(165, 23);
      this.btnCopyLog.TabIndex = 42;
      this.btnCopyLog.Text = "Copy Log to Clipboard";
      this.btnCopyLog.UseVisualStyleBackColor = true;
      this.btnCopyLog.Click += new System.EventHandler(this.btnCopyLog_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(838, 356);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 43;
      this.button1.Text = "Clear";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1282, 582);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnCopyLog);
      this.Controls.Add(this.groupBox6);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.gbSkinColorMode);
      this.Controls.Add(this.gbCustomColorMode);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.gbMotionMode);
      this.Controls.Add(this.tbLog);
      this.Controls.Add(this.cbVideoDevices);
      this.Controls.Add(this.pnlCamera);
      this.Name = "Form1";
      this.Text = "Nissan Hand Demo";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.gbMotionMode.ResumeLayout(false);
      this.gbMotionMode.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.gbCustomColorMode.ResumeLayout(false);
      this.gbSkinColorMode.ResumeLayout(false);
      this.gbSkinColorMode.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel pnlCamera;
    private System.Windows.Forms.ComboBox cbVideoDevices;
    private System.Windows.Forms.TextBox tbLog;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cbSensitivity;
    private System.Windows.Forms.Button btnArea1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cbMotionSize;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cbFrameSkip;
    private System.Windows.Forms.Button btnArea2;
    private System.Windows.Forms.Button btnArea3;
    private System.Windows.Forms.Button btnArea4;
    private System.Windows.Forms.Button btnArea5;
    private System.Windows.Forms.Button btnArea6;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.GroupBox gbMotionMode;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox gbCustomColorMode;
    private System.Windows.Forms.GroupBox gbSkinColorMode;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.ComboBox cbColorSize;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ComboBox cbColorDiff;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.RadioButton rbMotionMode;
    private System.Windows.Forms.RadioButton rbCustomColorMode;
    private System.Windows.Forms.RadioButton rbSkinColorMode;
    private System.Windows.Forms.Button btnCopyLog;
    private System.Windows.Forms.Button button1;
  }
}

