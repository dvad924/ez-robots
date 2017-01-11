namespace Tutorial_44___Haar_Trainer {
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
      this.cbVideoDevices = new System.Windows.Forms.ComboBox();
      this.btnRefreshDevices = new System.Windows.Forms.Button();
      this.pnlPreview = new System.Windows.Forms.Panel();
      this.lblProjectFolder = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.btnCreatePositive = new System.Windows.Forms.Button();
      this.lblPositiveCount = new System.Windows.Forms.Label();
      this.lblNegativeCount = new System.Windows.Forms.Label();
      this.btnCreateNegative = new System.Windows.Forms.Button();
      this.tbLog = new System.Windows.Forms.TextBox();
      this.btnCreateHAAR = new System.Windows.Forms.Button();
      this.btnClearLog = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cbVideoDevices
      // 
      this.cbVideoDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbVideoDevices.FormattingEnabled = true;
      this.cbVideoDevices.Location = new System.Drawing.Point(3, 10);
      this.cbVideoDevices.Name = "cbVideoDevices";
      this.cbVideoDevices.Size = new System.Drawing.Size(144, 21);
      this.cbVideoDevices.TabIndex = 0;
      this.cbVideoDevices.SelectedIndexChanged += new System.EventHandler(this.cbVideoDevices_SelectedIndexChanged);
      // 
      // btnRefreshDevices
      // 
      this.btnRefreshDevices.Location = new System.Drawing.Point(153, 8);
      this.btnRefreshDevices.Name = "btnRefreshDevices";
      this.btnRefreshDevices.Size = new System.Drawing.Size(75, 23);
      this.btnRefreshDevices.TabIndex = 1;
      this.btnRefreshDevices.Text = "Refresh List";
      this.btnRefreshDevices.UseVisualStyleBackColor = true;
      // 
      // pnlPreview
      // 
      this.pnlPreview.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlPreview.Location = new System.Drawing.Point(0, 0);
      this.pnlPreview.Name = "pnlPreview";
      this.pnlPreview.Size = new System.Drawing.Size(611, 403);
      this.pnlPreview.TabIndex = 2;
      // 
      // lblProjectFolder
      // 
      this.lblProjectFolder.AutoSize = true;
      this.lblProjectFolder.Location = new System.Drawing.Point(127, 42);
      this.lblProjectFolder.Name = "lblProjectFolder";
      this.lblProjectFolder.Size = new System.Drawing.Size(29, 13);
      this.lblProjectFolder.TabIndex = 3;
      this.lblProjectFolder.Text = "label";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(3, 37);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(118, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "Project Folder";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnCreatePositive
      // 
      this.btnCreatePositive.Enabled = false;
      this.btnCreatePositive.Location = new System.Drawing.Point(3, 66);
      this.btnCreatePositive.Name = "btnCreatePositive";
      this.btnCreatePositive.Size = new System.Drawing.Size(118, 23);
      this.btnCreatePositive.TabIndex = 5;
      this.btnCreatePositive.Text = "Save As Positive";
      this.btnCreatePositive.UseVisualStyleBackColor = true;
      this.btnCreatePositive.Click += new System.EventHandler(this.btnCreatePositive_Click);
      // 
      // lblPositiveCount
      // 
      this.lblPositiveCount.AutoSize = true;
      this.lblPositiveCount.Location = new System.Drawing.Point(127, 71);
      this.lblPositiveCount.Name = "lblPositiveCount";
      this.lblPositiveCount.Size = new System.Drawing.Size(29, 13);
      this.lblPositiveCount.TabIndex = 7;
      this.lblPositiveCount.Text = "label";
      // 
      // lblNegativeCount
      // 
      this.lblNegativeCount.AutoSize = true;
      this.lblNegativeCount.Location = new System.Drawing.Point(127, 100);
      this.lblNegativeCount.Name = "lblNegativeCount";
      this.lblNegativeCount.Size = new System.Drawing.Size(29, 13);
      this.lblNegativeCount.TabIndex = 10;
      this.lblNegativeCount.Text = "label";
      // 
      // btnCreateNegative
      // 
      this.btnCreateNegative.Enabled = false;
      this.btnCreateNegative.Location = new System.Drawing.Point(3, 95);
      this.btnCreateNegative.Name = "btnCreateNegative";
      this.btnCreateNegative.Size = new System.Drawing.Size(118, 23);
      this.btnCreateNegative.TabIndex = 8;
      this.btnCreateNegative.Text = "Save As Negative";
      this.btnCreateNegative.UseVisualStyleBackColor = true;
      this.btnCreateNegative.Click += new System.EventHandler(this.btnCreateNegative_Click);
      // 
      // tbLog
      // 
      this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbLog.Location = new System.Drawing.Point(0, 160);
      this.tbLog.Multiline = true;
      this.tbLog.Name = "tbLog";
      this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbLog.Size = new System.Drawing.Size(534, 243);
      this.tbLog.TabIndex = 11;
      // 
      // btnCreateHAAR
      // 
      this.btnCreateHAAR.Enabled = false;
      this.btnCreateHAAR.Location = new System.Drawing.Point(3, 124);
      this.btnCreateHAAR.Name = "btnCreateHAAR";
      this.btnCreateHAAR.Size = new System.Drawing.Size(118, 23);
      this.btnCreateHAAR.TabIndex = 12;
      this.btnCreateHAAR.Text = "Generate XML";
      this.btnCreateHAAR.UseVisualStyleBackColor = true;
      this.btnCreateHAAR.Click += new System.EventHandler(this.btnCreateHaar_Click);
      // 
      // btnClearLog
      // 
      this.btnClearLog.Location = new System.Drawing.Point(127, 124);
      this.btnClearLog.Name = "btnClearLog";
      this.btnClearLog.Size = new System.Drawing.Size(118, 23);
      this.btnClearLog.TabIndex = 13;
      this.btnClearLog.Text = "Cleaer Log";
      this.btnClearLog.UseVisualStyleBackColor = true;
      this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.cbVideoDevices);
      this.panel2.Controls.Add(this.btnRefreshDevices);
      this.panel2.Controls.Add(this.button1);
      this.panel2.Controls.Add(this.lblProjectFolder);
      this.panel2.Controls.Add(this.btnClearLog);
      this.panel2.Controls.Add(this.btnCreatePositive);
      this.panel2.Controls.Add(this.btnCreateHAAR);
      this.panel2.Controls.Add(this.lblPositiveCount);
      this.panel2.Controls.Add(this.btnCreateNegative);
      this.panel2.Controls.Add(this.lblNegativeCount);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(534, 160);
      this.panel2.TabIndex = 2;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.tbLog);
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel1.Location = new System.Drawing.Point(611, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(534, 403);
      this.panel1.TabIndex = 14;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1145, 403);
      this.Controls.Add(this.pnlPreview);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "HAAR Trainer";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox cbVideoDevices;
    private System.Windows.Forms.Button btnRefreshDevices;
    private System.Windows.Forms.Panel pnlPreview;
    private System.Windows.Forms.Label lblProjectFolder;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnCreatePositive;
    private System.Windows.Forms.Label lblPositiveCount;
    private System.Windows.Forms.Label lblNegativeCount;
    private System.Windows.Forms.Button btnCreateNegative;
    private System.Windows.Forms.TextBox tbLog;
    private System.Windows.Forms.Button btnCreateHAAR;
    private System.Windows.Forms.Button btnClearLog;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel1;
  }
}

