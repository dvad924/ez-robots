namespace Tutorial_21___I2C_BlinkM {
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
      this.label1 = new System.Windows.Forms.Label();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.trackBar2 = new System.Windows.Forms.TrackBar();
      this.label2 = new System.Windows.Forms.Label();
      this.trackBar3 = new System.Windows.Forms.TrackBar();
      this.label3 = new System.Windows.Forms.Label();
      this.ezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 49);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(27, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Red";
      // 
      // trackBar1
      // 
      this.trackBar1.Location = new System.Drawing.Point(48, 46);
      this.trackBar1.Maximum = 255;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(224, 45);
      this.trackBar1.SmallChange = 5;
      this.trackBar1.TabIndex = 2;
      this.trackBar1.TickFrequency = 5;
      this.trackBar1.Value = 1;
      this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      // 
      // trackBar2
      // 
      this.trackBar2.Location = new System.Drawing.Point(48, 109);
      this.trackBar2.Maximum = 255;
      this.trackBar2.Name = "trackBar2";
      this.trackBar2.Size = new System.Drawing.Size(224, 45);
      this.trackBar2.SmallChange = 5;
      this.trackBar2.TabIndex = 4;
      this.trackBar2.TickFrequency = 5;
      this.trackBar2.Value = 1;
      this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 112);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(36, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Green";
      // 
      // trackBar3
      // 
      this.trackBar3.Location = new System.Drawing.Point(48, 177);
      this.trackBar3.Maximum = 255;
      this.trackBar3.Name = "trackBar3";
      this.trackBar3.Size = new System.Drawing.Size(224, 45);
      this.trackBar3.SmallChange = 5;
      this.trackBar3.TabIndex = 6;
      this.trackBar3.TickFrequency = 5;
      this.trackBar3.Value = 1;
      this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 180);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(28, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Blue";
      // 
      // ezB_Connect1
      // 
      this.ezB_Connect1.Location = new System.Drawing.Point(0, 0);
      this.ezB_Connect1.Name = "ezB_Connect1";
      this.ezB_Connect1.Size = new System.Drawing.Size(283, 31);
      this.ezB_Connect1.TabIndex = 0;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(48, 219);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(82, 17);
      this.checkBox1.TabIndex = 7;
      this.checkBox1.Text = "Lock Colors";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 262);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.trackBar3);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.trackBar2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.ezB_Connect1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private EZ_B.UCEZB_Connect ezB_Connect1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.TrackBar trackBar2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TrackBar trackBar3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.CheckBox checkBox1;
  }
}

