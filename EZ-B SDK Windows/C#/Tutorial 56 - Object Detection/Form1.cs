using System;
using System.Drawing;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_56___Object_Detection {

  public partial class Form1 : Form {

    EZB                                          _ezb;
    Camera                                       _camera;

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      progressBar1.Minimum = 0;
      progressBar1.Value = 0;

      _ezb = new EZB();

      _camera = new Camera(_ezb);
      _camera.OnNewFrame += _camera_OnNewFrame;

      comboBox1.Items.Clear();
      comboBox1.Items.AddRange(Camera.GetVideoCaptureDevices());
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

      if (_camera.IsActive)
        _camera.StopCamera();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

      _camera.StartCamera((ValuePair)comboBox1.SelectedItem, pnlCamera, 320, 240);
    }

    void _camera_OnNewFrame() {

      ObjectLocation [] objectLocations = _camera.CameraAVMObjectDetection.GetDetectedObjects(false, false);

      foreach (ObjectLocation objectLocation in objectLocations)
        Invokers.SetAppendText(textBox1, true, objectLocation.ObjectName);
    }

    private void pnlCamera_MouseClick(object sender, MouseEventArgs e) {

    }

    private void pnlCamera_MouseMove(object sender, MouseEventArgs e) {

    }

    private void btnLearn_Click(object sender, EventArgs e) {

    }

    private void btnClear_Click(object sender, EventArgs e) {

    }

    private void button1_Click(object sender, EventArgs e) {

      _camera.OnNewFrame -= _camera_OnNewFrame;

      using (EZ_Builder.UCForms.FormCameraCustomObject o = new EZ_Builder.UCForms.FormCameraCustomObject(_camera))
        o.ShowDialog();

      _camera.SetPreviewControl = pnlCamera;

      _camera.OnNewFrame += _camera_OnNewFrame;
    }
  }
}
