namespace Tutorial_55___Sphero {
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
      this.cbPorts = new System.Windows.Forms.ComboBox();
      this.btnConnect = new System.Windows.Forms.Button();
      this.gbSpheroConnection = new System.Windows.Forms.GroupBox();
      this.gbSpheroCommands = new System.Windows.Forms.GroupBox();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.huePicker1 = new AForge.Controls.HuePicker();
      this.button3 = new System.Windows.Forms.Button();
      this.gbSpheroConnection.SuspendLayout();
      this.gbSpheroCommands.SuspendLayout();
      this.SuspendLayout();
      // 
      // cbPorts
      // 
      this.cbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbPorts.FormattingEnabled = true;
      this.cbPorts.Location = new System.Drawing.Point(10, 21);
      this.cbPorts.Name = "cbPorts";
      this.cbPorts.Size = new System.Drawing.Size(121, 21);
      this.cbPorts.TabIndex = 0;
      // 
      // btnConnect
      // 
      this.btnConnect.Location = new System.Drawing.Point(137, 21);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(75, 23);
      this.btnConnect.TabIndex = 1;
      this.btnConnect.Text = "button1";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
      // 
      // gbSpheroConnection
      // 
      this.gbSpheroConnection.Controls.Add(this.btnConnect);
      this.gbSpheroConnection.Controls.Add(this.cbPorts);
      this.gbSpheroConnection.Location = new System.Drawing.Point(12, 12);
      this.gbSpheroConnection.Name = "gbSpheroConnection";
      this.gbSpheroConnection.Size = new System.Drawing.Size(222, 57);
      this.gbSpheroConnection.TabIndex = 2;
      this.gbSpheroConnection.TabStop = false;
      this.gbSpheroConnection.Text = "Sphero Connection";
      // 
      // gbSpheroCommands
      // 
      this.gbSpheroCommands.Controls.Add(this.button3);
      this.gbSpheroCommands.Controls.Add(this.button2);
      this.gbSpheroCommands.Controls.Add(this.button1);
      this.gbSpheroCommands.Controls.Add(this.textBox1);
      this.gbSpheroCommands.Controls.Add(this.huePicker1);
      this.gbSpheroCommands.Location = new System.Drawing.Point(12, 75);
      this.gbSpheroCommands.Name = "gbSpheroCommands";
      this.gbSpheroCommands.Size = new System.Drawing.Size(651, 349);
      this.gbSpheroCommands.TabIndex = 3;
      this.gbSpheroCommands.TabStop = false;
      this.gbSpheroCommands.Text = "Sphero Control";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(56, 206);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 6;
      this.button2.Text = "Stop";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(56, 177);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "Forward";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(249, 76);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(370, 228);
      this.textBox1.TabIndex = 4;
      // 
      // huePicker1
      // 
      this.huePicker1.Location = new System.Drawing.Point(6, 19);
      this.huePicker1.Name = "huePicker1";
      this.huePicker1.Size = new System.Drawing.Size(154, 152);
      this.huePicker1.TabIndex = 0;
      this.huePicker1.Text = "huePicker1";
      this.huePicker1.ValuesChanged += new System.EventHandler(this.huePicker1_ValuesChanged);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(147, 177);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 7;
      this.button3.Text = "button3";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(729, 448);
      this.Controls.Add(this.gbSpheroCommands);
      this.Controls.Add(this.gbSpheroConnection);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.gbSpheroConnection.ResumeLayout(false);
      this.gbSpheroCommands.ResumeLayout(false);
      this.gbSpheroCommands.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox cbPorts;
    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.GroupBox gbSpheroConnection;
    private System.Windows.Forms.GroupBox gbSpheroCommands;
    private AForge.Controls.HuePicker huePicker1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button3;
  }
}

