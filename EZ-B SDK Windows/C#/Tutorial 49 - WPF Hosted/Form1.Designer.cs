namespace Tutorial_49___WPF_Hosted {
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
      this.button1 = new System.Windows.Forms.Button();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
      this.userControl11 = new Tutorial_49___WPF_Hosted.UserControl1();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 69);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // trackBar1
      // 
      this.trackBar1.Location = new System.Drawing.Point(0, 0);
      this.trackBar1.Maximum = 300;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(391, 45);
      this.trackBar1.TabIndex = 3;
      this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      // 
      // elementHost2
      // 
      this.elementHost2.Location = new System.Drawing.Point(94, 69);
      this.elementHost2.Name = "elementHost2";
      this.elementHost2.Size = new System.Drawing.Size(800, 549);
      this.elementHost2.TabIndex = 1;
      this.elementHost2.Text = "elementHost2";
      this.elementHost2.Child = this.userControl11;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(906, 619);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.elementHost2);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Integration.ElementHost elementHost2;
    private UserControl1 userControl11;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TrackBar trackBar1;
  }
}

