using System;
using System.Windows.Forms;

namespace Tutorial_45___Video_Player {

  public partial class Form1 : Form {

    public Form1() {

      InitializeComponent();
      videoPlayer1.OnError += new EZ_B.VideoPlayer.OnErrorHandler(videoPlayer1_OnError);
      videoPlayer1.OnCompleted += new EZ_B.VideoPlayer.OnCompletedHandler(videoPlayer1_OnCompleted);
      videoPlayer1.OnBeginPlaying += new EZ_B.VideoPlayer.OnBeginPlayingHandler(videoPlayer1_OnBeginPlaying);

      SetStopped();
    }

    void videoPlayer1_OnBeginPlaying(string codecName, long frameRate, int height, int width) {

      Invokers.SetAppendText(tbLog, true, "codec: {0}, frameRate: {1}, height: {2}, width: {3}", codecName, frameRate, height, width);
    }

    void videoPlayer1_OnCompleted() {

      Invokers.SetAppendText(tbLog, true, "Completed");

      SetStopped();
    }

    void videoPlayer1_OnError(string message) {

      Invokers.SetAppendText(tbLog, true, message);
    }

    private void SetPlaying() {

      Invokers.SetEnabled(btnPlay, false);
      Invokers.SetEnabled(btnStop, true);
      Invokers.SetEnabled(btnPause, true);
      Invokers.SetEnabled(btnResume, false);
    }

    private void SetStopped() {

      Invokers.SetEnabled(btnPlay, true);
      Invokers.SetEnabled(btnStop, false);
      Invokers.SetEnabled(btnPause, false);
      Invokers.SetEnabled(btnResume, false);
    }

    private void SetPaused() {

      Invokers.SetEnabled(btnPlay, false);      
      Invokers.SetEnabled(btnStop, true);
      Invokers.SetEnabled(btnPause, false);
      Invokers.SetEnabled(btnResume, true);
    }

    private void btnPlay_Click(object sender, EventArgs e) {

      Invokers.SetAppendText(tbLog, true, "Playing");

      SetPlaying();

      videoPlayer1.PlayFile("Example Video.mpg", true);
    }

    private void btnStop_Click(object sender, EventArgs e) {

      videoPlayer1.Stop();
    }

    private void btnResume_Click(object sender, EventArgs e) {

      SetPlaying();

      videoPlayer1.Resume();
    }

    private void btnPause_Click(object sender, EventArgs e) {

      SetPaused();

      videoPlayer1.Pause();
    }
  }
}
