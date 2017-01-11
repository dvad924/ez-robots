namespace Tutorial_32___Custom_TCP_Server {
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
      this.tbLog = new System.Windows.Forms.TextBox();
      this.eztcpClientManager1 = new EZ_B.EZTCPClientManager();
      this.ezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.SuspendLayout();
      // 
      // tbLog
      // 
      this.tbLog.BackColor = System.Drawing.Color.Black;
      this.tbLog.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbLog.ForeColor = System.Drawing.Color.Lime;
      this.tbLog.Location = new System.Drawing.Point(264, 37);
      this.tbLog.Multiline = true;
      this.tbLog.Name = "tbLog";
      this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbLog.Size = new System.Drawing.Size(506, 150);
      this.tbLog.TabIndex = 2;
      // 
      // eztcpClientManager1
      // 
      this.eztcpClientManager1.Location = new System.Drawing.Point(12, 37);
      this.eztcpClientManager1.Name = "eztcpClientManager1";
      this.eztcpClientManager1.Size = new System.Drawing.Size(246, 150);
      this.eztcpClientManager1.TabIndex = 1;
      // 
      // ezB_Connect1
      // 
      this.ezB_Connect1.Location = new System.Drawing.Point(0, 0);
      this.ezB_Connect1.Name = "ezB_Connect1";
      this.ezB_Connect1.Port = "";
      this.ezB_Connect1.ShowDebugButton = true;
      this.ezB_Connect1.Size = new System.Drawing.Size(283, 31);
      this.ezB_Connect1.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(782, 193);
      this.Controls.Add(this.tbLog);
      this.Controls.Add(this.eztcpClientManager1);
      this.Controls.Add(this.ezB_Connect1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private EZ_B.UCEZB_Connect ezB_Connect1;
    private EZ_B.EZTCPClientManager eztcpClientManager1;
    private System.Windows.Forms.TextBox tbLog;
  }
}

