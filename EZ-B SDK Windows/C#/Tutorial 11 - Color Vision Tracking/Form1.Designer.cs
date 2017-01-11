namespace Tutorial_11___Follow_Red_Object {
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label7 = new System.Windows.Forms.Label();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.cbPreviewDetect = new System.Windows.Forms.CheckBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.scLumMin = new AForge.Controls.SliderControl();
      this.scLumMax = new AForge.Controls.SliderControl();
      this.scSatMax = new AForge.Controls.SliderControl();
      this.scSatMin = new AForge.Controls.SliderControl();
      this.huePicker1 = new AForge.Controls.HuePicker();
      this.label3 = new System.Windows.Forms.Label();
      this.tbMinObjectSize = new System.Windows.Forms.TrackBar();
      this.panel2 = new System.Windows.Forms.Panel();
      this.tbLog = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.ezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbMinObjectSize)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.trackBar1);
      this.groupBox1.Controls.Add(this.cbPreviewDetect);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.scLumMin);
      this.groupBox1.Controls.Add(this.scLumMax);
      this.groupBox1.Controls.Add(this.scSatMax);
      this.groupBox1.Controls.Add(this.scSatMin);
      this.groupBox1.Controls.Add(this.huePicker1);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.tbMinObjectSize);
      this.groupBox1.Controls.Add(this.panel2);
      this.groupBox1.Controls.Add(this.tbLog);
      this.groupBox1.Controls.Add(this.panel1);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.comboBox1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(0, 31);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1336, 702);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Commands";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(820, 174);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(56, 13);
      this.label7.TabIndex = 22;
      this.label7.Text = "Brightness";
      // 
      // trackBar1
      // 
      this.trackBar1.LargeChange = 25;
      this.trackBar1.Location = new System.Drawing.Point(738, 142);
      this.trackBar1.Maximum = 200;
      this.trackBar1.Minimum = 1;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(220, 45);
      this.trackBar1.SmallChange = 25;
      this.trackBar1.TabIndex = 21;
      this.trackBar1.TickFrequency = 25;
      this.trackBar1.Value = 100;
      // 
      // cbPreviewDetect
      // 
      this.cbPreviewDetect.AutoSize = true;
      this.cbPreviewDetect.Location = new System.Drawing.Point(738, 314);
      this.cbPreviewDetect.Name = "cbPreviewDetect";
      this.cbPreviewDetect.Size = new System.Drawing.Size(113, 17);
      this.cbPreviewDetect.TabIndex = 20;
      this.cbPreviewDetect.Text = "Preview Detection";
      this.cbPreviewDetect.UseVisualStyleBackColor = true;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(1023, 364);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(82, 13);
      this.label6.TabIndex = 19;
      this.label6.Text = "Luminance Max";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(1026, 334);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(79, 13);
      this.label5.TabIndex = 18;
      this.label5.Text = "Luminance Min";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(1026, 284);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(78, 13);
      this.label4.TabIndex = 17;
      this.label4.Text = "Saturation Max";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(1029, 257);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(75, 13);
      this.label2.TabIndex = 16;
      this.label2.Text = "Saturation Min";
      // 
      // scLumMin
      // 
      this.scLumMin.Location = new System.Drawing.Point(1110, 332);
      this.scLumMin.Name = "scLumMin";
      this.scLumMin.Size = new System.Drawing.Size(144, 23);
      this.scLumMin.TabIndex = 15;
      this.scLumMin.Text = "sliderControl3";
      this.scLumMin.Value = 0F;
      // 
      // scLumMax
      // 
      this.scLumMax.Location = new System.Drawing.Point(1110, 361);
      this.scLumMax.Name = "scLumMax";
      this.scLumMax.Size = new System.Drawing.Size(144, 23);
      this.scLumMax.TabIndex = 14;
      this.scLumMax.Text = "sliderControl4";
      this.scLumMax.Value = 0F;
      // 
      // scSatMax
      // 
      this.scSatMax.Location = new System.Drawing.Point(1110, 282);
      this.scSatMax.Name = "scSatMax";
      this.scSatMax.Size = new System.Drawing.Size(144, 23);
      this.scSatMax.TabIndex = 13;
      this.scSatMax.Text = "sliderControl2";
      this.scSatMax.Value = 0F;
      // 
      // scSatMin
      // 
      this.scSatMin.Location = new System.Drawing.Point(1110, 253);
      this.scSatMin.Name = "scSatMin";
      this.scSatMin.Size = new System.Drawing.Size(144, 23);
      this.scSatMin.TabIndex = 4;
      this.scSatMin.Text = "sliderControl1";
      this.scSatMin.Value = 0F;
      // 
      // huePicker1
      // 
      this.huePicker1.Location = new System.Drawing.Point(1076, 9);
      this.huePicker1.Name = "huePicker1";
      this.huePicker1.Size = new System.Drawing.Size(209, 209);
      this.huePicker1.TabIndex = 11;
      this.huePicker1.Text = "huePicker1";
      this.huePicker1.Type = AForge.Controls.HuePicker.HuePickerType.Range;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(809, 77);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(81, 13);
      this.label3.TabIndex = 10;
      this.label3.Text = "Min Object Size";
      // 
      // tbMinObjectSize
      // 
      this.tbMinObjectSize.LargeChange = 25;
      this.tbMinObjectSize.Location = new System.Drawing.Point(738, 45);
      this.tbMinObjectSize.Maximum = 200;
      this.tbMinObjectSize.Minimum = 1;
      this.tbMinObjectSize.Name = "tbMinObjectSize";
      this.tbMinObjectSize.Size = new System.Drawing.Size(220, 45);
      this.tbMinObjectSize.SmallChange = 25;
      this.tbMinObjectSize.TabIndex = 9;
      this.tbMinObjectSize.TickFrequency = 25;
      this.tbMinObjectSize.Value = 100;
      // 
      // panel2
      // 
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel2.Location = new System.Drawing.Point(386, 45);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(346, 286);
      this.panel2.TabIndex = 7;
      // 
      // tbLog
      // 
      this.tbLog.BackColor = System.Drawing.Color.Black;
      this.tbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.tbLog.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.tbLog.Location = new System.Drawing.Point(3, 446);
      this.tbLog.Multiline = true;
      this.tbLog.Name = "tbLog";
      this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.tbLog.Size = new System.Drawing.Size(1330, 253);
      this.tbLog.TabIndex = 3;
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel1.Location = new System.Drawing.Point(9, 45);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(371, 286);
      this.panel1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(71, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Video Device";
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(80, 18);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(205, 21);
      this.comboBox1.TabIndex = 0;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // ezB_Connect1
      // 
      this.ezB_Connect1.Dock = System.Windows.Forms.DockStyle.Top;
      this.ezB_Connect1.Location = new System.Drawing.Point(0, 0);
      this.ezB_Connect1.Name = "ezB_Connect1";
      this.ezB_Connect1.Port = "COM7";
      this.ezB_Connect1.ShowDebugButton = true;
      this.ezB_Connect1.Size = new System.Drawing.Size(1336, 31);
      this.ezB_Connect1.TabIndex = 3;
      this.ezB_Connect1.TCPPassword = null;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(1336, 733);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.ezB_Connect1);
      this.Name = "Form1";
      this.Text = "Tutorial 11 - Follow Camera Object";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbMinObjectSize)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox tbLog;
    private System.Windows.Forms.Panel panel2;
    private EZ_B.UCEZB_Connect ezB_Connect1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TrackBar tbMinObjectSize;
    private AForge.Controls.HuePicker huePicker1;
    private AForge.Controls.SliderControl scSatMax;
    private AForge.Controls.SliderControl scSatMin;
    private AForge.Controls.SliderControl scLumMin;
    private AForge.Controls.SliderControl scLumMax;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.CheckBox cbPreviewDetect;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TrackBar trackBar1;
  }
}

