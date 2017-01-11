namespace Tutorial_53___UART_Expansion_Port {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.button1 = new System.Windows.Forms.Button();
      this.tbBaudRate = new System.Windows.Forms.TextBox();
      this.tbComm = new System.Windows.Forms.TextBox();
      this.cbLocalEcho = new System.Windows.Forms.CheckBox();
      this.ezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Location = new System.Drawing.Point(118, 56);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(101, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Set Baud Rate";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // tbBaudRate
      // 
      this.tbBaudRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbBaudRate.Location = new System.Drawing.Point(12, 58);
      this.tbBaudRate.Name = "tbBaudRate";
      this.tbBaudRate.Size = new System.Drawing.Size(100, 20);
      this.tbBaudRate.TabIndex = 2;
      this.tbBaudRate.Text = "9600";
      // 
      // tbComm
      // 
      this.tbComm.BackColor = System.Drawing.Color.Black;
      this.tbComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbComm.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbComm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.tbComm.Location = new System.Drawing.Point(12, 85);
      this.tbComm.Multiline = true;
      this.tbComm.Name = "tbComm";
      this.tbComm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbComm.Size = new System.Drawing.Size(792, 379);
      this.tbComm.TabIndex = 3;
      this.tbComm.Text = resources.GetString("tbComm.Text");
      this.tbComm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbComm_KeyPress);
      // 
      // cbLocalEcho
      // 
      this.cbLocalEcho.AutoSize = true;
      this.cbLocalEcho.Location = new System.Drawing.Point(261, 60);
      this.cbLocalEcho.Name = "cbLocalEcho";
      this.cbLocalEcho.Size = new System.Drawing.Size(80, 17);
      this.cbLocalEcho.TabIndex = 4;
      this.cbLocalEcho.Text = "Local Echo";
      this.cbLocalEcho.UseVisualStyleBackColor = true;
      // 
      // ezB_Connect1
      // 
      this.ezB_Connect1.Location = new System.Drawing.Point(12, 12);
      this.ezB_Connect1.Name = "ezB_Connect1";
      this.ezB_Connect1.Port = "COM9";
      this.ezB_Connect1.ShowDebugButton = true;
      this.ezB_Connect1.Size = new System.Drawing.Size(283, 31);
      this.ezB_Connect1.TabIndex = 0;
      this.ezB_Connect1.TCPPassword = null;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(816, 476);
      this.Controls.Add(this.cbLocalEcho);
      this.Controls.Add(this.tbComm);
      this.Controls.Add(this.tbBaudRate);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.ezB_Connect1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private EZ_B.UCEZB_Connect ezB_Connect1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox tbBaudRate;
    private System.Windows.Forms.TextBox tbComm;
    private System.Windows.Forms.CheckBox cbLocalEcho;
  }
}

