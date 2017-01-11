namespace Tutorial_56___Object_Detection {
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
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.pnlCamera = new System.Windows.Forms.Panel();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.tbNum = new System.Windows.Forms.TextBox();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnLearn = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(12, 12);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(201, 32);
      this.comboBox1.TabIndex = 0;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // pnlCamera
      // 
      this.pnlCamera.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlCamera.Location = new System.Drawing.Point(0, 112);
      this.pnlCamera.Name = "pnlCamera";
      this.pnlCamera.Size = new System.Drawing.Size(621, 389);
      this.pnlCamera.TabIndex = 1;
      this.pnlCamera.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCamera_MouseClick);
      this.pnlCamera.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCamera_MouseMove);
      // 
      // textBox1
      // 
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.textBox1.Location = new System.Drawing.Point(0, 501);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(621, 126);
      this.textBox1.TabIndex = 2;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.button1);
      this.panel2.Controls.Add(this.progressBar1);
      this.panel2.Controls.Add(this.tbNum);
      this.panel2.Controls.Add(this.btnClear);
      this.panel2.Controls.Add(this.btnLearn);
      this.panel2.Controls.Add(this.pictureBox1);
      this.panel2.Controls.Add(this.comboBox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(621, 112);
      this.panel2.TabIndex = 3;
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(412, 70);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(75, 23);
      this.progressBar1.TabIndex = 5;
      // 
      // tbNum
      // 
      this.tbNum.Location = new System.Drawing.Point(331, 12);
      this.tbNum.Name = "tbNum";
      this.tbNum.Size = new System.Drawing.Size(75, 20);
      this.tbNum.TabIndex = 4;
      this.tbNum.Text = "3";
      // 
      // btnClear
      // 
      this.btnClear.Enabled = false;
      this.btnClear.Location = new System.Drawing.Point(412, 41);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 23);
      this.btnClear.TabIndex = 1;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // btnLearn
      // 
      this.btnLearn.Enabled = false;
      this.btnLearn.Location = new System.Drawing.Point(412, 12);
      this.btnLearn.Name = "btnLearn";
      this.btnLearn.Size = new System.Drawing.Size(75, 23);
      this.btnLearn.TabIndex = 0;
      this.btnLearn.Text = "Learn";
      this.btnLearn.UseVisualStyleBackColor = true;
      this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBox1.Location = new System.Drawing.Point(493, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(125, 91);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(284, 70);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(281, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Position";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(621, 627);
      this.Controls.Add(this.pnlCamera);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "a";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Panel pnlCamera;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button btnLearn;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.TextBox tbNum;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
  }
}

