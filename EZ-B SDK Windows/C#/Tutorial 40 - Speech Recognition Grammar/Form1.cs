using System;
using System.IO;
using System.Speech.Recognition;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Tutorial_40___Speech_Recognition_Grammar {

  public partial class Form1 : Form {

    readonly string _LISTENING_ON  = "Stop Listening";
    readonly string _LISTENING_OFF = "Start Listening";

    string _lastNoun      = "you";
    string _lastVerb      = "smile";
    string _lastAdjective = "big";
    string _lastName      = "DJ";

    public Form1() {

      InitializeComponent();

      ezB_Connect1.EZB.SpeechSynth.OnPhraseRecognized += new EZ_B.SpeechSynth.OnPhraseRecognizedEvent(SpeechSynth_OnPhraseRecognized);

      button1.Text = _LISTENING_OFF;

      tbNouns.Text = File.ReadAllText("Nouns.txt");
      tbNames.Text = File.ReadAllText("Names.txt");

      textBox1.Focus();
    }

    delegate void SetGlobalVoidAppendCallback(TextBox control, bool newLine, string text, params object[] param);
    public static void SetGlobalAppendText(TextBox control, bool newLine, string text, params object[] param) {

      if (control.InvokeRequired) {

        SetGlobalVoidAppendCallback d = new SetGlobalVoidAppendCallback(SetGlobalAppendText);
        control.Invoke(d, new object[] { control, newLine, text, param });
      } else {

        control.AppendText(string.Format(text, param));

        if (newLine)
          control.AppendText(Environment.NewLine);
      }
    }

    private string contains(string text, string[] wordList) {

      text = text.ToLower();

      foreach (string word in wordList)
        if (text.Contains(word.ToLower()))
          return word.ToLower();

      return string.Empty;
    }

    void SpeechSynth_OnPhraseRecognized(string text, float confidence) {

      processInput(text, false);
    }

    void processInput(string userText, bool manualInput) {

      string [] responses  = tbResponses.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
      string [] nouns      = tbNouns.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
      string [] verbs      = tbVerbs.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
      string [] adjectives = tbAdjectives.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
      string [] names      = tbNames.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

      SetGlobalAppendText(tbResults, true, "You> {0}", userText);

      string noun = contains(userText, nouns);
      if (noun != string.Empty)
        _lastNoun = noun;

      string verb = contains(userText, verbs);
      if (verb != string.Empty)
        _lastVerb = verb;

      string adjective = contains(userText, adjectives);
      if (adjective != string.Empty)
        _lastAdjective = adjective;

      string name = contains(userText, names);
      if (name != string.Empty)
        _lastName = adjective;

      string response = responses[ezB_Connect1.EZB.GetRandomNumber(0, responses.Length)];

      if (manualInput) {

        string newResp = userText;

        newResp = Regex.Replace(newResp, " " + _lastNoun, " {noun}", RegexOptions.IgnoreCase);
        newResp = Regex.Replace(newResp, " " + _lastVerb, " {verb}", RegexOptions.IgnoreCase);
        newResp = Regex.Replace(newResp, " " + _lastAdjective, " {adjective}", RegexOptions.IgnoreCase);

        tbResponses.AppendText(Environment.NewLine + newResp);
      }

      response = Regex.Replace(response, " {name}", " " + _lastName, RegexOptions.IgnoreCase);
      response = Regex.Replace(response, " {noun}", " " + _lastNoun, RegexOptions.IgnoreCase);
      response = Regex.Replace(response, " {verb}", " " + _lastVerb, RegexOptions.IgnoreCase);
      response = Regex.Replace(response, " {adjective}", " " + _lastAdjective, RegexOptions.IgnoreCase);

      response = Regex.Replace(response, " {randomNoun}", " " + nouns[ezB_Connect1.EZB.GetRandomNumber(0, nouns.Length)], RegexOptions.IgnoreCase);
      response = Regex.Replace(response, " {randomVerb}", " " + verbs[ezB_Connect1.EZB.GetRandomNumber(0, verbs.Length)], RegexOptions.IgnoreCase);
      response = Regex.Replace(response, " {randomAdjective}", " " + adjectives[ezB_Connect1.EZB.GetRandomNumber(0, adjectives.Length)], RegexOptions.IgnoreCase);

      SetGlobalAppendText(tbResults, true, "Synthia> {0}", response);

      ezB_Connect1.EZB.SpeechSynth.Say(response);
    }

    private void button1_Click(object sender, EventArgs e) {

      if (button1.Text == _LISTENING_OFF)
        startListening();
      else
        stopListening();
    }

    private void startListening() {

      Choices nouns      = new Choices(tbNouns.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
      Choices verbs      = new Choices(tbVerbs.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
      Choices adjectives = new Choices(tbAdjectives.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));

      ezB_Connect1.EZB.SpeechSynth.ClearDictionary();

      GrammarBuilder gb1 = new GrammarBuilder();
      gb1.AppendWildcard();
      gb1.Append(nouns);
      gb1.AppendWildcard();
      gb1.Append(verbs);
      gb1.AppendWildcard();
      gb1.Append(adjectives);
      gb1.AppendWildcard();
      ezB_Connect1.EZB.SpeechSynth.AppendDictionaryFromGrammar(gb1);

      GrammarBuilder gb2 = new GrammarBuilder();
      gb2.AppendWildcard();
      gb2.Append(verbs);
      gb2.AppendWildcard();
      gb2.Append(nouns);
      gb2.AppendWildcard();
      gb2.Append(adjectives);
      gb2.AppendWildcard();
      ezB_Connect1.EZB.SpeechSynth.AppendDictionaryFromGrammar(gb2);

      GrammarBuilder gb3 = new GrammarBuilder();
      gb3.AppendWildcard();
      gb3.Append(verbs);
      gb3.AppendWildcard();
      gb3.Append(adjectives);
      gb3.AppendWildcard();
      gb3.Append(nouns);
      gb3.AppendWildcard();
      ezB_Connect1.EZB.SpeechSynth.AppendDictionaryFromGrammar(gb3);

      GrammarBuilder gb4 = new GrammarBuilder();
      gb4.AppendWildcard();
      gb4.Append(adjectives);
      gb4.AppendWildcard();
      gb4.Append(verbs);
      gb4.AppendWildcard();
      gb4.Append(adjectives);
      gb4.AppendWildcard();
      ezB_Connect1.EZB.SpeechSynth.AppendDictionaryFromGrammar(gb4);

      GrammarBuilder gb5 = new GrammarBuilder();
      gb5.AppendWildcard();
      gb5.Append(nouns);
      gb5.AppendWildcard();
      ezB_Connect1.EZB.SpeechSynth.AppendDictionaryFromGrammar(gb5);

      ezB_Connect1.EZB.SpeechSynth.StartListening();

      button1.Text = _LISTENING_ON;
    }

    private void stopListening() {

      ezB_Connect1.EZB.SpeechSynth.StopListening();

      button1.Text = _LISTENING_OFF;
    }

    private void textBox1_KeyUp(object sender, KeyEventArgs e) {

      if (e.KeyData == Keys.Enter) {

        processInput(textBox1.Text, true);
        textBox1.Text = string.Empty;
      }
    }
  }
}
