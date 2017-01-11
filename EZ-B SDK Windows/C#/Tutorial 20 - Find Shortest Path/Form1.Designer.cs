namespace Tutorial_20___Find_Shortest_Path {
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
      this.ezb = new EZ_B.UCEZB_Connect();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.tbLog = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // ezb
      // 
      this.ezb.Location = new System.Drawing.Point(0, 0);
      this.ezb.Name = "ezb";
      this.ezb.Size = new System.Drawing.Size(283, 31);
      this.ezb.TabIndex = 0;
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // tbLog
      // 
      this.tbLog.BackColor = System.Drawing.Color.Black;
      this.tbLog.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.tbLog.Location = new System.Drawing.Point(24, 104);
      this.tbLog.Multiline = true;
      this.tbLog.Name = "tbLog";
      this.tbLog.ReadOnly = true;
      this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbLog.Size = new System.Drawing.Size(408, 259);
      this.tbLog.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(455, 375);
      this.Controls.Add(this.tbLog);
      this.Controls.Add(this.ezb);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private EZ_B.UCEZB_Connect ezb;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.TextBox tbLog;
  }
}

