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
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.buttonAutonomous = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.cbCollosion = new System.Windows.Forms.CheckBox();
      this.cbVerboseLogging = new System.Windows.Forms.CheckBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.ezB_Connect1 = new EZ_B.EZB_Connect();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(55, 19);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(34, 23);
      this.button3.TabIndex = 7;
      this.button3.Text = "^";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.buttonForward_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(17, 48);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(34, 23);
      this.button4.TabIndex = 8;
      this.button4.Text = "<";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.buttonLeft_Click);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(92, 48);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(34, 23);
      this.button5.TabIndex = 9;
      this.button5.Text = ">";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.buttonRight_Click);
      // 
      // button7
      // 
      this.button7.Location = new System.Drawing.Point(55, 48);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(34, 23);
      this.button7.TabIndex = 11;
      this.button7.Text = "[]";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new System.EventHandler(this.buttonStop_Click);
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
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.textBox2);
      this.groupBox2.Controls.Add(this.buttonAutonomous);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.cbCollosion);
      this.groupBox2.Controls.Add(this.button3);
      this.groupBox2.Controls.Add(this.button4);
      this.groupBox2.Controls.Add(this.button5);
      this.groupBox2.Controls.Add(this.button7);
      this.groupBox2.Location = new System.Drawing.Point(426, 40);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(149, 237);
      this.groupBox2.TabIndex = 29;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Move";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(17, 182);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(109, 20);
      this.textBox2.TabIndex = 36;
      this.textBox2.Text = "Click for Arrow Keys";
      this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
      // 
      // buttonAutonomous
      // 
      this.buttonAutonomous.Location = new System.Drawing.Point(3, 208);
      this.buttonAutonomous.Name = "buttonAutonomous";
      this.buttonAutonomous.Size = new System.Drawing.Size(140, 23);
      this.buttonAutonomous.TabIndex = 46;
      this.buttonAutonomous.Text = "Autonomous";
      this.buttonAutonomous.UseVisualStyleBackColor = true;
      this.buttonAutonomous.Click += new System.EventHandler(this.buttonAutonomous_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(9, 113);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(93, 13);
      this.label6.TabIndex = 40;
      this.label6.Text = "Right Wheel: RB4";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(9, 94);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(86, 13);
      this.label4.TabIndex = 39;
      this.label4.Text = "Left Wheel: RB5";
      // 
      // cbCollosion
      // 
      this.cbCollosion.Checked = true;
      this.cbCollosion.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbCollosion.Location = new System.Drawing.Point(7, 132);
      this.cbCollosion.Name = "cbCollosion";
      this.cbCollosion.Size = new System.Drawing.Size(136, 17);
      this.cbCollosion.TabIndex = 17;
      this.cbCollosion.Text = "Auto Collision (ADC0)";
      this.cbCollosion.UseVisualStyleBackColor = true;
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
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.Black;
      this.textBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.textBox1.Location = new System.Drawing.Point(12, 41);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(408, 341);
      this.textBox1.TabIndex = 36;
      // 
      // ezB_Connect1
      // 
      this.ezB_Connect1.Location = new System.Drawing.Point(12, 4);
      this.ezB_Connect1.Name = "ezB_Connect1";
      this.ezB_Connect1.Size = new System.Drawing.Size(283, 31);
      this.ezB_Connect1.TabIndex = 37;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(590, 418);
      this.Controls.Add(this.ezB_Connect1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.cbVerboseLogging);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.button8);
      this.Name = "Form1";
      this.Text = "Robot - Cookie Monster";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.CheckBox cbCollosion;
    private System.Windows.Forms.CheckBox cbVerboseLogging;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button buttonAutonomous;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
    private EZ_B.EZB_Connect ezB_Connect1;
  }
}

