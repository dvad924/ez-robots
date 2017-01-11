using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_54___Multi_Motion_Detect {

  public partial class Form1 : Form {

    EZB    _ezb    = null;
    Camera _camera = null;
    NAudio.Midi.MidiOut _midi = null;

    NAudio.Midi.MidiFile _file = null;

    List<int> _notesPlaying = new List<int>();

    public Form1() {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      _ezb = new EZB();
      _ezb.OnLog += _ezb_OnLog;

      _file = new NAudio.Midi.MidiFile("KTwinkletwinklelittlestar.mid");

      _midi = new NAudio.Midi.MidiOut(0);
      Invokers.SetAppendText(tbLog, true, "midi events: {0}", _file.Events.Count());

      _camera = new Camera(_ezb);
      _camera.OnNewFrame += _camera_OnNewFrame;

      cbVideoDevices.Items.AddRange(Camera.GetVideoCaptureDevices());

      for (int x = 0; x < NAudio.Midi.MidiOut.NumberOfDevices; x++)
        Invokers.SetAppendText(tbLog, true, "Midi device: {0}", NAudio.Midi.MidiOut.DeviceInfo(x).ProductName);

      for (int x = 1; x < 20; x++)
        cbSensitivity.Items.Add(x);

      cbSensitivity.SelectedIndex = 10;

      comboBox1.Items.Clear();
      for (int x = 0; x < 127; x++)
        comboBox1.Items.Add(x);

      comboBox1.SelectedIndex = 53;
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

      _camera.StopCamera();

      _midi.Dispose();
    }

    void _ezb_OnLog(DateTime datetime, string logTxt) {

      Invokers.SetAppendText(tbLog, true, "{0} - {1}", datetime, logTxt);
    }

    private void cbVideoDevices_SelectedIndexChanged(object sender, EventArgs e) {

      _camera.StartCamera((ValuePair)cbVideoDevices.SelectedItem, pnlVideo, 320, 240);

      pnlVideo.Width = 320;
      pnlVideo.Height = 240;
    }

    int _midiIndex = 0;

    void _camera_OnNewFrame() {

      ObjectLocation [] objectLocations = _camera.CameraMotionDetection.GetMotionDetection(30, (int)Invokers.GetComboBoxSelectedItem(cbSensitivity), 0);

      foreach (int note in _notesPlaying) {

        NAudio.Midi.NoteEvent d = new NAudio.Midi.NoteEvent(0, 1, NAudio.Midi.MidiCommandCode.NoteOff, note, 127);
        _midi.Send(d.GetAsShortMessage());
      }

      _notesPlaying.Clear();

      if (radioButton1.Checked) {

        foreach (ObjectLocation objectLocation in objectLocations) {

          if (!_rect.Contains(objectLocation.Rect))
            continue;

          int note = new Random().Next(20, 100);
          NAudio.Midi.NoteEvent d = new NAudio.Midi.NoteEvent(0, 1, NAudio.Midi.MidiCommandCode.NoteOn, note, 127);

          _midi.Send(d.GetAsShortMessage());

          _notesPlaying.Add(note);
        }
      }

      if (radioButton2.Checked) {

        foreach (ObjectLocation objectLocation in objectLocations) {

          if (!_rect.Contains(objectLocation.Rect))
            continue;

          int zeroX = objectLocation.Rect.X - _rect.X;
          int zeroY = objectLocation.Rect.Y - _rect.Y;
          int note = (int)(Functions.GetScalarFromRange(127, _rect.Width, 0) * (float)zeroX);
          note = 127 - note;
          NAudio.Midi.NoteEvent d = new NAudio.Midi.NoteEvent(0, 1, NAudio.Midi.MidiCommandCode.NoteOn, note, 127);

          _midi.Send(d.GetAsShortMessage());

          _notesPlaying.Add(note);
        }
      }

      if (radioButton3.Checked) {

        foreach (ObjectLocation objectLocation in objectLocations) {

          if (!_rect.Contains(objectLocation.Rect))
            continue;

          NAudio.Midi.MidiEvent d =_file.Events[1][_midiIndex];

          _midiIndex++;

          if (_midiIndex >= _file.Events[1].Count)
            _midiIndex = 0;

          if (d.CommandCode == NAudio.Midi.MidiCommandCode.NoteOn)
            _midi.Send(d.GetAsShortMessage());

          System.Threading.Thread.Sleep(50);
        }
      }

      using (Graphics g = pnlVideo.CreateGraphics())
        g.DrawRectangle(Pens.Pink, _rect);
    }

    Rectangle _rect = new Rectangle();

    private void pnlVideo_MouseClick(object sender, MouseEventArgs e) {

      if (_rect.X == 0) {

        _rect.X = e.X;
        _rect.Y = e.Y;
      } else if (_rect.Width == 0) {

        _rect.Width = e.X - _rect.X;
        _rect.Height = e.Y - _rect.Y;
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

      int p = (int)comboBox1.SelectedItem;

      NAudio.Midi.PatchChangeEvent n = new NAudio.Midi.PatchChangeEvent(0, 1, p);
      _midi.Send(n.GetAsShortMessage());
    }

    private void button1_Click(object sender, EventArgs e) {

      _rect = new Rectangle();
    }
  }
}
