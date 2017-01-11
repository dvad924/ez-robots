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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.button9 = new System.Windows.Forms.Button();
      this.button10 = new System.Windows.Forms.Button();
      this.cbVerboseLogging = new System.Windows.Forms.CheckBox();
      this.ezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 41);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(408, 341);
      this.textBox1.TabIndex = 1;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(6, 20);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(126, 23);
      this.button2.TabIndex = 6;
      this.button2.Text = "Read All ADC";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.button9);
      this.groupBox1.Controls.Add(this.button10);
      this.groupBox1.Controls.Add(this.button2);
      this.groupBox1.Location = new System.Drawing.Point(426, 41);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(141, 107);
      this.groupBox1.TabIndex = 27;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Read Data";
      // 
      // button9
      // 
      this.button9.Location = new System.Drawing.Point(6, 78);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(126, 23);
      this.button9.TabIndex = 29;
      this.button9.Text = "Read All ADC Volts";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Click += new System.EventHandler(this.button9_Click);
      // 
      // button10
      // 
      this.button10.Location = new System.Drawing.Point(6, 49);
      this.button10.Name = "button10";
      this.button10.Size = new System.Drawing.Size(126, 23);
      this.button10.TabIndex = 28;
      this.button10.Text = "Read All Digital";
      this.button10.UseVisualStyleBackColor = true;
      this.button10.Click += new System.EventHandler(this.button10_Click);
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
      // ezB_Connect1
      // 
      this.ezB_Connect1.Location = new System.Drawing.Point(0, 0);
      this.ezB_Connect1.Name = "ezB_Connect1";
      this.ezB_Connect1.Size = new System.Drawing.Size(283, 31);
      this.ezB_Connect1.TabIndex = 36;
      this.ezB_Connect1.OnConnection += new EZ_B.UCEZB_Connect.OnConnectionHandler(this.ezB_Connect1_OnConnection);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(577, 421);
      this.Controls.Add(this.ezB_Connect1);
      this.Controls.Add(this.cbVerboseLogging);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.button8);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "Read All Ports";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button button10;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.CheckBox cbVerboseLogging;
    private EZ_B.UCEZB_Connect ezB_Connect1;
  }
}

