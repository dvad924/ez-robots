namespace Tutorial_28___WiiRemote {
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
      this.cbWii = new System.Windows.Forms.ComboBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cbX = new System.Windows.Forms.ComboBox();
      this.cbY = new System.Windows.Forms.ComboBox();
      this.ezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.btnRefreshREmotes = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // cbWii
      // 
      this.cbWii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbWii.FormattingEnabled = true;
      this.cbWii.Location = new System.Drawing.Point(12, 37);
      this.cbWii.Name = "cbWii";
      this.cbWii.Size = new System.Drawing.Size(257, 21);
      this.cbWii.TabIndex = 1;
      this.cbWii.SelectedIndexChanged += new System.EventHandler(this.cbWii_SelectedIndexChanged);
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(77, 121);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(295, 245);
      this.panel1.TabIndex = 2;
      // 
      // cbX
      // 
      this.cbX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbX.FormattingEnabled = true;
      this.cbX.Location = new System.Drawing.Point(12, 64);
      this.cbX.Name = "cbX";
      this.cbX.Size = new System.Drawing.Size(82, 21);
      this.cbX.TabIndex = 4;
      // 
      // cbY
      // 
      this.cbY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbY.FormattingEnabled = true;
      this.cbY.Location = new System.Drawing.Point(100, 64);
      this.cbY.Name = "cbY";
      this.cbY.Size = new System.Drawing.Size(82, 21);
      this.cbY.TabIndex = 5;
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
      // btnRefreshREmotes
      // 
      this.btnRefreshREmotes.Location = new System.Drawing.Point(275, 37);
      this.btnRefreshREmotes.Name = "btnRefreshREmotes";
      this.btnRefreshREmotes.Size = new System.Drawing.Size(107, 23);
      this.btnRefreshREmotes.TabIndex = 6;
      this.btnRefreshREmotes.Text = "Refresh Remotes";
      this.btnRefreshREmotes.UseVisualStyleBackColor = true;
      this.btnRefreshREmotes.Click += new System.EventHandler(this.btnRefreshREmotes_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(524, 405);
      this.Controls.Add(this.btnRefreshREmotes);
      this.Controls.Add(this.cbY);
      this.Controls.Add(this.cbX);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.cbWii);
      this.Controls.Add(this.ezB_Connect1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private EZ_B.UCEZB_Connect ezB_Connect1;
    private System.Windows.Forms.ComboBox cbWii;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ComboBox cbX;
    private System.Windows.Forms.ComboBox cbY;
    private System.Windows.Forms.Button btnRefreshREmotes;
  }
}

