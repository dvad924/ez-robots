namespace Tutorial_25___ITG_3200 {
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
      this.ezB_Connect1 = new EZ_B.UCEZB_Connect();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lblZ = new System.Windows.Forms.Label();
      this.lblY = new System.Windows.Forms.Label();
      this.lblX = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.SuspendLayout();
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
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 75);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(260, 175);
      this.textBox1.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(91, 48);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "Init";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(183, 52);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(78, 17);
      this.checkBox1.TabIndex = 4;
      this.checkBox1.Text = "Get Values";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(279, 75);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(32, 25);
      this.label1.TabIndex = 5;
      this.label1.Text = "X:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(279, 100);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(33, 25);
      this.label2.TabIndex = 6;
      this.label2.Text = "Y:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(279, 125);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 25);
      this.label3.TabIndex = 7;
      this.label3.Text = "Z:";
      // 
      // lblZ
      // 
      this.lblZ.AutoSize = true;
      this.lblZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblZ.Location = new System.Drawing.Point(317, 125);
      this.lblZ.Name = "lblZ";
      this.lblZ.Size = new System.Drawing.Size(70, 25);
      this.lblZ.TabIndex = 10;
      this.lblZ.Text = "label4";
      // 
      // lblY
      // 
      this.lblY.AutoSize = true;
      this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblY.Location = new System.Drawing.Point(317, 100);
      this.lblY.Name = "lblY";
      this.lblY.Size = new System.Drawing.Size(70, 25);
      this.lblY.TabIndex = 9;
      this.lblY.Text = "label5";
      // 
      // lblX
      // 
      this.lblX.AutoSize = true;
      this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblX.Location = new System.Drawing.Point(317, 75);
      this.lblX.Name = "lblX";
      this.lblX.Size = new System.Drawing.Size(70, 25);
      this.lblX.TabIndex = 8;
      this.lblX.Text = "label6";
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(393, 75);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(255, 255);
      this.panel1.TabIndex = 11;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(655, 338);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.lblZ);
      this.Controls.Add(this.lblY);
      this.Controls.Add(this.lblX);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.ezB_Connect1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private EZ_B.UCEZB_Connect ezB_Connect1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblZ;
    private System.Windows.Forms.Label lblY;
    private System.Windows.Forms.Label lblX;
    private System.Windows.Forms.Panel panel1;
  }
}

