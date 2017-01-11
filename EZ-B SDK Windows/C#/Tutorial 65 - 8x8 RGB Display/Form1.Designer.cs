namespace Tutorial_65___8x8_RGB_Display {
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.cbBlue = new System.Windows.Forms.CheckBox();
      this.cbGreen = new System.Windows.Forms.CheckBox();
      this.cbRed = new System.Windows.Forms.CheckBox();
      this.pnlButtons = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.ucezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.panel1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.cbBlue);
      this.panel1.Controls.Add(this.cbGreen);
      this.panel1.Controls.Add(this.cbRed);
      this.panel1.Location = new System.Drawing.Point(16, 19);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(306, 29);
      this.panel1.TabIndex = 1;
      // 
      // cbBlue
      // 
      this.cbBlue.AutoSize = true;
      this.cbBlue.Location = new System.Drawing.Point(184, 6);
      this.cbBlue.Name = "cbBlue";
      this.cbBlue.Size = new System.Drawing.Size(47, 17);
      this.cbBlue.TabIndex = 2;
      this.cbBlue.Text = "&Blue";
      this.cbBlue.UseVisualStyleBackColor = true;
      this.cbBlue.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // cbGreen
      // 
      this.cbGreen.AutoSize = true;
      this.cbGreen.Location = new System.Drawing.Point(98, 6);
      this.cbGreen.Name = "cbGreen";
      this.cbGreen.Size = new System.Drawing.Size(55, 17);
      this.cbGreen.TabIndex = 1;
      this.cbGreen.Text = "&Green";
      this.cbGreen.UseVisualStyleBackColor = true;
      this.cbGreen.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // cbRed
      // 
      this.cbRed.AutoSize = true;
      this.cbRed.Location = new System.Drawing.Point(12, 6);
      this.cbRed.Name = "cbRed";
      this.cbRed.Size = new System.Drawing.Size(46, 17);
      this.cbRed.TabIndex = 0;
      this.cbRed.Text = "&Red";
      this.cbRed.UseVisualStyleBackColor = true;
      this.cbRed.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // pnlButtons
      // 
      this.pnlButtons.Location = new System.Drawing.Point(16, 48);
      this.pnlButtons.Name = "pnlButtons";
      this.pnlButtons.Size = new System.Drawing.Size(306, 227);
      this.pnlButtons.TabIndex = 2;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.button7);
      this.groupBox1.Controls.Add(this.button6);
      this.groupBox1.Controls.Add(this.button5);
      this.groupBox1.Controls.Add(this.button4);
      this.groupBox1.Controls.Add(this.button3);
      this.groupBox1.Controls.Add(this.button2);
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Location = new System.Drawing.Point(400, 37);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(200, 291);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Functions";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.panel1);
      this.groupBox2.Controls.Add(this.pnlButtons);
      this.groupBox2.Location = new System.Drawing.Point(12, 37);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(355, 291);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Individual LEDs";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(6, 19);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(188, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Set All Red";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(6, 104);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(188, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "Set All Off";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(6, 48);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(188, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Set All Green";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(6, 77);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(188, 23);
      this.button4.TabIndex = 3;
      this.button4.Text = "Set All Blue";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(6, 134);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(86, 46);
      this.button5.TabIndex = 4;
      this.button5.Text = "Animation 1";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button6
      // 
      this.button6.Location = new System.Drawing.Point(108, 134);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(86, 46);
      this.button6.TabIndex = 5;
      this.button6.Text = "Animation 2";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // button7
      // 
      this.button7.Location = new System.Drawing.Point(6, 186);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(188, 23);
      this.button7.TabIndex = 6;
      this.button7.Text = "Stop Animation";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new System.EventHandler(this.button7_Click);
      // 
      // ucezB_Connect1
      // 
      this.ucezB_Connect1.Location = new System.Drawing.Point(0, 0);
      this.ucezB_Connect1.Name = "ucezB_Connect1";
      this.ucezB_Connect1.Port = "192.168.1.1:23";
      this.ucezB_Connect1.ShowDebugButton = true;
      this.ucezB_Connect1.Size = new System.Drawing.Size(306, 31);
      this.ucezB_Connect1.TabIndex = 0;
      this.ucezB_Connect1.TCPPassword = null;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(613, 335);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.ucezB_Connect1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private EZ_B.UCEZB_Connect ucezB_Connect1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel pnlButtons;
    private System.Windows.Forms.CheckBox cbBlue;
    private System.Windows.Forms.CheckBox cbGreen;
    private System.Windows.Forms.CheckBox cbRed;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button7;
  }
}

