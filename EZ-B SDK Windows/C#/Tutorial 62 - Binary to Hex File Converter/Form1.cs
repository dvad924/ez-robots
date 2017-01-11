using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tutorial_62___Binary_to_Hex_File_Converter {

  public partial class Form1 : Form {

    public Form1() {

      InitializeComponent();
    }

    private void Log(string txt, params object[] param) {

      textBox1.AppendText(string.Format(txt, param));
      textBox1.AppendText(Environment.NewLine);
    }

    private void button1_Click(object sender, EventArgs e) {

      OpenFileDialog ofd = new OpenFileDialog();

      if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
        return;

      byte [] fileBytes   = File.ReadAllBytes(ofd.FileName);
      string  variableName = Path.GetFileNameWithoutExtension(ofd.FileName).Replace(" ", "_").Replace("-", "_");

      Log("Writing: {0} bytes", fileBytes.Length);

      StringBuilder sb = new StringBuilder();

      sb.AppendFormat("#ifndef __File{0}", variableName).AppendLine();
      sb.AppendFormat("#define __File{0}", variableName).AppendLine();

      sb.AppendFormat("const uint32_t File{0}_Size = {1};", variableName, fileBytes.Length).AppendLine();

      sb.AppendFormat("const uint8_t file{0} [] = ", variableName).AppendLine("{");

      int size = 0;

      for (int cnt = 0; cnt < fileBytes.Length; cnt++) {

        byte b = fileBytes[cnt];

        if (size > 0)
          sb.Append(",");

        sb.Append(b);

        sb.AppendLine();

        size++;
      }

      sb.AppendLine("};");

      sb.AppendLine();

      sb.AppendLine("#endif");

      File.WriteAllText(ofd.FileName + ".h", sb.ToString());

      Log("Done");
    }
  }
}
