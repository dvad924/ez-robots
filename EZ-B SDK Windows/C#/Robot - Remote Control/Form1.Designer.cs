namespace Serial_Test {
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
      this.trackBar3 = new System.Windows.Forms.TrackBar();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.cbCollosion = new System.Windows.Forms.CheckBox();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.checkBox4 = new System.Windows.Forms.CheckBox();
      this.trackBar2 = new System.Windows.Forms.TrackBar();
      this.cbWebServer = new System.Windows.Forms.CheckBox();
      this.cbVerboseLogging = new System.Windows.Forms.CheckBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.ezB_Connect1 = new EZ_B.EZB_Connect();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
      this.SuspendLayout();
      // 
      // trackBar3
      // 
      this.trackBar3.LargeChange = 1;
      this.trackBar3.Location = new System.Drawing.Point(444, 97);
      this.trackBar3.Maximum = 15;
      this.trackBar3.Name = "trackBar3";
      this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
      this.trackBar3.Size = new System.Drawing.Size(45, 103);
      this.trackBar3.TabIndex = 4;
      this.trackBar3.Value = 1;
      this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(55, 19);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(34, 23);
      this.button3.TabIndex = 7;
      this.button3.Text = "^";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(17, 48);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(34, 23);
      this.button4.TabIndex = 8;
      this.button4.Text = "<";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(92, 48);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(34, 23);
      this.button5.TabIndex = 9;
      this.button5.Text = ">";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button6
      // 
      this.button6.Location = new System.Drawing.Point(55, 80);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(34, 23);
      this.button6.TabIndex = 10;
      this.button6.Text = "_";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // button7
      // 
      this.button7.Location = new System.Drawing.Point(55, 48);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(34, 23);
      this.button7.TabIndex = 11;
      this.button7.Text = "[]";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new System.EventHandler(this.button7_Click);
      // 
      // button8
      // 
      this.button8.Location = new System.Drawing.Point(12, 388);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(75, 23);
      this.button8.TabIndex = 13;
      this.button8.Text = "Clear Log";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new System.EventHandler(this.button8_Click);
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Location = new System.Drawing.Point(6, 56);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(129, 17);
      this.checkBox3.TabIndex = 20;
      this.checkBox3.Text = "Auto Update (500 ms)";
      this.checkBox3.UseVisualStyleBackColor = true;
      this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
      // 
      // textBox2
      // 
      this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox2.Location = new System.Drawing.Point(86, 19);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(49, 31);
      this.textBox2.TabIndex = 21;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(6, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 25);
      this.label1.TabIndex = 22;
      this.label1.Text = "ADC 0";
      // 
      // timer1
      // 
      this.timer1.Interval = 500;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.textBox2);
      this.groupBox1.Controls.Add(this.checkBox3);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(426, 293);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(145, 89);
      this.groupBox1.TabIndex = 27;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Read Eye Sensor Data";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.cbCollosion);
      this.groupBox2.Controls.Add(this.button3);
      this.groupBox2.Controls.Add(this.button4);
      this.groupBox2.Controls.Add(this.button5);
      this.groupBox2.Controls.Add(this.button6);
      this.groupBox2.Controls.Add(this.button7);
      this.groupBox2.Location = new System.Drawing.Point(595, 10);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(149, 190);
      this.groupBox2.TabIndex = 29;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Modified Servos";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(9, 134);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(93, 13);
      this.label6.TabIndex = 40;
      this.label6.Text = "Right Wheel: RB4\r\n";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(9, 117);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(86, 13);
      this.label4.TabIndex = 39;
      this.label4.Text = "Left Wheel: RB5";
      // 
      // cbCollosion
      // 
      this.cbCollosion.Checked = true;
      this.cbCollosion.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbCollosion.Location = new System.Drawing.Point(7, 167);
      this.cbCollosion.Name = "cbCollosion";
      this.cbCollosion.Size = new System.Drawing.Size(136, 17);
      this.cbCollosion.TabIndex = 17;
      this.cbCollosion.Text = "Auto Collision (ADC0)";
      this.cbCollosion.UseVisualStyleBackColor = true;
      // 
      // trackBar1
      // 
      this.trackBar1.LargeChange = 1;
      this.trackBar1.Location = new System.Drawing.Point(538, 97);
      this.trackBar1.Maximum = 20;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
      this.trackBar1.Size = new System.Drawing.Size(45, 103);
      this.trackBar1.TabIndex = 30;
      this.trackBar1.Value = 1;
      this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      // 
      // checkBox4
      // 
      this.checkBox4.AutoSize = true;
      this.checkBox4.Location = new System.Drawing.Point(426, 247);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new System.Drawing.Size(200, 17);
      this.checkBox4.TabIndex = 31;
      this.checkBox4.Text = "Set Pins D2 && D3 On/Off (Eye LEDs)";
      this.checkBox4.UseVisualStyleBackColor = true;
      this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
      // 
      // trackBar2
      // 
      this.trackBar2.Location = new System.Drawing.Point(438, 58);
      this.trackBar2.Maximum = 15;
      this.trackBar2.Name = "trackBar2";
      this.trackBar2.Size = new System.Drawing.Size(135, 45);
      this.trackBar2.TabIndex = 32;
      this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
      // 
      // cbWebServer
      // 
      this.cbWebServer.AutoSize = true;
      this.cbWebServer.Location = new System.Drawing.Point(329, 14);
      this.cbWebServer.Name = "cbWebServer";
      this.cbWebServer.Size = new System.Drawing.Size(91, 17);
      this.cbWebServer.TabIndex = 34;
      this.cbWebServer.Text = "Enable HTTP";
      this.cbWebServer.UseVisualStyleBackColor = true;
      this.cbWebServer.CheckedChanged += new System.EventHandler(this.cbWebServer_CheckedChanged);
      // 
      // cbVerboseLogging
      // 
      this.cbVerboseLogging.AutoSize = true;
      this.cbVerboseLogging.Location = new System.Drawing.Point(95, 392);
      this.cbVerboseLogging.Name = "cbVerboseLogging";
      this.cbVerboseLogging.Size = new System.Drawing.Size(106, 17);
      this.cbVerboseLogging.TabIndex = 35;
      this.cbVerboseLogging.Text = "Verbose Logging";
      this.cbVerboseLogging.UseVisualStyleBackColor = true;
      this.cbVerboseLogging.CheckedChanged += new System.EventHandler(this.cbVerboseLogging_CheckedChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(474, 39);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(60, 13);
      this.label5.TabIndex = 36;
      this.label5.Text = "Head: RB3";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(423, 203);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 13);
      this.label2.TabIndex = 37;
      this.label2.Text = "Left Arm: RB1";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(518, 203);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(80, 13);
      this.label3.TabIndex = 38;
      this.label3.Text = "Right Arm: RB2";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(663, 206);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 42);
      this.button2.TabIndex = 39;
      this.button2.Text = "Release servos";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.Black;
      this.textBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.textBox1.Location = new System.Drawing.Point(9, 39);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(408, 341);
      this.textBox1.TabIndex = 40;
      // 
      // ezB_Connect1
      // 
      this.ezB_Connect1.Location = new System.Drawing.Point(12, 9);
      this.ezB_Connect1.Name = "ezB_Connect1";
      this.ezB_Connect1.Size = new System.Drawing.Size(283, 31);
      this.ezB_Connect1.TabIndex = 41;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(750, 421);
      this.Controls.Add(this.ezB_Connect1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.cbVerboseLogging);
      this.Controls.Add(this.cbWebServer);
      this.Controls.Add(this.trackBar2);
      this.Controls.Add(this.checkBox4);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.button8);
      this.Controls.Add(this.trackBar3);
      this.Name = "Form1";
      this.Text = "Robot Remote Control";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TrackBar trackBar3;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.CheckBox checkBox4;
    private System.Windows.Forms.TrackBar trackBar2;
    private System.Windows.Forms.CheckBox cbWebServer;
    private System.Windows.Forms.CheckBox cbCollosion;
    private System.Windows.Forms.CheckBox cbVerboseLogging;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox textBox1;
    private EZ_B.EZB_Connect ezB_Connect1;
  }
}

