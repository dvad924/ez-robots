namespace Tutorial_54___Multi_Motion_Detect {
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
      this.pnlVideo = new System.Windows.Forms.Panel();
      this.cbVideoDevices = new System.Windows.Forms.ComboBox();
      this.tbLog = new System.Windows.Forms.TextBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.cbSensitivity = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // pnlVideo
      // 
      this.pnlVideo.Location = new System.Drawing.Point(37, 114);
      this.pnlVideo.Name = "pnlVideo";
      this.pnlVideo.Size = new System.Drawing.Size(397, 278);
      this.pnlVideo.TabIndex = 0;
      this.pnlVideo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlVideo_MouseClick);
      // 
      // cbVideoDevices
      // 
      this.cbVideoDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbVideoDevices.FormattingEnabled = true;
      this.cbVideoDevices.Location = new System.Drawing.Point(37, 87);
      this.cbVideoDevices.Name = "cbVideoDevices";
      this.cbVideoDevices.Size = new System.Drawing.Size(397, 21);
      this.cbVideoDevices.TabIndex = 1;
      this.cbVideoDevices.SelectedIndexChanged += new System.EventHandler(this.cbVideoDevices_SelectedIndexChanged);
      // 
      // tbLog
      // 
      this.tbLog.Location = new System.Drawing.Point(440, 114);
      this.tbLog.Multiline = true;
      this.tbLog.Name = "tbLog";
      this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbLog.Size = new System.Drawing.Size(419, 278);
      this.tbLog.TabIndex = 2;
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(484, 87);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 3;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new System.Drawing.Point(695, 31);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(65, 17);
      this.radioButton1.TabIndex = 4;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "Random";
      this.radioButton1.UseVisualStyleBackColor = true;
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new System.Drawing.Point(695, 54);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(102, 17);
      this.radioButton2.TabIndex = 5;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "Virtual Keyboard";
      this.radioButton2.UseVisualStyleBackColor = true;
      // 
      // radioButton3
      // 
      this.radioButton3.AutoSize = true;
      this.radioButton3.Location = new System.Drawing.Point(695, 77);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(50, 17);
      this.radioButton3.TabIndex = 6;
      this.radioButton3.TabStop = true;
      this.radioButton3.Text = "Song";
      this.radioButton3.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(359, 58);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 7;
      this.button1.Text = "Clear Rect";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(440, 90);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 8;
      this.label1.Text = "Patch:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(440, 63);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 10;
      this.label2.Text = "Sensitivity:";
      // 
      // cbSensitivity
      // 
      this.cbSensitivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbSensitivity.FormattingEnabled = true;
      this.cbSensitivity.Location = new System.Drawing.Point(503, 60);
      this.cbSensitivity.Name = "cbSensitivity";
      this.cbSensitivity.Size = new System.Drawing.Size(102, 21);
      this.cbSensitivity.TabIndex = 9;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(871, 485);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cbSensitivity);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.radioButton3);
      this.Controls.Add(this.radioButton2);
      this.Controls.Add(this.radioButton1);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.tbLog);
      this.Controls.Add(this.cbVideoDevices);
      this.Controls.Add(this.pnlVideo);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel pnlVideo;
    private System.Windows.Forms.ComboBox cbVideoDevices;
    private System.Windows.Forms.TextBox tbLog;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cbSensitivity;
  }
}

