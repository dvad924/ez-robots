namespace Tutorial_19___Roomba {
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
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.button9 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.ezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.trackBar1);
      this.groupBox1.Controls.Add(this.checkBox1);
      this.groupBox1.Controls.Add(this.button9);
      this.groupBox1.Controls.Add(this.button8);
      this.groupBox1.Controls.Add(this.button7);
      this.groupBox1.Controls.Add(this.button6);
      this.groupBox1.Controls.Add(this.button5);
      this.groupBox1.Controls.Add(this.button4);
      this.groupBox1.Controls.Add(this.button3);
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Location = new System.Drawing.Point(21, 94);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(325, 183);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Roomba Controls";
      // 
      // trackBar1
      // 
      this.trackBar1.Location = new System.Drawing.Point(197, 132);
      this.trackBar1.Maximum = 200;
      this.trackBar1.Minimum = 1;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(104, 45);
      this.trackBar1.SmallChange = 10;
      this.trackBar1.TabIndex = 11;
      this.trackBar1.TickFrequency = 10;
      this.trackBar1.Value = 200;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(6, 154);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(75, 17);
      this.checkBox1.TabIndex = 10;
      this.checkBox1.Text = "Flash LED";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // button9
      // 
      this.button9.Location = new System.Drawing.Point(235, 77);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(27, 23);
      this.button9.TabIndex = 8;
      this.button9.Text = "Turn Off";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Click += new System.EventHandler(this.button9_Click);
      // 
      // button8
      // 
      this.button8.Location = new System.Drawing.Point(260, 48);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(27, 23);
      this.button8.TabIndex = 7;
      this.button8.Text = "Turn Off";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new System.EventHandler(this.button8_Click);
      // 
      // button7
      // 
      this.button7.Location = new System.Drawing.Point(212, 48);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(27, 23);
      this.button7.TabIndex = 6;
      this.button7.Text = "Turn Off";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new System.EventHandler(this.button7_Click);
      // 
      // button6
      // 
      this.button6.Location = new System.Drawing.Point(235, 19);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(27, 23);
      this.button6.TabIndex = 5;
      this.button6.Text = "Turn Off";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(223, 103);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(50, 23);
      this.button5.TabIndex = 4;
      this.button5.Text = "Stop";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(102, 70);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(75, 23);
      this.button4.TabIndex = 3;
      this.button4.Text = "Play Song";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(6, 70);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "Spot Clean";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(6, 29);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Turn Off";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // ezB_Connect1
      // 
      this.ezB_Connect1.Location = new System.Drawing.Point(0, 0);
      this.ezB_Connect1.Name = "ezB_Connect1";
      this.ezB_Connect1.ShowDebugButton = true;
      this.ezB_Connect1.Size = new System.Drawing.Size(283, 31);
      this.ezB_Connect1.TabIndex = 0;
      this.ezB_Connect1.OnConnection += new EZ_B.UCEZB_Connect.OnConnectionHandler(this.ezB_Connect1_OnConnection);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(372, 337);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.ezB_Connect1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private EZ_B.UCEZB_Connect ezB_Connect1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.TrackBar trackBar1;
  }
}

