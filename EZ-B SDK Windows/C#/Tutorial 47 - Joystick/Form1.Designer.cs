namespace Tutorial_47___Joystick {
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
      this.cbJoysticks = new System.Windows.Forms.ComboBox();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.ezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // cbJoysticks
      // 
      this.cbJoysticks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbJoysticks.FormattingEnabled = true;
      this.cbJoysticks.Location = new System.Drawing.Point(12, 66);
      this.cbJoysticks.Name = "cbJoysticks";
      this.cbJoysticks.Size = new System.Drawing.Size(181, 21);
      this.cbJoysticks.TabIndex = 0;
      this.cbJoysticks.SelectedIndexChanged += new System.EventHandler(this.cbJoysticks_SelectedIndexChanged);
      // 
      // btnRefresh
      // 
      this.btnRefresh.Location = new System.Drawing.Point(199, 64);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(75, 23);
      this.btnRefresh.TabIndex = 1;
      this.btnRefresh.Text = "Refresh";
      this.btnRefresh.UseVisualStyleBackColor = true;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 101);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(254, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Use the joystick to control servos on port D8 and D9\r\n";
      // 
      // ezB_Connect1
      // 
      this.ezB_Connect1.Location = new System.Drawing.Point(0, 0);
      this.ezB_Connect1.Name = "ezB_Connect1";
      this.ezB_Connect1.Port = "";
      this.ezB_Connect1.ShowDebugButton = true;
      this.ezB_Connect1.Size = new System.Drawing.Size(283, 31);
      this.ezB_Connect1.TabIndex = 3;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 129);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(278, 131);
      this.textBox1.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(302, 272);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.ezB_Connect1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnRefresh);
      this.Controls.Add(this.cbJoysticks);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cbJoysticks;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.Label label1;
    private EZ_B.UCEZB_Connect ezB_Connect1;
    private System.Windows.Forms.TextBox textBox1;
  }
}

