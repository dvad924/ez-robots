using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EZ_B;
using System.IO;
using System.Drawing.Imaging;
using System.Net;

namespace Tutorial_39___Camera_Image_To_Facebook {

  public partial class Form1 : Form {

    Camera _camera;
    Timer  _timer;

    public Form1() {
      
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      _timer = new Timer();
      _timer.Interval = 250;
      _timer.Tick += new EventHandler(_timer_Tick);

      _camera = new Camera(ezB_Connect1.EZB);

      cbVideoDevices.Items.AddRange(Camera.GetVideoCaptureDevices());
    }

    private void SetLog(string txt, params object[] values) {

      textBox1.AppendText(string.Format(txt, values));
      textBox1.AppendText(Environment.NewLine);
    }

    private void cbVideoDevices_SelectedIndexChanged(object sender, EventArgs e) {

      _camera.StartCamera((ValuePair)cbVideoDevices.SelectedItem, panelPreview, 320, 240);

      _timer.Start();

      SetLog("Camera activated: {0}", cbVideoDevices.SelectedItem);
    }

    void _timer_Tick(object sender, EventArgs e) {

    }

    private void button1_Click(object sender, EventArgs e) {

      try {


        //fb.Post("/me/photos", fmo);
      } catch (Exception ex) {

        SetLog("Posting Error: {0}", ex.ToString());
      }
    }
  }
}
