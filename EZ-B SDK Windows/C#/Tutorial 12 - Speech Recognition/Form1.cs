using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using EZ_B;

namespace Tutorial_12___Speech_Recognition {

  public partial class Form1 : Form {

    EZB _ezb    = new EZB();
    bool           _status = false;

    public Form1() {

      InitializeComponent();

      _ezb.SpeechSynth.OnPhraseRecognized += new SpeechSynth.OnPhraseRecognizedEvent(SpeechSynth_OnPhraseRecognized);
    }

    void SpeechSynth_OnPhraseRecognized(string text, float confidence) {

      log(false, "{0}: {1}", text, confidence);
    }

    private void log(bool speak, string msg, params object[] values) {

      string tmp = string.Format(msg, values);

      textBox1.AppendText(tmp);
      textBox1.AppendText(Environment.NewLine);

      if (speak)
        _ezb.SpeechSynth.Say(tmp);
    }

    private void button1_Click(object sender, EventArgs e) {

      if (_status)
        stopListening();
      else
        startListening();
    }

    private void startListening() {

      button1.Text = "Disable Listening";
      _status = true;
      groupBox1.Enabled = false;

      if (checkBox1.Checked) {

        _ezb.SpeechSynth.SetDictionaryToAllLocale();

        log(true, "All know english words will be understood.");
      } else {

        List<string> phrases = new List<string>();

        foreach (string phrase in Regex.Split(textBox2.Text, Environment.NewLine))
          phrases.Add(phrase);

        _ezb.SpeechSynth.SetDictionaryOfPhrases(phrases.ToArray());

        log(true, "Custom dictionary phrases will be understood.");
      }
      
      log(true, "Hello");

      _ezb.SpeechSynth.StartListening();
    }

    private void stopListening() {

      button1.Text = "Start Listening";
      _status = false;
      groupBox1.Enabled = true;

      _ezb.SpeechSynth.StopListening();

      log(true, "Good Bye");
    }
  }
}
