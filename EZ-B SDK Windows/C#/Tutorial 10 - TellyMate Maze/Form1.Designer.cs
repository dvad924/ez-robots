namespace Tutorial_10___TellyMate_Maze {
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.button5 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.cbMap = new System.Windows.Forms.ComboBox();
      this.ezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Controls.Add(this.textBox2);
      this.panel1.Controls.Add(this.button5);
      this.panel1.Controls.Add(this.button4);
      this.panel1.Controls.Add(this.button3);
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.cbMap);
      this.panel1.Location = new System.Drawing.Point(12, 41);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(795, 347);
      this.panel1.TabIndex = 1;
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.Black;
      this.textBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.textBox1.Location = new System.Drawing.Point(3, 40);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(673, 301);
      this.textBox1.TabIndex = 7;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(546, 14);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(130, 20);
      this.textBox2.TabIndex = 6;
      this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button2_KeyUp);
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(718, 65);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(30, 23);
      this.button5.TabIndex = 5;
      this.button5.Text = "v";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      this.button5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button2_KeyUp);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(754, 37);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(30, 23);
      this.button4.TabIndex = 4;
      this.button4.Text = ">";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      this.button4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button2_KeyUp);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(682, 37);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(30, 23);
      this.button3.TabIndex = 3;
      this.button3.Text = "<";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      this.button3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button2_KeyUp);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(718, 14);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(30, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "^";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      this.button2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button2_KeyUp);
      // 
      // cbMap
      // 
      this.cbMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbMap.FormattingEnabled = true;
      this.cbMap.Location = new System.Drawing.Point(13, 16);
      this.cbMap.Name = "cbMap";
      this.cbMap.Size = new System.Drawing.Size(121, 21);
      this.cbMap.TabIndex = 1;
      this.cbMap.SelectedIndexChanged += new System.EventHandler(this.cbMap_SelectedIndexChanged);
      // 
      // ezB_Connect1
      // 
      this.ezB_Connect1.Location = new System.Drawing.Point(12, 4);
      this.ezB_Connect1.Name = "ezB_Connect1";
      this.ezB_Connect1.Size = new System.Drawing.Size(283, 31);
      this.ezB_Connect1.TabIndex = 8;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(819, 391);
      this.Controls.Add(this.ezB_Connect1);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.ComboBox cbMap;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
    private EZ_B.UCEZB_Connect ezB_Connect1;
  }
}

