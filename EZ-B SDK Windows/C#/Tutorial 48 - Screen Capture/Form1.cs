using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FFMPEG;

namespace Tutorial_48___Screen_Capture {

  public partial class Form1 : Form {

    bool                   _frameSkip = false;
    System.Timers.Timer    _timer     = new System.Timers.Timer();
    FFMPEG.VideoFileWriter _writer    = new VideoFileWriter();
    DateTime               _startTime = new DateTime();
    int                    _skipCnt   = 0;
    int                    _frameCnt  = 0;

    private enum VideoCodecEnum {
      MPEG4 = 0,
      WMV1 = 1,
      WMV2 = 2,
      MSMPEG4v2 = 3,
      MSMPEG4v3 = 4,
      H263P = 5
    }

    public Form1() {

      InitializeComponent();

      cbFormat.Items.Clear();
      foreach (VideoCodecEnum item in Enum.GetValues(typeof(VideoCodecEnum)))
        cbFormat.Items.Add(item);

      cbFormat.SelectedItem = VideoCodecEnum.WMV2;

      string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), "Screen Recorder");

      lblFolder.Text = dir;

      try {

        if (!Directory.Exists(dir))
          Directory.CreateDirectory(dir);
      } catch (Exception ex) {

        MessageBox.Show(string.Format("{0} creating {1}", ex.Message, dir));

        return;
      }

      _timer.Interval = 100; // 10 fps
      _timer.Elapsed += new System.Timers.ElapsedEventHandler(_timer_Elapsed);

      lblTime.Text = string.Empty;

      textBox1.Text = "3500000";
    }

    void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {

      if (_frameSkip) {

        _skipCnt++;

        return;
      }

      _frameSkip = true;

      try {

        _frameCnt++;

        Bitmap bmpScreenShot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        using (Graphics gfxScreenShot = Graphics.FromImage(bmpScreenShot)) {

          gfxScreenShot.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

          gfxScreenShot.DrawImageUnscaled(Properties.Resources.Cursor, Cursor.Position);
        }

        _writer.WriteVideoFrame(bmpScreenShot);

        bmpScreenShot.Dispose();

        Invokers.SetText(lblTime, string.Format("{0} (frame: {1}, skipped: {2})", DateTime.Now.Subtract(_startTime), _frameCnt, _skipCnt));
      } finally {

        _frameSkip = false;
      }
    }

    private void btnChooseFolder_Click(object sender, EventArgs e) {

      FolderBrowserDialog fb = new FolderBrowserDialog();

      fb.SelectedPath = lblFolder.Text;

      if (fb.ShowDialog() != System.Windows.Forms.DialogResult.OK)
        return;

      lblFolder.Text = fb.SelectedPath;
    }

    private void start() {

      try {

        _skipCnt = 0;
        _frameCnt = 0;
        _frameSkip = false;

        Invokers.SetText(btnStart, "Stop");

        string         extension = string.Empty;
        VideoCodecEnum format    = (VideoCodecEnum)cbFormat.SelectedItem;

        if (format == VideoCodecEnum.H263P)
          extension = ".avi";
        else if (format == VideoCodecEnum.MPEG4)
          extension = ".mov";
        else if (format == VideoCodecEnum.MSMPEG4v2)
          extension = ".mov";
        else if (format == VideoCodecEnum.MSMPEG4v3)
          extension = ".mov";
        else if (format == VideoCodecEnum.WMV1)
          extension = ".wmv";
        else if (format == VideoCodecEnum.WMV2)
          extension = ".wmv";

        if (extension == string.Empty)
          throw new Exception("Select a format type");

        _writer.Open(
          Path.Combine(lblFolder.Text, DateTime.Now.Ticks.ToString() + extension),
          Screen.PrimaryScreen.Bounds.Width,
          Screen.PrimaryScreen.Bounds.Height,
          10,
          VideoCodec.Default,
          Convert.ToInt32(textBox1.Text));

        _startTime = DateTime.Now;

        _timer.Start();

        Invokers.SetEnabled(groupBox1, false);
      } catch (Exception ex) {

        Invokers.SetText(btnStart, "Start");

        MessageBox.Show(ex.Message);
      }
    }

    private void stop() {

      _timer.Stop();

      System.Threading.Thread.Sleep((int)_timer.Interval);

      Invokers.SetText(btnStart, "Start");

      _writer.Close();

      Invokers.SetEnabled(groupBox1, true);
    }

    private void btnStart_Click(object sender, EventArgs e) {

      if (_writer.IsOpen)
        stop();
      else
        start();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

      stop();
    }
  }
}
