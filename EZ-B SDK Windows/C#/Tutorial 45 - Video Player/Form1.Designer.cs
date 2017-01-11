namespace Tutorial_45___Video_Player {
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnPause = new System.Windows.Forms.Button();
      this.btnResume = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      this.btnPlay = new System.Windows.Forms.Button();
      this.videoPlayer1 = new EZ_B.VideoPlayer();
      this.tbLog = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.groupBox1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnPause);
      this.groupBox1.Controls.Add(this.btnResume);
      this.groupBox1.Controls.Add(this.btnStop);
      this.groupBox1.Controls.Add(this.btnPlay);
      this.groupBox1.Location = new System.Drawing.Point(9, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(385, 47);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Controls";
      // 
      // btnPause
      // 
      this.btnPause.Location = new System.Drawing.Point(273, 19);
      this.btnPause.Name = "btnPause";
      this.btnPause.Size = new System.Drawing.Size(75, 23);
      this.btnPause.TabIndex = 3;
      this.btnPause.Text = "Pause";
      this.btnPause.UseVisualStyleBackColor = true;
      this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
      // 
      // btnResume
      // 
      this.btnResume.Location = new System.Drawing.Point(192, 19);
      this.btnResume.Name = "btnResume";
      this.btnResume.Size = new System.Drawing.Size(75, 23);
      this.btnResume.TabIndex = 2;
      this.btnResume.Text = "Resume";
      this.btnResume.UseVisualStyleBackColor = true;
      this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
      // 
      // btnStop
      // 
      this.btnStop.Location = new System.Drawing.Point(111, 19);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(75, 23);
      this.btnStop.TabIndex = 1;
      this.btnStop.Text = "Stop";
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // btnPlay
      // 
      this.btnPlay.Location = new System.Drawing.Point(30, 19);
      this.btnPlay.Name = "btnPlay";
      this.btnPlay.Size = new System.Drawing.Size(75, 23);
      this.btnPlay.TabIndex = 0;
      this.btnPlay.Text = "Play";
      this.btnPlay.UseVisualStyleBackColor = true;
      this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
      // 
      // videoPlayer1
      // 
      this.videoPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.videoPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.videoPlayer1.Location = new System.Drawing.Point(0, 0);
      this.videoPlayer1.Margin = new System.Windows.Forms.Padding(0);
      this.videoPlayer1.Name = "videoPlayer1";
      this.videoPlayer1.Size = new System.Drawing.Size(402, 300);
      this.videoPlayer1.TabIndex = 0;
      // 
      // tbLog
      // 
      this.tbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.tbLog.Location = new System.Drawing.Point(0, 56);
      this.tbLog.Multiline = true;
      this.tbLog.Name = "tbLog";
      this.tbLog.ReadOnly = true;
      this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbLog.Size = new System.Drawing.Size(402, 134);
      this.tbLog.TabIndex = 2;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.tbLog);
      this.panel1.Controls.Add(this.groupBox1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 300);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(402, 190);
      this.panel1.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(402, 490);
      this.Controls.Add(this.videoPlayer1);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private EZ_B.VideoPlayer videoPlayer1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnPause;
    private System.Windows.Forms.Button btnResume;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.Button btnPlay;
    private System.Windows.Forms.TextBox tbLog;
    private System.Windows.Forms.Panel panel1;
  }
}

