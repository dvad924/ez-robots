namespace Tutorial_48___Screen_Capture {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.btnStart = new System.Windows.Forms.Button();
      this.btnChooseFolder = new System.Windows.Forms.Button();
      this.lblFolder = new System.Windows.Forms.Label();
      this.lblTime = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.cbFormat = new System.Windows.Forms.ComboBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(12, 12);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(75, 23);
      this.btnStart.TabIndex = 0;
      this.btnStart.Text = "Start";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // btnChooseFolder
      // 
      this.btnChooseFolder.Location = new System.Drawing.Point(6, 19);
      this.btnChooseFolder.Name = "btnChooseFolder";
      this.btnChooseFolder.Size = new System.Drawing.Size(75, 39);
      this.btnChooseFolder.TabIndex = 1;
      this.btnChooseFolder.Text = "Choose Folder";
      this.btnChooseFolder.UseVisualStyleBackColor = true;
      this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
      // 
      // lblFolder
      // 
      this.lblFolder.AutoSize = true;
      this.lblFolder.Location = new System.Drawing.Point(87, 32);
      this.lblFolder.Name = "lblFolder";
      this.lblFolder.Size = new System.Drawing.Size(35, 13);
      this.lblFolder.TabIndex = 2;
      this.lblFolder.Text = "label1";
      // 
      // lblTime
      // 
      this.lblTime.AutoSize = true;
      this.lblTime.Location = new System.Drawing.Point(93, 17);
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(35, 13);
      this.lblTime.TabIndex = 3;
      this.lblTime.Text = "label2";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(33, 66);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Bit Rate:";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(87, 63);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(39, 93);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(42, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Format:";
      // 
      // comboBox1
      // 
      this.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbFormat.FormattingEnabled = true;
      this.cbFormat.Location = new System.Drawing.Point(87, 90);
      this.cbFormat.Name = "comboBox1";
      this.cbFormat.Size = new System.Drawing.Size(100, 21);
      this.cbFormat.TabIndex = 7;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnChooseFolder);
      this.groupBox1.Controls.Add(this.cbFormat);
      this.groupBox1.Controls.Add(this.lblFolder);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Location = new System.Drawing.Point(12, 41);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(449, 118);
      this.groupBox1.TabIndex = 8;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Settings";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(465, 162);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.lblTime);
      this.Controls.Add(this.btnStart);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Screen Capture";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnChooseFolder;
    private System.Windows.Forms.Label lblFolder;
    private System.Windows.Forms.Label lblTime;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cbFormat;
    private System.Windows.Forms.GroupBox groupBox1;
  }
}

