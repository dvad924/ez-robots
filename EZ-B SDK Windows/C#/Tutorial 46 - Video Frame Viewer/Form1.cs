using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EZ_B.VideoCapture;

namespace Tutorial_46___Video_Frame_Viewer {

  public partial class Form1 : Form {

    List<Bitmap> _bitmaps = new List<Bitmap>();

    public Form1() {

      InitializeComponent();
    }

    private void btnLoadVideoFile_Click(object sender, EventArgs e) {

      OpenFileDialog ofd = new OpenFileDialog();

      if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
        return;

      Invokers.SetText(lblFrameTxt, "Loading...");

      foreach (Bitmap b in _bitmaps)
        b.Dispose();

      _bitmaps.Clear();

      EZ_B.FFMPEGUtils.VideoFileReader vfr = new EZ_B.FFMPEGUtils.VideoFileReader(ofd.FileName);

      while (true) {

        Bitmap b = vfr.ReadNextVideoFrame();

        if (b == null)
          break;

        _bitmaps.Add(b);
      }

      trackBar1.Minimum = 1;
      trackBar1.Maximum = _bitmaps.Count;
      trackBar1.Value = 1;

      trackBar1_Scroll(null, null);
    }

    private void trackBar1_Scroll(object sender, EventArgs e) {

      using (Graphics g = pnlPreview.CreateGraphics())
        g.DrawImage(_bitmaps[trackBar1.Value], 0, 0, pnlPreview.Width, pnlPreview.Height);
      
      Invokers.SetText(lblFrameTxt, string.Format("{0}/{1}", trackBar1.Value, _bitmaps.Count));
    }
  }
}
