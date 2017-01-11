namespace Tutorial_40___Speech_Recognition_Grammar {
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
      this.tbResponses = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.tbNouns = new System.Windows.Forms.TextBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.tbVerbs = new System.Windows.Forms.TextBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.tbAdjectives = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.tbResults = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.ezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.tbNames = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.SuspendLayout();
      // 
      // tbResponses
      // 
      this.tbResponses.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbResponses.Location = new System.Drawing.Point(3, 16);
      this.tbResponses.Multiline = true;
      this.tbResponses.Name = "tbResponses";
      this.tbResponses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbResponses.Size = new System.Drawing.Size(453, 126);
      this.tbResponses.TabIndex = 1;
      this.tbResponses.Text = resources.GetString("tbResponses.Text");
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.tbResponses);
      this.groupBox1.Location = new System.Drawing.Point(12, 37);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(459, 145);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Responses";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.tbNouns);
      this.groupBox2.Location = new System.Drawing.Point(12, 188);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(149, 145);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Nouns";
      // 
      // tbNouns
      // 
      this.tbNouns.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbNouns.Location = new System.Drawing.Point(3, 16);
      this.tbNouns.Multiline = true;
      this.tbNouns.Name = "tbNouns";
      this.tbNouns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbNouns.Size = new System.Drawing.Size(143, 126);
      this.tbNouns.TabIndex = 1;
      this.tbNouns.Text = "cat\r\ndog\r\nhill\r\nhouse\r\nmountain\r\nbird\r\nlion";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.tbVerbs);
      this.groupBox3.Location = new System.Drawing.Point(167, 188);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(149, 145);
      this.groupBox3.TabIndex = 4;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Verbs";
      // 
      // tbVerbs
      // 
      this.tbVerbs.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbVerbs.Location = new System.Drawing.Point(3, 16);
      this.tbVerbs.Multiline = true;
      this.tbVerbs.Name = "tbVerbs";
      this.tbVerbs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbVerbs.Size = new System.Drawing.Size(143, 126);
      this.tbVerbs.TabIndex = 1;
      this.tbVerbs.Text = "ran\r\nwalked\r\nslept\r\nflew\r\ndrove\r\nhitch hiked";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.tbAdjectives);
      this.groupBox4.Location = new System.Drawing.Point(322, 188);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(149, 145);
      this.groupBox4.TabIndex = 5;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Adjectives";
      // 
      // tbAdjectives
      // 
      this.tbAdjectives.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbAdjectives.Location = new System.Drawing.Point(3, 16);
      this.tbAdjectives.Multiline = true;
      this.tbAdjectives.Name = "tbAdjectives";
      this.tbAdjectives.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbAdjectives.Size = new System.Drawing.Size(143, 126);
      this.tbAdjectives.TabIndex = 1;
      this.tbAdjectives.Text = "fast\r\nquickly\r\nslow\r\nred\r\ngreen\r\nblue\r\npurple\r\n\r\n";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(474, 42);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 40);
      this.button1.TabIndex = 6;
      this.button1.Text = "Start Listening";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.tbResults);
      this.groupBox5.Controls.Add(this.textBox1);
      this.groupBox5.Location = new System.Drawing.Point(477, 88);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(460, 237);
      this.groupBox5.TabIndex = 7;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Recognized Speech Results";
      // 
      // tbResults
      // 
      this.tbResults.BackColor = System.Drawing.Color.Black;
      this.tbResults.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbResults.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbResults.ForeColor = System.Drawing.Color.Lime;
      this.tbResults.Location = new System.Drawing.Point(3, 16);
      this.tbResults.Multiline = true;
      this.tbResults.Name = "tbResults";
      this.tbResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbResults.Size = new System.Drawing.Size(454, 198);
      this.tbResults.TabIndex = 1;
      // 
      // textBox1
      // 
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.textBox1.Location = new System.Drawing.Point(3, 214);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(454, 20);
      this.textBox1.TabIndex = 9;
      this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
      // 
      // ezB_Connect1
      // 
      this.ezB_Connect1.Location = new System.Drawing.Point(0, 0);
      this.ezB_Connect1.Name = "ezB_Connect1";
      this.ezB_Connect1.Port = "";
      this.ezB_Connect1.ShowDebugButton = true;
      this.ezB_Connect1.Size = new System.Drawing.Size(283, 31);
      this.ezB_Connect1.TabIndex = 0;
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.tbNames);
      this.groupBox6.Location = new System.Drawing.Point(12, 336);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(149, 145);
      this.groupBox6.TabIndex = 8;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "People";
      // 
      // tbNames
      // 
      this.tbNames.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbNames.Location = new System.Drawing.Point(3, 16);
      this.tbNames.Multiline = true;
      this.tbNames.Name = "tbNames";
      this.tbNames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbNames.Size = new System.Drawing.Size(143, 126);
      this.tbNames.TabIndex = 1;
      this.tbNames.Text = "ran\r\nwalked\r\nslept\r\nflew\r\ndrove\r\nhitch hiked";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(949, 476);
      this.Controls.Add(this.groupBox6);
      this.Controls.Add(this.groupBox5);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.ezB_Connect1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private EZ_B.UCEZB_Connect ezB_Connect1;
    private System.Windows.Forms.TextBox tbResponses;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox tbNouns;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TextBox tbVerbs;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.TextBox tbAdjectives;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.TextBox tbResults;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.TextBox tbNames;
    private System.Windows.Forms.TextBox textBox1;
  }
}

