using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tutorial_39___Camera_Image_To_Facebook {
  static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
    }
  }
}
