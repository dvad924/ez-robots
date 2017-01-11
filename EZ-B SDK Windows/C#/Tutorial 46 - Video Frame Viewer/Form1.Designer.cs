namespace Tutorial_46___Video_Frame_Viewer {
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
      this.btnLoadVideoFile = new System.Windows.Forms.Button();
      this.lblFrameTxt = new System.Windows.Forms.Label();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.pnlPreview = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.pnlPreview);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(422, 302);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Image";
      // 
      // btnLoadVideoFile
      // 
      this.btnLoadVideoFile.Location = new System.Drawing.Point(3, 3);
      this.btnLoadVideoFile.Name = "btnLoadVideoFile";
      this.btnLoadVideoFile.Size = new System.Drawing.Size(104, 23);
      this.btnLoadVideoFile.TabIndex = 1;
      this.btnLoadVideoFile.Text = "Load Video File";
      this.btnLoadVideoFile.UseVisualStyleBackColor = true;
      this.btnLoadVideoFile.Click += new System.EventHandler(this.btnLoadVideoFile_Click);
      // 
      // lblFrameTxt
      // 
      this.lblFrameTxt.AutoSize = true;
      this.lblFrameTxt.Location = new System.Drawing.Point(113, 8);
      this.lblFrameTxt.Name = "lblFrameTxt";
      this.lblFrameTxt.Size = new System.Drawing.Size(54, 13);
      this.lblFrameTxt.TabIndex = 2;
      this.lblFrameTxt.Text = "Frame x/y";
      // 
      // trackBar1
      // 
      this.trackBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.trackBar1.Location = new System.Drawing.Point(0, 55);
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(422, 45);
      this.trackBar1.TabIndex = 3;
      this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      // 
      // pnlPreview
      // 
      this.pnlPreview.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlPreview.Location = new System.Drawing.Point(3, 16);
      this.pnlPreview.Name = "pnlPreview";
      this.pnlPreview.Size = new System.Drawing.Size(416, 283);
      this.pnlPreview.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.trackBar1);
      this.panel1.Controls.Add(this.lblFrameTxt);
      this.panel1.Controls.Add(this.btnLoadVideoFile);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 302);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(422, 100);
      this.panel1.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(422, 402);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnLoadVideoFile;
    private System.Windows.Forms.Label lblFrameTxt;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.Panel pnlPreview;
    private System.Windows.Forms.Panel panel1;
  }
}

