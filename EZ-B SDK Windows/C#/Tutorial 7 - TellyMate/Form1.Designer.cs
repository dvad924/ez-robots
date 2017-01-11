namespace Tutorial_7___TellyMate {
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.btnSend = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lbGraphics = new System.Windows.Forms.ListBox();
      this.button6 = new System.Windows.Forms.Button();
      this.lbCommands = new System.Windows.Forms.ListBox();
      this.lbFontAttrib = new System.Windows.Forms.ListBox();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.ezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(19, 18);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 1;
      this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
      // 
      // btnSend
      // 
      this.btnSend.Location = new System.Drawing.Point(125, 16);
      this.btnSend.Name = "btnSend";
      this.btnSend.Size = new System.Drawing.Size(75, 23);
      this.btnSend.TabIndex = 2;
      this.btnSend.Text = "Send";
      this.btnSend.UseVisualStyleBackColor = true;
      this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.lbGraphics);
      this.panel1.Controls.Add(this.button6);
      this.panel1.Controls.Add(this.lbCommands);
      this.panel1.Controls.Add(this.lbFontAttrib);
      this.panel1.Controls.Add(this.button4);
      this.panel1.Controls.Add(this.button3);
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.btnSend);
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Location = new System.Drawing.Point(12, 41);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(849, 255);
      this.panel1.TabIndex = 3;
      // 
      // lbGraphics
      // 
      this.lbGraphics.FormattingEnabled = true;
      this.lbGraphics.Location = new System.Drawing.Point(628, 18);
      this.lbGraphics.Name = "lbGraphics";
      this.lbGraphics.Size = new System.Drawing.Size(205, 225);
      this.lbGraphics.TabIndex = 13;
      this.lbGraphics.SelectedIndexChanged += new System.EventHandler(this.lbGraphics_SelectedIndexChanged);
      // 
      // button6
      // 
      this.button6.Location = new System.Drawing.Point(125, 45);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(75, 23);
      this.button6.TabIndex = 10;
      this.button6.Text = "Random";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // lbCommands
      // 
      this.lbCommands.FormattingEnabled = true;
      this.lbCommands.Location = new System.Drawing.Point(417, 18);
      this.lbCommands.Name = "lbCommands";
      this.lbCommands.Size = new System.Drawing.Size(205, 225);
      this.lbCommands.TabIndex = 9;
      this.lbCommands.SelectedIndexChanged += new System.EventHandler(this.lbCommands_SelectedIndexChanged);
      // 
      // lbFontAttrib
      // 
      this.lbFontAttrib.FormattingEnabled = true;
      this.lbFontAttrib.Location = new System.Drawing.Point(206, 18);
      this.lbFontAttrib.Name = "lbFontAttrib";
      this.lbFontAttrib.Size = new System.Drawing.Size(205, 225);
      this.lbFontAttrib.TabIndex = 8;
      this.lbFontAttrib.SelectedIndexChanged += new System.EventHandler(this.lbFontAttrib_SelectedIndexChanged);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(45, 102);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(30, 23);
      this.button4.TabIndex = 6;
      this.button4.Text = "_";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(9, 77);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(30, 23);
      this.button3.TabIndex = 5;
      this.button3.Text = "<";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(81, 77);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(30, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = ">";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(45, 57);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(30, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "^";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // ezB_Connect1
      // 
      this.ezB_Connect1.Location = new System.Drawing.Point(12, 4);
      this.ezB_Connect1.Name = "ezB_Connect1";
      this.ezB_Connect1.Size = new System.Drawing.Size(283, 31);
      this.ezB_Connect1.TabIndex = 14;
      this.ezB_Connect1.OnConnection += new EZ_B.UCEZB_Connect.OnConnectionHandler(this.ezB_Connect1_OnConnection);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(873, 308);
      this.Controls.Add(this.ezB_Connect1);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "Tutorial 7";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button btnSend;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ListBox lbFontAttrib;
    private System.Windows.Forms.ListBox lbCommands;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.ListBox lbGraphics;
    private EZ_B.UCEZB_Connect ezB_Connect1;
  }
}

