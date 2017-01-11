namespace Tutorial_52___EZ_Builder_Script_Interface_Client {
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
      this.label1 = new System.Windows.Forms.Label();
      this.btnConnect = new System.Windows.Forms.Button();
      this.tbAddress = new System.Windows.Forms.TextBox();
      this.tbPort = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tbLog = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnSpeakX = new System.Windows.Forms.Button();
      this.btnSpeakTime = new System.Windows.Forms.Button();
      this.btnStopCamera = new System.Windows.Forms.Button();
      this.btnStartCamera = new System.Windows.Forms.Button();
      this.btnGetX = new System.Windows.Forms.Button();
      this.tbX = new System.Windows.Forms.TextBox();
      this.btnSetX = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.groupBox1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(33, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "EZ-Builder Address:";
      // 
      // btnConnect
      // 
      this.btnConnect.Location = new System.Drawing.Point(136, 59);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(75, 23);
      this.btnConnect.TabIndex = 1;
      this.btnConnect.Text = "Connect";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnConnect.Click += new System.EventHandler(this.button1_Click);
      // 
      // tbAddress
      // 
      this.tbAddress.Location = new System.Drawing.Point(139, 7);
      this.tbAddress.Name = "tbAddress";
      this.tbAddress.Size = new System.Drawing.Size(100, 20);
      this.tbAddress.TabIndex = 2;
      this.tbAddress.Text = "127.0.0.1";
      // 
      // tbPort
      // 
      this.tbPort.Location = new System.Drawing.Point(139, 33);
      this.tbPort.Name = "tbPort";
      this.tbPort.Size = new System.Drawing.Size(100, 20);
      this.tbPort.TabIndex = 4;
      this.tbPort.Text = "6666";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(5, 36);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(128, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Script Interface TCP Port:";
      // 
      // tbLog
      // 
      this.tbLog.BackColor = System.Drawing.Color.Black;
      this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbLog.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbLog.ForeColor = System.Drawing.Color.White;
      this.tbLog.Location = new System.Drawing.Point(0, 230);
      this.tbLog.Multiline = true;
      this.tbLog.Name = "tbLog";
      this.tbLog.Size = new System.Drawing.Size(767, 225);
      this.tbLog.TabIndex = 5;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnSpeakX);
      this.groupBox1.Controls.Add(this.btnSpeakTime);
      this.groupBox1.Controls.Add(this.btnStopCamera);
      this.groupBox1.Controls.Add(this.btnStartCamera);
      this.groupBox1.Controls.Add(this.btnGetX);
      this.groupBox1.Controls.Add(this.tbX);
      this.groupBox1.Controls.Add(this.btnSetX);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 92);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(767, 138);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Commands";
      // 
      // btnSpeakX
      // 
      this.btnSpeakX.Location = new System.Drawing.Point(290, 48);
      this.btnSpeakX.Name = "btnSpeakX";
      this.btnSpeakX.Size = new System.Drawing.Size(75, 23);
      this.btnSpeakX.TabIndex = 11;
      this.btnSpeakX.Text = "Speak $X";
      this.btnSpeakX.UseVisualStyleBackColor = true;
      this.btnSpeakX.Click += new System.EventHandler(this.btnSpeakX_Click);
      // 
      // btnSpeakTime
      // 
      this.btnSpeakTime.Location = new System.Drawing.Point(290, 19);
      this.btnSpeakTime.Name = "btnSpeakTime";
      this.btnSpeakTime.Size = new System.Drawing.Size(75, 23);
      this.btnSpeakTime.TabIndex = 10;
      this.btnSpeakTime.Text = "Speak Time";
      this.btnSpeakTime.UseVisualStyleBackColor = true;
      this.btnSpeakTime.Click += new System.EventHandler(this.btnSpeakTime_Click);
      // 
      // btnStopCamera
      // 
      this.btnStopCamera.Location = new System.Drawing.Point(12, 106);
      this.btnStopCamera.Name = "btnStopCamera";
      this.btnStopCamera.Size = new System.Drawing.Size(101, 23);
      this.btnStopCamera.TabIndex = 9;
      this.btnStopCamera.Text = "Stop Camera";
      this.btnStopCamera.UseVisualStyleBackColor = true;
      this.btnStopCamera.Click += new System.EventHandler(this.btnStopCamera_Click);
      // 
      // btnStartCamera
      // 
      this.btnStartCamera.Location = new System.Drawing.Point(12, 77);
      this.btnStartCamera.Name = "btnStartCamera";
      this.btnStartCamera.Size = new System.Drawing.Size(101, 23);
      this.btnStartCamera.TabIndex = 8;
      this.btnStartCamera.Text = "Start Camera";
      this.btnStartCamera.UseVisualStyleBackColor = true;
      this.btnStartCamera.Click += new System.EventHandler(this.btnStartCamera_Click);
      // 
      // btnGetX
      // 
      this.btnGetX.Location = new System.Drawing.Point(12, 48);
      this.btnGetX.Name = "btnGetX";
      this.btnGetX.Size = new System.Drawing.Size(75, 23);
      this.btnGetX.TabIndex = 7;
      this.btnGetX.Text = "Get $X";
      this.btnGetX.UseVisualStyleBackColor = true;
      this.btnGetX.Click += new System.EventHandler(this.btnGetX_Click);
      // 
      // tbX
      // 
      this.tbX.Location = new System.Drawing.Point(93, 21);
      this.tbX.Name = "tbX";
      this.tbX.Size = new System.Drawing.Size(100, 20);
      this.tbX.TabIndex = 6;
      this.tbX.Text = "5";
      // 
      // btnSetX
      // 
      this.btnSetX.Location = new System.Drawing.Point(12, 19);
      this.btnSetX.Name = "btnSetX";
      this.btnSetX.Size = new System.Drawing.Size(75, 23);
      this.btnSetX.TabIndex = 5;
      this.btnSetX.Text = "Set $X";
      this.btnSetX.UseVisualStyleBackColor = true;
      this.btnSetX.Click += new System.EventHandler(this.btnSetX_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.btnConnect);
      this.panel1.Controls.Add(this.tbAddress);
      this.panel1.Controls.Add(this.tbPort);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(767, 92);
      this.panel1.TabIndex = 7;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(767, 455);
      this.Controls.Add(this.tbLog);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.TextBox tbAddress;
    private System.Windows.Forms.TextBox tbPort;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbLog;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnSpeakX;
    private System.Windows.Forms.Button btnSpeakTime;
    private System.Windows.Forms.Button btnStopCamera;
    private System.Windows.Forms.Button btnStartCamera;
    private System.Windows.Forms.Button btnGetX;
    private System.Windows.Forms.TextBox tbX;
    private System.Windows.Forms.Button btnSetX;
  }
}

