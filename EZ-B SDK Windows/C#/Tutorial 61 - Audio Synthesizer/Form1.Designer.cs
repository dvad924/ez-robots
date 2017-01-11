namespace Tutorial_61___Audio_Synthesizer {
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
      this.button1 = new System.Windows.Forms.Button();
      this.ucezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(33, 57);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(115, 36);
      this.button1.TabIndex = 1;
      this.button1.Text = "Play Song";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // ucezB_Connect1
      // 
      this.ucezB_Connect1.Location = new System.Drawing.Point(0, 0);
      this.ucezB_Connect1.Name = "ucezB_Connect1";
      this.ucezB_Connect1.Port = "192.168.1.1:23";
      this.ucezB_Connect1.ShowDebugButton = true;
      this.ucezB_Connect1.Size = new System.Drawing.Size(283, 31);
      this.ucezB_Connect1.TabIndex = 0;
      this.ucezB_Connect1.TCPPassword = null;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(748, 429);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.ucezB_Connect1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private EZ_B.UCEZB_Connect ucezB_Connect1;
    private System.Windows.Forms.Button button1;
  }
}

