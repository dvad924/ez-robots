using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_60___HT16K33_8x8 {

  class LEDButton : Button {

    public int Row = 0;
    public int Col = 0;

    public LEDButton(int row, int col)
      : base() {

      Row = row;
      Col = col;
    }
  }
}
