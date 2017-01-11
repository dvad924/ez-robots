using System;
using System.Windows.Forms;
using EZ_B;
using System.IO;
using System.Diagnostics;

// http://docs.opencv.org/trunk/doc/user_guide/ug_traincascade.html
// http://www.shervinemami.info/faceRecognition.html

namespace Tutorial_44___Haar_Trainer {

  public partial class Form1 : Form {

    EZB    _ezb;
    Camera _camera;

    int _cntPos = 0;
    int _cntNeg = 0;

    string _positiveFilename = string.Empty;
    string _negativeFilename = string.Empty;

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      _ezb = new EZB();
      _ezb.OnLog += _ezb_OnLog;
      _camera = new Camera(_ezb);
      _camera.OnNewFrame += _camera_OnNewFrame;

      cbVideoDevices.Items.Clear();
      cbVideoDevices.Items.AddRange(Camera.GetVideoCaptureDevices());

      lblProjectFolder.Text = string.Empty;

      lblNegativeCount.Text = string.Empty;
      lblPositiveCount.Text = string.Empty;
    }

    void Log(object txt, params object[] values) {

      Invokers.SetAppendText(tbLog, true, txt.ToString(), values);
    }

    void _ezb_OnLog(DateTime datetime, string logTxt) {

      Invokers.SetAppendText(tbLog, true, logTxt);
    }

    void _camera_OnNewFrame() {

    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

      _camera.StopCamera();
    }

    private void cbVideoDevices_SelectedIndexChanged(object sender, EventArgs e) {

      ValuePair vp = (ValuePair)cbVideoDevices.SelectedItem;

      _camera.StartCamera(vp, pnlPreview, 320, 240);
    }

    private void button1_Click(object sender, EventArgs e) {

      btnCreateNegative.Enabled = false;
      btnCreatePositive.Enabled = false;
      btnCreateHAAR.Enabled = false;

      using (FolderBrowserDialog fbd = new FolderBrowserDialog()) {

        if (fbd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
          return;

        if (Directory.GetFiles(fbd.SelectedPath).Length != 0) {

          MessageBox.Show("This folder is not empty. Cannot continue");

          return;
        }

        lblProjectFolder.Text = fbd.SelectedPath;

        _positiveFilename = Path.Combine(lblProjectFolder.Text, "positives.txt");
        _negativeFilename = Path.Combine(lblProjectFolder.Text, "negatives.txt");

        btnCreateNegative.Enabled = true;
        btnCreatePositive.Enabled = true;
        btnCreateHAAR.Enabled = true;

        _cntNeg = 0;
        _cntPos = 0;
      }
    }

    private void btnCreatePositive_Click(object sender, EventArgs e) {

      string jpgFilename = string.Format("pos-{0}.jpg", _cntPos);

      _camera.SaveImageAsJPEG(Path.Combine(lblProjectFolder.Text, jpgFilename));

      File.AppendAllText(_positiveFilename,
        string.Format("{0} 1 0 0 {1} {2}",
          jpgFilename,
          _camera.CaptureWidth,
          _camera.CaptureHeight));

      File.AppendAllText(_positiveFilename, Environment.NewLine);

      _cntPos++;

      Invokers.SetText(lblPositiveCount, "{0} Saved", _cntPos);
    }

    private void btnCreateNegative_Click(object sender, EventArgs e) {

      string jpgFilename = string.Format("neg-{0}.jpg", _cntNeg);

      _camera.SaveImageAsJPEG(Path.Combine(lblProjectFolder.Text, jpgFilename));

      File.AppendAllText(_negativeFilename, jpgFilename);

      File.AppendAllText(_negativeFilename, Environment.NewLine);

      _cntNeg++;

      Invokers.SetText(lblNegativeCount, "{0} Saved", _cntNeg);
    }

    private void btnCreateHaar_Click(object sender, EventArgs e) {

      Enabled = false;

      string vecFilename      = Path.Combine(lblProjectFolder.Text, "positives.vec");
      string appCreateSamples = Path.Combine(Application.StartupPath, @"OpenCV\opencv_createsamples.exe");

      string argCreateSamples = string.Format("-vec \"{0}\" -info \"{1}\" -bg \"{2}\" -num {3}",
        Path.GetFileName(vecFilename),
        Path.GetFileName(_positiveFilename),
        Path.GetFileName(_negativeFilename),
        _cntPos);

      Log("\"{0}\" {1}", appCreateSamples, argCreateSamples);

      ProcessStartInfo psCreateSamples = new ProcessStartInfo();
      psCreateSamples.FileName = appCreateSamples;
      psCreateSamples.Arguments = argCreateSamples;
      psCreateSamples.WorkingDirectory = lblProjectFolder.Text;

      using (System.Diagnostics.Process p = new System.Diagnostics.Process()) {

        p.StartInfo = psCreateSamples;
        p.Start();
        p.WaitForExit();
      }

      string xmlFilename = lblProjectFolder.Text;

      string appTrainCascade = Path.Combine(Application.StartupPath, @"OpenCV\opencv_traincascade.exe");

      string argTrainCascade = string.Format("-data \"{0}\" -vec \"{1}\" -bg \"{2}\" -numPos {3} -numNeg {4} -featureType HAAR",
        xmlFilename,
        vecFilename,
        _negativeFilename,
        _cntPos,
        _cntNeg);

      Log("\"{0}\" {1}", appTrainCascade, argTrainCascade);

      ProcessStartInfo psTrainCascade = new ProcessStartInfo();
      psTrainCascade.FileName = appTrainCascade;
      psTrainCascade.Arguments = argTrainCascade;
      psTrainCascade.WorkingDirectory = lblProjectFolder.Text;

      using (System.Diagnostics.Process p = new System.Diagnostics.Process()) {

        p.StartInfo = psTrainCascade;
        p.Start();
        p.WaitForExit();
      }
      Enabled = true;
    }

    private void btnClearLog_Click(object sender, EventArgs e) {

      tbLog.Clear();
    }
  }
}
