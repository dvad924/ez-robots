using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tutorial_64___Raw_Video_Data {

  public unsafe partial class Form1 : Form {

    EZ_B.EZBv4Video               _video;
    EZ_B.EZB                      _ezb;
    AForge.Imaging.Filters.Mirror _mirror;

    byte [] _bmpHeader = new byte[54] {
      0x42, 0x4d,             // header BM                          (0, 1)
      0x36, 0x38, 0x03, 0x00, // size of bmp in bytes               (2, 3, 4, 5)
      0x00, 0x00,             //                                    (6, 7)
      0x00, 0x00,             //                                    (8, 9)
      0x36, 0x00, 0x00, 0x00, // offset to start of image           (10, 11, 12, 13)
      0x28, 0x00, 0x00, 0x00, // bitmap info header size must be 40 (14, 15, 16, 17)
      0x40, 0x01, 0x00, 0x00, // image width pixels                 (18, 19, 20, 21)
      0xf0, 0x00, 0x00, 0x00, // image height                       (22, 23, 24, 25)
      0x01, 0x00,             // planes                             (26, 27)
      0x18, 0x00,             // size of pixels (24 bits)           (28, 29) 
      0x00, 0x00, 0x00, 0x00, // compresion type                    (30, 31, 32, 33)
      0x00, 0x84, 0x03, 0x00, // size of image (230,400 bytes)      (34, 35, 36, 37)
      0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
    };

    byte [] _tmpData = new byte[230400 + 54]; // max image size is 320x240 of 24 bit pixel depth plus header size

    public Form1() {

      InitializeComponent();

      _video = new EZ_B.EZBv4Video();
      _video.OnImageDataReady += _video_OnImageDataReady;

      _ezb = new EZ_B.EZB();

      _mirror = new AForge.Imaging.Filters.Mirror(true, false);

      // assign the bmp header to the tmp data
      for (int x = 0; x < _bmpHeader.Length; x++)
        _tmpData[x] = _bmpHeader[x];
    }

    void _video_OnImageDataReady(byte[] imageData) {

      try {

        using (NanoJpeg.NJImage nj = new NanoJpeg.NJImage()) {

          nj.Decode(imageData);

          Invokers.SetAppendText(textBox1, true, "{0}x{1} size: {2}", nj.Width, nj.Height, nj.ImageSize);

          using (AForge.Imaging.UnmanagedImage image = nj.GetAsUnmanagedImage) {

            _mirror.ApplyInPlace(image);

            AForge.Imaging.Drawing.FillRectangle(image, new Rectangle(10, 10, 10, 10), Color.Green);

            // size
            byte [] tmpSize = BitConverter.GetBytes((UInt32)(_bmpHeader.Length));
            _tmpData[2] = tmpSize[0];
            _tmpData[3] = tmpSize[1];
            _tmpData[4] = tmpSize[2];
            _tmpData[5] = tmpSize[3];

            // width
            byte [] tmpWidth = BitConverter.GetBytes((UInt32)(nj.Width));
            _tmpData[18] = tmpWidth[0];
            _tmpData[19] = tmpWidth[1];
            _tmpData[20] = tmpWidth[2];
            _tmpData[21] = tmpWidth[3];

            // height
            byte [] tmpHeight = BitConverter.GetBytes((UInt32)(nj.Height));
            _tmpData[22] = tmpHeight[0];
            _tmpData[23] = tmpHeight[1];
            _tmpData[24] = tmpHeight[2];
            _tmpData[25] = tmpHeight[3];

            // image data size
            byte [] tmpImageSize = BitConverter.GetBytes((UInt32)(nj.ImageSize));
            _tmpData[34] = tmpImageSize[0];
            _tmpData[35] = tmpImageSize[1];
            _tmpData[36] = tmpImageSize[2];
            _tmpData[37] = tmpImageSize[3];

            // bmp is BGR not RGB
            for (int p = 0; p < nj.ImageSize; p += 3) {

              _tmpData[54 + p] = nj.GetByteAtIndex(p + 2); // Blue
              _tmpData[55 + p] = nj.GetByteAtIndex(p + 1); // Green
              _tmpData[56 + p] = nj.GetByteAtIndex(p);     // Red
            }

            int imageSize = nj.ImageSize + _bmpHeader.Length;

            using (MemoryStream ms = new MemoryStream(imageSize)) {

              ms.Write(_tmpData, 0, imageSize);

              using (Graphics g = panel1.CreateGraphics()) {

                Bitmap bm = new Bitmap(ms);

                g.DrawImage(bm, 0, 0);
              }
            }
          }
        }
      } catch (Exception ex) {

        Invokers.SetAppendText(textBox1, true, ex.ToString());

        _video.Stop();
      }
    }

    private void button1_Click(object sender, EventArgs e) {

      if (_video.IsRunning)
        _video.Stop();
      else
        _video.Start(_ezb, "10.0.0.107", 24);
    }

    private void button2_Click(object sender, EventArgs e) {

    }
  }
}
