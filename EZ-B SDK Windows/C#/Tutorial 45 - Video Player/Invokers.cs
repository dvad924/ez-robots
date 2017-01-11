using System;
using System.Drawing;
using System.Windows.Forms;

public class Invokers {

  delegate int GetTrackBarValueCallback(TrackBar control);
  public static int GetTrackBarValue(TrackBar control) {

    if (control.InvokeRequired) {

      GetTrackBarValueCallback d = new GetTrackBarValueCallback(GetTrackBarValue);
      return (int)control.Invoke(d, new object[] { control });
    } else {

      return control.Value;
    }
  }

  delegate bool GetCheckedCallback(CheckBox control);
  public static bool GetCheckedValue(CheckBox control) {

    if (control.InvokeRequired) {

      GetCheckedCallback d = new GetCheckedCallback(GetCheckedValue);
      return (bool)control.Invoke(d, new object[] { control });
    } else {

      return control.Checked;
    }
  }

  delegate string GetTextCallback(Control control);
  public static string GetText(Control control) {

    if (control.InvokeRequired) {

      GetTextCallback d = new GetTextCallback(GetText);
      return control.Invoke(d, new object[] { control }).ToString();
    } else {

      return control.Text;
    }
  }

  delegate object GetComboBoxSelectedItemCallback(ComboBox control);
  public static object GetComboBoxSelectedItem(ComboBox control) {

    if (control.InvokeRequired) {

      GetComboBoxSelectedItemCallback d = new GetComboBoxSelectedItemCallback(GetComboBoxSelectedItem);
      return control.Invoke(d, new object[] { control });
    } else {

      return control.SelectedItem;
    }
  }

  delegate Point GetPointToClientCallback(Form form, Point point);
  public static Point GetPointToClient(Form form, Point point) {

    if (form.InvokeRequired) {

      GetPointToClientCallback d = new GetPointToClientCallback(GetPointToClient);
      return (Point)form.Invoke(d, new object[] { form, point });
    } else {

      return form.PointToClient(point);
    }
  }

  delegate Rectangle GetRectangleToScreenCallback(Form form, Rectangle rect);
  public static Rectangle GetRectangleToScreen(Form form, Rectangle rect) {

    if (form.InvokeRequired) {

      GetRectangleToScreenCallback d = new GetRectangleToScreenCallback(GetRectangleToScreen);
      return (Rectangle)form.Invoke(d, new object[] { form, rect });
    } else {

      return form.RectangleToScreen(rect);
    }
  }

  delegate Point GetPointToScreenCallback(Form form, Point point);
  public static Point GetPointToScreen(Form form, Point point) {

    if (form.InvokeRequired) {

      GetPointToScreenCallback d = new GetPointToScreenCallback(GetPointToScreen);
      return (Point)form.Invoke(d, new object[] { form, point });
    } else {

      return form.PointToScreen(point);
    }
  }

  delegate void SetWindowFocusCallback(Form form);
  public static void SetWindowFocus(Form form) {

    if (form.InvokeRequired) {

      SetWindowFocusCallback d = new SetWindowFocusCallback(SetWindowFocus);
      form.Invoke(d, new object[] { form });
    } else {

      if (form.WindowState == FormWindowState.Minimized)
        form.WindowState = FormWindowState.Maximized;

      form.Activate();
    }
  }

  delegate void SetTextCallback(Control control, string text);
  public static void SetText(Control control, string text) {

    if (control.InvokeRequired) {

      SetTextCallback d = new SetTextCallback(SetText);
      control.Invoke(d, new object[] { control, text });
    } else {

      control.Text = text;
    }
  }

  delegate void SetEnabledCallback(Control control, bool enabled);
  public static void SetEnabled(Control control, bool enabled) {

    if (control.InvokeRequired) {

      SetEnabledCallback d = new SetEnabledCallback(SetEnabled);
      control.Invoke(d, new object[] { control, enabled });
    } else {

      control.Enabled = enabled;
    }
  }

  delegate void SetVisibleCallback(Control control, bool visible);
  public static void SetVisible(Control control, bool visible) {

    if (control.InvokeRequired) {

      SetVisibleCallback d = new SetVisibleCallback(SetVisible);
      control.Invoke(d, new object[] { control, visible });
    } else {

      control.Visible = visible;
    }
  }

  delegate void SetAppendTextCallback1(TextBox control, bool newLine, string text, params object[] param);
  public static void SetAppendText(TextBox control, bool newLine, string text, params object[] param) {

    if (control.InvokeRequired) {

      SetAppendTextCallback1 d = new SetAppendTextCallback1(SetAppendText);
      control.Invoke(d, new object[] { control, newLine, text, param });
    } else {

      control.AppendText(string.Format(text, param));

      if (newLine)
        control.AppendText(Environment.NewLine);
    }
  }

  delegate void SetAppendTextCallback2(TextBox control, bool newLine, int maxLineCount, string text, params object[] param);
  public static void SetAppendText(TextBox control, bool newLine, int maxLineCount, string text, params object[] param) {

    if (control.InvokeRequired) {

      SetAppendTextCallback2 d = new SetAppendTextCallback2(SetAppendText);
      control.Invoke(d, new object[] { control, newLine, maxLineCount, text, param });
    } else {

      if (control.Lines.Length > maxLineCount)
        control.Clear();

      control.AppendText(string.Format(text, param));

      if (newLine)
        control.AppendText(Environment.NewLine);
    }
  }

  delegate void SetBackColorCallback(Control control, Color backColor);
  public static void SetBackColor(Control control, Color backColor) {

    if (control.InvokeRequired) {

      SetBackColorCallback d = new SetBackColorCallback(SetBackColor);
      control.Invoke(d, new object[] { control, backColor });
    } else {

      control.BackColor = backColor;
    }
  }

  delegate void SetTabControlPageCallback(TabControl control, int pageIndex);
  public static void SetTabControlPage(TabControl control, int pageIndex) {

    if (control.InvokeRequired) {

      SetTabControlPageCallback d = new SetTabControlPageCallback(SetTabControlPage);
      control.Invoke(d, new object[] { control, pageIndex });
    } else {

      control.SelectedIndex = pageIndex;
    }
  }

  delegate void SetCheckedCallback(CheckBox control, bool isChecked);
  public static void SetChecked(CheckBox control, bool isChecked) {

    if (control.InvokeRequired) {

      SetCheckedCallback d = new SetCheckedCallback(SetChecked);
      control.Invoke(d, new object[] { control, isChecked });
    } else {

      control.Checked = isChecked;
    }
  }

  delegate void SetDataGridViewRowTextBGColorCallback(DataGridView control, int rowNum, int cellNum, string text, Color bgColor);
  public static void SetDataGridViewRowTextBGColor(DataGridView control, int rowNum, int cellNum, string text, Color bgColor) {

    if (control.InvokeRequired) {

      SetDataGridViewRowTextBGColorCallback d = new SetDataGridViewRowTextBGColorCallback(SetDataGridViewRowTextBGColor);
      control.Invoke(d, new object[] { control, rowNum, cellNum, text, bgColor });
    } else {

      control.Rows[rowNum].DefaultCellStyle.BackColor = bgColor;
      control.Rows[rowNum].Cells[cellNum].Value = text;
    }
  }
}

