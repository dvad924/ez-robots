namespace Tutorial_1___Modified_Servo {
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
      this.btnReverse = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      this.btnForward = new System.Windows.Forms.Button();
      this.ezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnReverse);
      this.panel1.Controls.Add(this.btnStop);
      this.panel1.Controls.Add(this.btnForward);
      this.panel1.Location = new System.Drawing.Point(12, 41);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(200, 109);
      this.panel1.TabIndex = 1;
      // 
      // btnReverse
      // 
      this.btnReverse.Location = new System.Drawing.Point(61, 72);
      this.btnReverse.Name = "btnReverse";
      this.btnReverse.Size = new System.Drawing.Size(75, 23);
      this.btnReverse.TabIndex = 2;
      this.btnReverse.Text = "Reverse";
      this.btnReverse.UseVisualStyleBackColor = true;
      this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
      // 
      // btnStop
      // 
      this.btnStop.Location = new System.Drawing.Point(61, 43);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(75, 23);
      this.btnStop.TabIndex = 1;
      this.btnStop.Text = "Stop";
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // btnForward
      // 
      this.btnForward.Location = new System.Drawing.Point(61, 14);
      this.btnForward.Name = "btnForward";
      this.btnForward.Size = new System.Drawing.Size(75, 23);
      this.btnForward.TabIndex = 0;
      this.btnForward.Text = "Forward";
      this.btnForward.UseVisualStyleBackColor = true;
      this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
      // 
      // ezB_Connect1
      // 
      this.ezB_Connect1.Location = new System.Drawing.Point(12, 4);
      this.ezB_Connect1.Name = "ezB_Connect1";
      this.ezB_Connect1.Port = "COM3";
      this.ezB_Connect1.ShowDebugButton = true;
      this.ezB_Connect1.Size = new System.Drawing.Size(283, 31);
      this.ezB_Connect1.TabIndex = 3;
      this.ezB_Connect1.TCPPassword = null;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.button5);
      this.groupBox1.Controls.Add(this.button4);
      this.groupBox1.Controls.Add(this.button3);
      this.groupBox1.Controls.Add(this.button2);
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Location = new System.Drawing.Point(231, 41);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(200, 109);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Movement Panel";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(54, 19);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Forward";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(119, 54);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Right";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(54, 83);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "Reverse";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(6, 54);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(75, 23);
      this.button4.TabIndex = 3;
      this.button4.Text = "Left";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(79, 54);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(50, 23);
      this.button5.TabIndex = 4;
      this.button5.Text = "Stop";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(757, 166);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.ezB_Connect1);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.Button btnForward;
    private System.Windows.Forms.Button btnReverse;
    private EZ_B.UCEZB_Connect ezB_Connect1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
  }
}

