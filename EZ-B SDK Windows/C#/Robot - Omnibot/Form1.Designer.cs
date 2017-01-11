namespace Robot___Omnibot {
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
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.button6 = new System.Windows.Forms.Button();
      this.cbStop = new System.Windows.Forms.CheckBox();
      this.tbMove = new System.Windows.Forms.TextBox();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.tbHead = new System.Windows.Forms.TrackBar();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cbVideoDevices = new System.Windows.Forms.ComboBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.btnRefreshCameraList = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.lbModes = new System.Windows.Forms.ListBox();
      this.tbColorBrightness = new System.Windows.Forms.TrackBar();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.tbMotionDifference = new System.Windows.Forms.TrackBar();
      this.groupBox7 = new System.Windows.Forms.GroupBox();
      this.tbMotionCount = new System.Windows.Forms.TrackBar();
      this.groupBox8 = new System.Windows.Forms.GroupBox();
      this.button8 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox9 = new System.Windows.Forms.GroupBox();
      this.lblPhrase = new System.Windows.Forms.Label();
      this.lblDistance = new System.Windows.Forms.Label();
      this.lblCountDown = new System.Windows.Forms.Label();
      this.tbLog = new System.Windows.Forms.TextBox();
      this.cbFreezeMode = new System.Windows.Forms.CheckBox();
      this.groupBox10 = new System.Windows.Forms.GroupBox();
      this.tbScanServo = new System.Windows.Forms.TrackBar();
      this.groupBox11 = new System.Windows.Forms.GroupBox();
      this.btnRefreshJoystick = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.ezbConnect = new EZ_B.UCEZB_Connect();
      this.cbListen = new System.Windows.Forms.CheckBox();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbHead)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbColorBrightness)).BeginInit();
      this.groupBox5.SuspendLayout();
      this.groupBox6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbMotionDifference)).BeginInit();
      this.groupBox7.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbMotionCount)).BeginInit();
      this.groupBox8.SuspendLayout();
      this.groupBox9.SuspendLayout();
      this.groupBox10.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbScanServo)).BeginInit();
      this.groupBox11.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.button6);
      this.groupBox2.Controls.Add(this.cbStop);
      this.groupBox2.Controls.Add(this.tbMove);
      this.groupBox2.Controls.Add(this.button3);
      this.groupBox2.Controls.Add(this.button4);
      this.groupBox2.Controls.Add(this.button5);
      this.groupBox2.Controls.Add(this.button7);
      this.groupBox2.Location = new System.Drawing.Point(12, 37);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(149, 145);
      this.groupBox2.TabIndex = 30;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Movement";
      // 
      // button6
      // 
      this.button6.Location = new System.Drawing.Point(55, 80);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(34, 23);
      this.button6.TabIndex = 10;
      this.button6.Text = "v";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.buttonBack_Click);
      // 
      // cbStop
      // 
      this.cbStop.AutoSize = true;
      this.cbStop.Checked = true;
      this.cbStop.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbStop.Location = new System.Drawing.Point(97, 96);
      this.cbStop.Name = "cbStop";
      this.cbStop.Size = new System.Drawing.Size(48, 17);
      this.cbStop.TabIndex = 45;
      this.cbStop.Text = "Stop";
      this.cbStop.UseVisualStyleBackColor = true;
      // 
      // tbMove
      // 
      this.tbMove.BackColor = System.Drawing.Color.Black;
      this.tbMove.Location = new System.Drawing.Point(6, 116);
      this.tbMove.Name = "tbMove";
      this.tbMove.Size = new System.Drawing.Size(137, 20);
      this.tbMove.TabIndex = 12;
      this.tbMove.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMove_keyDown);
      this.tbMove.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbMove_KeyUp);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(55, 19);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(34, 23);
      this.button3.TabIndex = 7;
      this.button3.Text = "^";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.buttonForward_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(17, 48);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(34, 23);
      this.button4.TabIndex = 8;
      this.button4.Text = "<";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.buttonLeft_Click);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(92, 48);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(34, 23);
      this.button5.TabIndex = 9;
      this.button5.Text = ">";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.buttonRight_Click);
      // 
      // button7
      // 
      this.button7.Location = new System.Drawing.Point(55, 48);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(34, 23);
      this.button7.TabIndex = 11;
      this.button7.Text = "[]";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new System.EventHandler(this.buttonStop_Click);
      // 
      // tbHead
      // 
      this.tbHead.Location = new System.Drawing.Point(0, 17);
      this.tbHead.Maximum = 38;
      this.tbHead.Minimum = 1;
      this.tbHead.Name = "tbHead";
      this.tbHead.Size = new System.Drawing.Size(147, 45);
      this.tbHead.TabIndex = 33;
      this.tbHead.Value = 28;
      this.tbHead.Scroll += new System.EventHandler(this.tbHead_Scroll);
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(6, 46);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(473, 338);
      this.panel1.TabIndex = 34;
      // 
      // cbVideoDevices
      // 
      this.cbVideoDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbVideoDevices.FormattingEnabled = true;
      this.cbVideoDevices.Location = new System.Drawing.Point(6, 19);
      this.cbVideoDevices.Name = "cbVideoDevices";
      this.cbVideoDevices.Size = new System.Drawing.Size(205, 21);
      this.cbVideoDevices.TabIndex = 35;
      this.cbVideoDevices.SelectedIndexChanged += new System.EventHandler(this.cbVideoDevices_SelectedIndexChanged);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.tbHead);
      this.groupBox1.Location = new System.Drawing.Point(167, 40);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(153, 68);
      this.groupBox1.TabIndex = 36;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Head";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.btnRefreshCameraList);
      this.groupBox3.Controls.Add(this.panel1);
      this.groupBox3.Controls.Add(this.cbVideoDevices);
      this.groupBox3.Location = new System.Drawing.Point(326, 12);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(485, 390);
      this.groupBox3.TabIndex = 37;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Camera";
      // 
      // btnRefreshCameraList
      // 
      this.btnRefreshCameraList.Location = new System.Drawing.Point(217, 17);
      this.btnRefreshCameraList.Name = "btnRefreshCameraList";
      this.btnRefreshCameraList.Size = new System.Drawing.Size(75, 23);
      this.btnRefreshCameraList.TabIndex = 44;
      this.btnRefreshCameraList.Text = "Refresh";
      this.btnRefreshCameraList.UseVisualStyleBackColor = true;
      this.btnRefreshCameraList.Click += new System.EventHandler(this.btnRefreshCameraList_Click);
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.lbModes);
      this.groupBox4.Location = new System.Drawing.Point(12, 188);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(149, 187);
      this.groupBox4.TabIndex = 38;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Mode";
      // 
      // lbModes
      // 
      this.lbModes.FormattingEnabled = true;
      this.lbModes.Location = new System.Drawing.Point(13, 16);
      this.lbModes.Name = "lbModes";
      this.lbModes.Size = new System.Drawing.Size(120, 160);
      this.lbModes.TabIndex = 0;
      this.lbModes.SelectedIndexChanged += new System.EventHandler(this.lbModes_SelectedIndexChanged);
      // 
      // tbColorBrightness
      // 
      this.tbColorBrightness.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbColorBrightness.Location = new System.Drawing.Point(3, 16);
      this.tbColorBrightness.Maximum = 150;
      this.tbColorBrightness.Minimum = 25;
      this.tbColorBrightness.Name = "tbColorBrightness";
      this.tbColorBrightness.Size = new System.Drawing.Size(147, 45);
      this.tbColorBrightness.TabIndex = 36;
      this.tbColorBrightness.TickFrequency = 5;
      this.tbColorBrightness.Value = 70;
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.tbColorBrightness);
      this.groupBox5.Location = new System.Drawing.Point(167, 117);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(153, 59);
      this.groupBox5.TabIndex = 37;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Color Brightness";
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.tbMotionDifference);
      this.groupBox6.Location = new System.Drawing.Point(167, 182);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(153, 59);
      this.groupBox6.TabIndex = 39;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Motion Color Difference";
      // 
      // tbMotionDifference
      // 
      this.tbMotionDifference.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbMotionDifference.Location = new System.Drawing.Point(3, 16);
      this.tbMotionDifference.Maximum = 150;
      this.tbMotionDifference.Minimum = 25;
      this.tbMotionDifference.Name = "tbMotionDifference";
      this.tbMotionDifference.Size = new System.Drawing.Size(147, 45);
      this.tbMotionDifference.TabIndex = 36;
      this.tbMotionDifference.TickFrequency = 5;
      this.tbMotionDifference.Value = 45;
      // 
      // groupBox7
      // 
      this.groupBox7.Controls.Add(this.tbMotionCount);
      this.groupBox7.Location = new System.Drawing.Point(167, 247);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new System.Drawing.Size(153, 59);
      this.groupBox7.TabIndex = 40;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Motion Count";
      // 
      // tbMotionCount
      // 
      this.tbMotionCount.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbMotionCount.Location = new System.Drawing.Point(3, 16);
      this.tbMotionCount.Maximum = 150;
      this.tbMotionCount.Minimum = 25;
      this.tbMotionCount.Name = "tbMotionCount";
      this.tbMotionCount.Size = new System.Drawing.Size(147, 45);
      this.tbMotionCount.TabIndex = 36;
      this.tbMotionCount.TickFrequency = 5;
      this.tbMotionCount.Value = 30;
      // 
      // groupBox8
      // 
      this.groupBox8.Controls.Add(this.button8);
      this.groupBox8.Controls.Add(this.button2);
      this.groupBox8.Controls.Add(this.button1);
      this.groupBox8.Location = new System.Drawing.Point(12, 429);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new System.Drawing.Size(305, 51);
      this.groupBox8.TabIndex = 41;
      this.groupBox8.TabStop = false;
      this.groupBox8.Text = "Commands";
      // 
      // button8
      // 
      this.button8.Location = new System.Drawing.Point(168, 19);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(75, 23);
      this.button8.TabIndex = 45;
      this.button8.Text = "Snapshot";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new System.EventHandler(this.btnSnapshot_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(87, 19);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Eyes";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.btnEyes_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(6, 19);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Camera";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.btnCamera_Click);
      // 
      // groupBox9
      // 
      this.groupBox9.Controls.Add(this.lblPhrase);
      this.groupBox9.Location = new System.Drawing.Point(817, 12);
      this.groupBox9.Name = "groupBox9";
      this.groupBox9.Size = new System.Drawing.Size(160, 384);
      this.groupBox9.TabIndex = 42;
      this.groupBox9.TabStop = false;
      this.groupBox9.Text = "Phrase List";
      // 
      // lblPhrase
      // 
      this.lblPhrase.AutoSize = true;
      this.lblPhrase.Location = new System.Drawing.Point(3, 16);
      this.lblPhrase.Name = "lblPhrase";
      this.lblPhrase.Size = new System.Drawing.Size(35, 13);
      this.lblPhrase.TabIndex = 0;
      this.lblPhrase.Text = "label1";
      // 
      // lblDistance
      // 
      this.lblDistance.Location = new System.Drawing.Point(254, 390);
      this.lblDistance.Name = "lblDistance";
      this.lblDistance.Size = new System.Drawing.Size(48, 13);
      this.lblDistance.TabIndex = 1;
      this.lblDistance.Text = "label1";
      // 
      // lblCountDown
      // 
      this.lblCountDown.Location = new System.Drawing.Point(167, 390);
      this.lblCountDown.Name = "lblCountDown";
      this.lblCountDown.Size = new System.Drawing.Size(48, 13);
      this.lblCountDown.TabIndex = 43;
      this.lblCountDown.Text = "label1";
      // 
      // tbLog
      // 
      this.tbLog.BackColor = System.Drawing.Color.Black;
      this.tbLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbLog.ForeColor = System.Drawing.Color.Lime;
      this.tbLog.Location = new System.Drawing.Point(983, 21);
      this.tbLog.Multiline = true;
      this.tbLog.Name = "tbLog";
      this.tbLog.Size = new System.Drawing.Size(245, 411);
      this.tbLog.TabIndex = 44;
      // 
      // cbFreezeMode
      // 
      this.cbFreezeMode.AutoSize = true;
      this.cbFreezeMode.Checked = true;
      this.cbFreezeMode.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbFreezeMode.Location = new System.Drawing.Point(170, 409);
      this.cbFreezeMode.Name = "cbFreezeMode";
      this.cbFreezeMode.Size = new System.Drawing.Size(88, 17);
      this.cbFreezeMode.TabIndex = 13;
      this.cbFreezeMode.Text = "Freeze Mode";
      this.cbFreezeMode.UseVisualStyleBackColor = true;
      // 
      // groupBox10
      // 
      this.groupBox10.Controls.Add(this.tbScanServo);
      this.groupBox10.Location = new System.Drawing.Point(167, 309);
      this.groupBox10.Name = "groupBox10";
      this.groupBox10.Size = new System.Drawing.Size(153, 59);
      this.groupBox10.TabIndex = 45;
      this.groupBox10.TabStop = false;
      this.groupBox10.Text = "Sensor Position";
      // 
      // tbScanServo
      // 
      this.tbScanServo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbScanServo.LargeChange = 1;
      this.tbScanServo.Location = new System.Drawing.Point(3, 16);
      this.tbScanServo.Maximum = 38;
      this.tbScanServo.Minimum = 1;
      this.tbScanServo.Name = "tbScanServo";
      this.tbScanServo.Size = new System.Drawing.Size(147, 45);
      this.tbScanServo.TabIndex = 36;
      this.tbScanServo.Value = 18;
      this.tbScanServo.Scroll += new System.EventHandler(this.tbScanServo_Change);
      // 
      // groupBox11
      // 
      this.groupBox11.Controls.Add(this.btnRefreshJoystick);
      this.groupBox11.Controls.Add(this.textBox1);
      this.groupBox11.Location = new System.Drawing.Point(332, 409);
      this.groupBox11.Name = "groupBox11";
      this.groupBox11.Size = new System.Drawing.Size(296, 46);
      this.groupBox11.TabIndex = 46;
      this.groupBox11.TabStop = false;
      this.groupBox11.Text = "Joystick";
      // 
      // btnRefreshJoystick
      // 
      this.btnRefreshJoystick.Location = new System.Drawing.Point(215, 14);
      this.btnRefreshJoystick.Name = "btnRefreshJoystick";
      this.btnRefreshJoystick.Size = new System.Drawing.Size(75, 23);
      this.btnRefreshJoystick.TabIndex = 1;
      this.btnRefreshJoystick.Text = "Refresh";
      this.btnRefreshJoystick.UseVisualStyleBackColor = true;
      this.btnRefreshJoystick.Click += new System.EventHandler(this.btnRefreshJoystick_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(6, 16);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(203, 20);
      this.textBox1.TabIndex = 0;
      // 
      // ezb
      // 
      this.ezbConnect.Location = new System.Drawing.Point(0, 0);
      this.ezbConnect.Name = "ezb";
      this.ezbConnect.Port = "";
      this.ezbConnect.ShowDebugButton = true;
      this.ezbConnect.Size = new System.Drawing.Size(283, 31);
      this.ezbConnect.TabIndex = 0;
      this.ezbConnect.OnConnection += new EZ_B.UCEZB_Connect.OnConnectionHandler(this.ezB_Connect1_OnConnection);
      // 
      // cbListen
      // 
      this.cbListen.AutoSize = true;
      this.cbListen.Checked = true;
      this.cbListen.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbListen.Location = new System.Drawing.Point(817, 402);
      this.cbListen.Name = "cbListen";
      this.cbListen.Size = new System.Drawing.Size(93, 17);
      this.cbListen.TabIndex = 2;
      this.cbListen.Text = "Stop Listening\r\n";
      this.cbListen.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1240, 503);
      this.Controls.Add(this.cbListen);
      this.Controls.Add(this.groupBox11);
      this.Controls.Add(this.groupBox10);
      this.Controls.Add(this.cbFreezeMode);
      this.Controls.Add(this.tbLog);
      this.Controls.Add(this.lblCountDown);
      this.Controls.Add(this.lblDistance);
      this.Controls.Add(this.groupBox9);
      this.Controls.Add(this.groupBox8);
      this.Controls.Add(this.groupBox7);
      this.Controls.Add(this.groupBox6);
      this.Controls.Add(this.groupBox5);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.ezbConnect);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbHead)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.tbColorBrightness)).EndInit();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbMotionDifference)).EndInit();
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbMotionCount)).EndInit();
      this.groupBox8.ResumeLayout(false);
      this.groupBox9.ResumeLayout(false);
      this.groupBox9.PerformLayout();
      this.groupBox10.ResumeLayout(false);
      this.groupBox10.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tbScanServo)).EndInit();
      this.groupBox11.ResumeLayout(false);
      this.groupBox11.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private EZ_B.UCEZB_Connect ezbConnect;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.TrackBar tbHead;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ComboBox cbVideoDevices;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.ListBox lbModes;
    private System.Windows.Forms.TrackBar tbColorBrightness;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.TrackBar tbMotionDifference;
    private System.Windows.Forms.GroupBox groupBox7;
    private System.Windows.Forms.TrackBar tbMotionCount;
    private System.Windows.Forms.GroupBox groupBox8;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox tbMove;
    private System.Windows.Forms.GroupBox groupBox9;
    private System.Windows.Forms.Label lblPhrase;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label lblDistance;
    private System.Windows.Forms.Label lblCountDown;
    private System.Windows.Forms.Button btnRefreshCameraList;
    private System.Windows.Forms.TextBox tbLog;
    private System.Windows.Forms.CheckBox cbFreezeMode;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.CheckBox cbStop;
    private System.Windows.Forms.GroupBox groupBox10;
    private System.Windows.Forms.TrackBar tbScanServo;
    private System.Windows.Forms.GroupBox groupBox11;
    private System.Windows.Forms.Button btnRefreshJoystick;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.CheckBox cbListen;
  }
}

