namespace Tutorial_58___v4_Camera_Settings {
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
      this.cbVideoDevices = new System.Windows.Forms.ComboBox();
      this.pnlImage = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.checkBox4 = new System.Windows.Forms.CheckBox();
      this.button7 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.label2 = new System.Windows.Forms.Label();
      this.tbBrightness = new System.Windows.Forms.TrackBar();
      this.checkBox5 = new System.Windows.Forms.CheckBox();
      this.checkBox6 = new System.Windows.Forms.CheckBox();
      this.checkBox7 = new System.Windows.Forms.CheckBox();
      this.checkBox8 = new System.Windows.Forms.CheckBox();
      this.tbExposure = new System.Windows.Forms.TrackBar();
      this.button4 = new System.Windows.Forms.Button();
      this.tbRegister = new System.Windows.Forms.TextBox();
      this.tbRegisterValue = new System.Windows.Forms.TextBox();
      this.btnSetRegister = new System.Windows.Forms.Button();
      this.cbBank = new System.Windows.Forms.CheckBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.btnBlackandWhite = new System.Windows.Forms.Button();
      this.tbVal1 = new System.Windows.Forms.TrackBar();
      this.tbVal2 = new System.Windows.Forms.TrackBar();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbExposure)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbVal1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbVal2)).BeginInit();
      this.SuspendLayout();
      // 
      // cbVideoDevices
      // 
      this.cbVideoDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbVideoDevices.FormattingEnabled = true;
      this.cbVideoDevices.Location = new System.Drawing.Point(12, 12);
      this.cbVideoDevices.Name = "cbVideoDevices";
      this.cbVideoDevices.Size = new System.Drawing.Size(204, 21);
      this.cbVideoDevices.TabIndex = 2;
      // 
      // pnlImage
      // 
      this.pnlImage.Location = new System.Drawing.Point(12, 39);
      this.pnlImage.Name = "pnlImage";
      this.pnlImage.Size = new System.Drawing.Size(579, 399);
      this.pnlImage.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(597, 39);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(253, 37);
      this.button1.TabIndex = 4;
      this.button1.Text = "Res: 160x120";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(597, 82);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(253, 37);
      this.button2.TabIndex = 5;
      this.button2.Text = "Res: 320x240";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(597, 125);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(253, 37);
      this.button3.TabIndex = 6;
      this.button3.Text = "Res: 640x480";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(597, 334);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(70, 17);
      this.checkBox1.TabIndex = 10;
      this.checkBox1.Text = "Backlight";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new System.Drawing.Point(597, 357);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(86, 17);
      this.checkBox2.TabIndex = 11;
      this.checkBox2.Text = "Indoor Force";
      this.checkBox2.UseVisualStyleBackColor = true;
      this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Location = new System.Drawing.Point(597, 380);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(183, 17);
      this.checkBox3.TabIndex = 12;
      this.checkBox3.Text = "Checked 50hz, Unchecked 60hz";
      this.checkBox3.UseVisualStyleBackColor = true;
      this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
      // 
      // checkBox4
      // 
      this.checkBox4.AutoSize = true;
      this.checkBox4.Location = new System.Drawing.Point(597, 403);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new System.Drawing.Size(52, 17);
      this.checkBox4.TabIndex = 13;
      this.checkBox4.Text = "Mirror";
      this.checkBox4.UseVisualStyleBackColor = true;
      this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
      // 
      // button7
      // 
      this.button7.Location = new System.Drawing.Point(222, 10);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(75, 23);
      this.button7.TabIndex = 14;
      this.button7.Text = "Start";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new System.EventHandler(this.button7_Click);
      // 
      // textBox1
      // 
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.textBox1.Location = new System.Drawing.Point(0, 455);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(1148, 131);
      this.textBox1.TabIndex = 15;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(597, 425);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 16;
      this.label1.Text = "label1";
      // 
      // trackBar1
      // 
      this.trackBar1.Location = new System.Drawing.Point(597, 168);
      this.trackBar1.Maximum = 255;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(253, 45);
      this.trackBar1.TabIndex = 17;
      this.trackBar1.TickFrequency = 10;
      this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(845, 171);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 18;
      this.label2.Text = "label2";
      // 
      // tbBrightness
      // 
      this.tbBrightness.Location = new System.Drawing.Point(597, 246);
      this.tbBrightness.Maximum = 255;
      this.tbBrightness.Name = "tbBrightness";
      this.tbBrightness.Size = new System.Drawing.Size(253, 45);
      this.tbBrightness.TabIndex = 19;
      this.tbBrightness.TickFrequency = 10;
      this.tbBrightness.Scroll += new System.EventHandler(this.tbBrightness_Scroll);
      // 
      // checkBox5
      // 
      this.checkBox5.AutoSize = true;
      this.checkBox5.Location = new System.Drawing.Point(603, 297);
      this.checkBox5.Name = "checkBox5";
      this.checkBox5.Size = new System.Drawing.Size(46, 17);
      this.checkBox5.TabIndex = 20;
      this.checkBox5.Text = "Red";
      this.checkBox5.UseVisualStyleBackColor = true;
      this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
      // 
      // checkBox6
      // 
      this.checkBox6.AutoSize = true;
      this.checkBox6.Location = new System.Drawing.Point(689, 297);
      this.checkBox6.Name = "checkBox6";
      this.checkBox6.Size = new System.Drawing.Size(55, 17);
      this.checkBox6.TabIndex = 21;
      this.checkBox6.Text = "Green";
      this.checkBox6.UseVisualStyleBackColor = true;
      this.checkBox6.Click += new System.EventHandler(this.checkBox5_CheckedChanged);
      // 
      // checkBox7
      // 
      this.checkBox7.AutoSize = true;
      this.checkBox7.Location = new System.Drawing.Point(770, 297);
      this.checkBox7.Name = "checkBox7";
      this.checkBox7.Size = new System.Drawing.Size(47, 17);
      this.checkBox7.TabIndex = 22;
      this.checkBox7.Text = "Blue";
      this.checkBox7.UseVisualStyleBackColor = true;
      this.checkBox7.Click += new System.EventHandler(this.checkBox5_CheckedChanged);
      // 
      // checkBox8
      // 
      this.checkBox8.AutoSize = true;
      this.checkBox8.Location = new System.Drawing.Point(786, 380);
      this.checkBox8.Name = "checkBox8";
      this.checkBox8.Size = new System.Drawing.Size(90, 17);
      this.checkBox8.TabIndex = 23;
      this.checkBox8.Text = "Auto Banding";
      this.checkBox8.UseVisualStyleBackColor = true;
      this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
      // 
      // tbExposure
      // 
      this.tbExposure.LargeChange = 1;
      this.tbExposure.Location = new System.Drawing.Point(1032, 343);
      this.tbExposure.Maximum = 4;
      this.tbExposure.Name = "tbExposure";
      this.tbExposure.Size = new System.Drawing.Size(104, 45);
      this.tbExposure.TabIndex = 24;
      this.tbExposure.Scroll += new System.EventHandler(this.tbExposure_Scroll);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(981, 394);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(155, 55);
      this.button4.TabIndex = 25;
      this.button4.Text = "Set Brightness with registers";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // tbRegister
      // 
      this.tbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbRegister.Location = new System.Drawing.Point(948, 39);
      this.tbRegister.Name = "tbRegister";
      this.tbRegister.Size = new System.Drawing.Size(111, 26);
      this.tbRegister.TabIndex = 26;
      // 
      // tbRegisterValue
      // 
      this.tbRegisterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbRegisterValue.Location = new System.Drawing.Point(948, 71);
      this.tbRegisterValue.Name = "tbRegisterValue";
      this.tbRegisterValue.Size = new System.Drawing.Size(111, 26);
      this.tbRegisterValue.TabIndex = 27;
      // 
      // btnSetRegister
      // 
      this.btnSetRegister.Location = new System.Drawing.Point(959, 103);
      this.btnSetRegister.Name = "btnSetRegister";
      this.btnSetRegister.Size = new System.Drawing.Size(100, 23);
      this.btnSetRegister.TabIndex = 28;
      this.btnSetRegister.Text = "btnSetRegister";
      this.btnSetRegister.UseVisualStyleBackColor = true;
      this.btnSetRegister.Click += new System.EventHandler(this.btnSetRegister_Click);
      // 
      // cbBank
      // 
      this.cbBank.AutoSize = true;
      this.cbBank.Location = new System.Drawing.Point(928, 16);
      this.cbBank.Name = "cbBank";
      this.cbBank.Size = new System.Drawing.Size(216, 17);
      this.cbBank.TabIndex = 29;
      this.cbBank.Text = "DSP bank 0, checked SENSOR bank 1";
      this.cbBank.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(1065, 39);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(79, 201);
      this.panel1.TabIndex = 30;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(845, 246);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 13);
      this.label3.TabIndex = 31;
      this.label3.Text = "label3";
      // 
      // btnBlackandWhite
      // 
      this.btnBlackandWhite.Location = new System.Drawing.Point(968, 168);
      this.btnBlackandWhite.Name = "btnBlackandWhite";
      this.btnBlackandWhite.Size = new System.Drawing.Size(48, 23);
      this.btnBlackandWhite.TabIndex = 32;
      this.btnBlackandWhite.Text = "b&w";
      this.btnBlackandWhite.UseVisualStyleBackColor = true;
      this.btnBlackandWhite.Click += new System.EventHandler(this.btnBlackandWhite_Click);
      // 
      // tbVal1
      // 
      this.tbVal1.LargeChange = 1;
      this.tbVal1.Location = new System.Drawing.Point(937, 214);
      this.tbVal1.Maximum = 255;
      this.tbVal1.Name = "tbVal1";
      this.tbVal1.Size = new System.Drawing.Size(104, 45);
      this.tbVal1.TabIndex = 33;
      this.tbVal1.Scroll += new System.EventHandler(this.tbVal1_Scroll);
      // 
      // tbVal2
      // 
      this.tbVal2.LargeChange = 1;
      this.tbVal2.Location = new System.Drawing.Point(937, 246);
      this.tbVal2.Maximum = 255;
      this.tbVal2.Name = "tbVal2";
      this.tbVal2.Size = new System.Drawing.Size(104, 45);
      this.tbVal2.TabIndex = 34;
      this.tbVal2.Scroll += new System.EventHandler(this.tbVal1_Scroll);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(910, 297);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(92, 23);
      this.button5.TabIndex = 35;
      this.button5.Text = "Software Mirror";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button6
      // 
      this.button6.Location = new System.Drawing.Point(910, 326);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(92, 23);
      this.button6.TabIndex = 36;
      this.button6.Text = "Software Flip";
      this.button6.UseVisualStyleBackColor = true;
      // 
      // button8
      // 
      this.button8.Location = new System.Drawing.Point(716, 420);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(75, 23);
      this.button8.TabIndex = 37;
      this.button8.Text = "Reset Frame Average";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new System.EventHandler(this.button8_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1148, 586);
      this.Controls.Add(this.button8);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.tbVal2);
      this.Controls.Add(this.tbVal1);
      this.Controls.Add(this.btnBlackandWhite);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.cbBank);
      this.Controls.Add(this.btnSetRegister);
      this.Controls.Add(this.tbRegisterValue);
      this.Controls.Add(this.tbRegister);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.tbExposure);
      this.Controls.Add(this.checkBox8);
      this.Controls.Add(this.checkBox7);
      this.Controls.Add(this.checkBox6);
      this.Controls.Add(this.checkBox5);
      this.Controls.Add(this.tbBrightness);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button7);
      this.Controls.Add(this.checkBox4);
      this.Controls.Add(this.checkBox3);
      this.Controls.Add(this.checkBox2);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.pnlImage);
      this.Controls.Add(this.cbVideoDevices);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbExposure)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbVal1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbVal2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cbVideoDevices;
    private System.Windows.Forms.Panel pnlImage;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.CheckBox checkBox4;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TrackBar tbBrightness;
    private System.Windows.Forms.CheckBox checkBox5;
    private System.Windows.Forms.CheckBox checkBox6;
    private System.Windows.Forms.CheckBox checkBox7;
    private System.Windows.Forms.CheckBox checkBox8;
    private System.Windows.Forms.TrackBar tbExposure;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.TextBox tbRegister;
    private System.Windows.Forms.TextBox tbRegisterValue;
    private System.Windows.Forms.Button btnSetRegister;
    private System.Windows.Forms.CheckBox cbBank;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnBlackandWhite;
    private System.Windows.Forms.TrackBar tbVal1;
    private System.Windows.Forms.TrackBar tbVal2;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button8;
  }
}

