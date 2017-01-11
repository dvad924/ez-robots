namespace Tutorial_59___Auto_Position {
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
      this.ucezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnStart = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // ucezB_Connect1
      // 
      this.ucezB_Connect1.Location = new System.Drawing.Point(20, 12);
      this.ucezB_Connect1.Name = "ucezB_Connect1";
      this.ucezB_Connect1.Port = "COM3";
      this.ucezB_Connect1.ShowDebugButton = true;
      this.ucezB_Connect1.Size = new System.Drawing.Size(283, 31);
      this.ucezB_Connect1.TabIndex = 0;
      this.ucezB_Connect1.TCPPassword = null;
      // 
      // textBox1
      // 
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox1.Location = new System.Drawing.Point(0, 115);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(346, 366);
      this.textBox1.TabIndex = 1;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.btnStart);
      this.panel1.Controls.Add(this.btnStop);
      this.panel1.Controls.Add(this.ucezB_Connect1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(346, 115);
      this.panel1.TabIndex = 2;
      // 
      // btnStart
      // 
      this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnStart.Location = new System.Drawing.Point(20, 69);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(88, 40);
      this.btnStart.TabIndex = 1;
      this.btnStart.Text = "Start Action 1";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // btnStop
      // 
      this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnStop.Location = new System.Drawing.Point(246, 69);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(88, 40);
      this.btnStop.TabIndex = 0;
      this.btnStop.Text = "Stop Action";
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // button1
      // 
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Location = new System.Drawing.Point(130, 69);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(88, 40);
      this.button1.TabIndex = 2;
      this.button1.Text = "Start Action 2";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(346, 481);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private EZ_B.UCEZB_Connect ucezB_Connect1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.Button button1;
  }
}

