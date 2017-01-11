using System;
using System.Windows.Forms;
using EZ_B;

namespace Tutorial_61___Audio_Synthesizer {

  public partial class Form1 : Form {

    public Form1() {

      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {

      ucezB_Connect1.EZB.MusicSynth.PlayNoteWait(MusicSynth.NotesEnum.C2, 300);
      ucezB_Connect1.EZB.MusicSynth.PlayNoteWait(MusicSynth.NotesEnum.D2, 300);
      ucezB_Connect1.EZB.MusicSynth.PlayNoteWait(MusicSynth.NotesEnum.E2, 300);

      ucezB_Connect1.EZB.MusicSynth.PlayNoteWait(MusicSynth.NotesEnum.A2, 300);
      ucezB_Connect1.EZB.MusicSynth.PlayNoteWait(MusicSynth.NotesEnum.A2, 300);

      ucezB_Connect1.EZB.MusicSynth.PlayNoteWait(MusicSynth.NotesEnum.B2, 300);
      ucezB_Connect1.EZB.MusicSynth.PlayNoteWait(MusicSynth.NotesEnum.A2, 300);
      ucezB_Connect1.EZB.MusicSynth.PlayNoteWait(MusicSynth.NotesEnum.E2, 300);
      ucezB_Connect1.EZB.MusicSynth.PlayNoteWait(MusicSynth.NotesEnum.C2, 300);

      ucezB_Connect1.EZB.MusicSynth.PlayNoteWait(MusicSynth.NotesEnum.D2, 300);
      ucezB_Connect1.EZB.MusicSynth.PlayNoteWait(MusicSynth.NotesEnum.E2, 300);
      ucezB_Connect1.EZB.MusicSynth.PlayNoteWait(MusicSynth.NotesEnum.E2, 300);
      ucezB_Connect1.EZB.MusicSynth.PlayNoteWait(MusicSynth.NotesEnum.D2, 300);
      ucezB_Connect1.EZB.MusicSynth.PlayNoteWait(MusicSynth.NotesEnum.C2, 300);
      ucezB_Connect1.EZB.MusicSynth.PlayNoteWait(MusicSynth.NotesEnum.D2, 300);
    }
  }
}
