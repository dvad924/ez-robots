using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

public class Invokers {

  delegate int GetTrackBarValueCallback(TrackBar control);
  public static int GetTrackBarValue(TrackBar control) {

    try {

      if (control.InvokeRequired) {

        GetTrackBarValueCallback d = new GetTrackBarValueCallback(GetTrackBarValue);
        return (int)control.Invoke(d, new object[] { control });
      } else {

        return control.Value;
      }
    } catch {

      return -1;
    }
  }

  delegate bool GetCheckedCallback(CheckBox control);
  public static bool GetCheckedValue(CheckBox control) {

    try {
      if (control.InvokeRequired) {

        GetCheckedCallback d = new GetCheckedCallback(GetCheckedValue);
        return (bool)control.Invoke(d, new object[] { control });
      } else {

        return control.Checked;
      }
    } catch {

      return false;
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

  delegate object SetComboBoxSelectedIndexCallback(ComboBox control, int index);
  public static object SetComboBoxSelectedIndex(ComboBox control, int index) {

    if (control.InvokeRequired) {

      SetComboBoxSelectedIndexCallback d = new SetComboBoxSelectedIndexCallback(SetComboBoxSelectedIndex);
      return control.Invoke(d, new object[] { control, index });
    } else {

      return control.SelectedIndex = index;
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

  delegate void SetComboBoxSelectedItemCallback(ComboBox control, object value);
  public static void SetComboBoxSelectedItem(ComboBox control, object value) {

    if (control.InvokeRequired) {

      SetComboBoxSelectedItemCallback d = new SetComboBoxSelectedItemCallback(SetComboBoxSelectedItem);
      control.Invoke(d, new object[] { control, value });
    } else {

      control.SelectedItem = value;
    }
  }

  delegate int GetComboBoxSelectedIndexCallback(ComboBox control);
  public static int GetComboBoxSelectedIndex(ComboBox control) {

    if (control.InvokeRequired) {

      GetComboBoxSelectedIndexCallback d = new GetComboBoxSelectedIndexCallback(GetComboBoxSelectedIndex);
      return (int)control.Invoke(d, new object[] { control });
    } else {

      return control.SelectedIndex;
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

  delegate void SetFocusCallback(Control control);
  public static void SetFocus(Control control) {

    if (control.InvokeRequired) {

      SetFocusCallback d = new SetFocusCallback(SetFocus);
      control.Invoke(d, new object[] { control });
    } else {

      control.Focus();
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

  delegate void SetWindowStateCallback(Form form, FormWindowState windowState);
  public static void SetWindowState(Form form, FormWindowState windowState) {

    if (form.InvokeRequired) {

      SetWindowStateCallback d = new SetWindowStateCallback(SetWindowState);
      form.Invoke(d, new object[] { form, windowState });
    } else {

      form.WindowState = windowState;
    }
  }

  delegate void SetWindowResumeLayoutCallback(Form form);
  public static void SetWindowResumeLayout(Form form) {

    if (form.InvokeRequired) {

      SetWindowResumeLayoutCallback d = new SetWindowResumeLayoutCallback(SetWindowResumeLayout);
      form.Invoke(d, new object[] { form });
    } else {

      form.ResumeLayout();
    }
  }

  delegate void SetWindowBringToFrontCallback(Form form);
  public static void SetWindowBringToFront(Form form) {

    if (form.InvokeRequired) {

      SetWindowBringToFrontCallback d = new SetWindowBringToFrontCallback(SetWindowBringToFront);
      form.Invoke(d, new object[] { form });
    } else {

      form.BringToFront();
    }
  }

  delegate void SetWindowBoundsCallback(Form form, Rectangle bounds);
  public static void SetWindowBounds(Form form, Rectangle bounds) {

    if (form.InvokeRequired) {

      SetWindowBoundsCallback d = new SetWindowBoundsCallback(SetWindowBounds);
      form.Invoke(d, new object[] { form, bounds });
    } else {

      form.Bounds = bounds;
    }
  }

  delegate void SetBorderStyleCallback(PictureBox form, BorderStyle borderStyle);
  public static void SetBorderStyle(PictureBox form, BorderStyle borderStyle) {

    if (form.InvokeRequired) {

      SetBorderStyleCallback d = new SetBorderStyleCallback(SetBorderStyle);
      form.Invoke(d, new object[] { form, borderStyle });
    } else {

      form.BorderStyle = borderStyle;
    }
  }

  delegate void SetWindowBorderStyleCallback(Form form, FormBorderStyle borderStyle);
  public static void SetWindowBorderStyle(Form form, FormBorderStyle borderStyle) {

    if (form.InvokeRequired) {

      SetWindowBorderStyleCallback d = new SetWindowBorderStyleCallback(SetWindowBorderStyle);
      form.Invoke(d, new object[] { form, borderStyle });
    } else {

      form.FormBorderStyle = borderStyle;
    }
  }

  delegate void SetToolStripTextCallback(ToolStrip control, string text);
  public static void SetToolStripText(ToolStrip control, string text) {

    if (control.InvokeRequired) {

      SetToolStripTextCallback d = new SetToolStripTextCallback(SetToolStripText);
      control.Invoke(d, new object[] { control, text });
    } else {

      control.Items[0].Text = text;
    }
  }

  delegate void SetRefreshCallback(Control control);
  public static void SetRefresh(Control control) {

    if (control.InvokeRequired) {

      SetRefreshCallback d = new SetRefreshCallback(SetRefresh);
      control.Invoke(d, new object[] { control });
    } else {

      control.Refresh();
    }
  }

  delegate void SetValueCallback4(TrackBar control, int value);
  public static void SetValue(TrackBar control, int value) {

    try {
      if (control.InvokeRequired) {

        SetValueCallback4 d = new SetValueCallback4(SetValue);
        control.Invoke(d, new object[] { control, value });
      } else {

        if (!control.IsDisposed)
          control.Value = value;
      }
    } catch {
    }
  }

  delegate void SetTextCallback(Control control, object text, params object[] parameters);
  public static void SetText(Control control, object text, params object[] parameters) {

    try {

      if (control.InvokeRequired) {

        SetTextCallback d = new SetTextCallback(SetText);
        control.Invoke(d, new object[] { control, text, parameters });
      } else {

        control.Text = string.Format(text.ToString(), parameters);
      }
    } catch {
    }
  }

  delegate void SetImageCallback(PictureBox control, Image image);
  public static void SetImage(PictureBox control, Image image) {

    try {

      if (control.InvokeRequired) {

        SetImageCallback d = new SetImageCallback(SetImage);
        control.Invoke(d, new object[] { control, image });
      } else {

        control.Image = image;
      }
    } catch {
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

  delegate void SetItemSortCallback(ComboBox control);
  public static void SetItemSort(ComboBox control) {

    if (control.InvokeRequired) {

      SetItemSortCallback d = new SetItemSortCallback(SetItemSort);
      control.Invoke(d, new object[] { control });
    } else {

      control.Sorted = true;
    }
  }

  delegate void SetItemAddCallback(ComboBox control, object item);
  public static void SetItemAdd(ComboBox control, object item) {

    if (control.InvokeRequired) {

      SetItemAddCallback d = new SetItemAddCallback(SetItemAdd);
      control.Invoke(d, new object[] { control, item });
    } else {

      control.Items.Add(item);
    }
  }

  delegate void SetItemAddCallback2(ListBox control, object item);
  public static void SetItemAdd(ListBox control, object item) {

    if (control.InvokeRequired) {

      SetItemAddCallback2 d = new SetItemAddCallback2(SetItemAdd);
      control.Invoke(d, new object[] { control, item });
    } else {

      control.Items.Add(item);
    }
  }

  delegate void SetItemsClearCallback(ComboBox control);
  public static void SetItemsClear(ComboBox control) {

    if (control.InvokeRequired) {

      SetItemsClearCallback d = new SetItemsClearCallback(SetItemsClear);
      control.Invoke(d, new object[] { control });
    } else {

      control.Items.Clear();
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

    try {

      if (control.InvokeRequired) {

        SetAppendTextCallback1 d = new SetAppendTextCallback1(SetAppendText);
        control.Invoke(d, new object[] { control, newLine, text, param });
      } else {

        control.AppendText(string.Format(text, param));

        if (newLine)
          control.AppendText(Environment.NewLine);
      }
    } catch {
    }
  }

  delegate void SetAppendTextCallback2(TextBox control, bool newLine, int maxLineCount, string text, params object[] param);
  public static void SetAppendText(TextBox control, bool newLine, int maxLineCount, string text, params object[] param) {

    if (control.InvokeRequired) {

      SetAppendTextCallback2 d = new SetAppendTextCallback2(SetAppendText);

      if (!control.IsDisposed)
        control.Invoke(d, new object[] { control, newLine, maxLineCount, text, param });
    } else {

      if (!control.IsDisposed && control.Lines.Length > maxLineCount)
        control.Clear();

      if (!control.IsDisposed)
        control.AppendText(string.Format(text, param));

      if (!control.IsDisposed && newLine)
        control.AppendText(Environment.NewLine);
    }
  }

  delegate void SetForeColorCallback(Control control, Color foreColor);
  public static void SetForeColor(Control control, Color foreColor) {

    try {

      if (control.InvokeRequired) {

        SetForeColorCallback d = new SetForeColorCallback(SetForeColor);
        control.Invoke(d, new object[] { control, foreColor });
      } else {

        control.ForeColor = foreColor;
      }
    } catch {
    }
  }

  delegate void SetLinkColorCallback(LinkLabel control, Color foreColor);
  public static void SetLinkColor(LinkLabel control, Color foreColor) {

    if (control.InvokeRequired) {

      SetLinkColorCallback d = new SetLinkColorCallback(SetLinkColor);
      control.Invoke(d, new object[] { control, foreColor });
    } else {

      control.LinkColor = foreColor;
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

  delegate void AddControlCallback(Control master, Control control);
  public static void AddControl(Control master, Control control) {

    if (control.InvokeRequired) {

      AddControlCallback d = new AddControlCallback(AddControl);
      control.Invoke(d, new object[] { master, control });
    } else {

      master.Controls.Add(control);
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

  delegate void SetProgressBarValueCallback(ProgressBar control, int value);
  public static void SetProgressBarValue(ProgressBar control, int value) {

    if (control.InvokeRequired) {

      SetProgressBarValueCallback d = new SetProgressBarValueCallback(SetProgressBarValue);
      control.Invoke(d, new object[] { control, value });
    } else {

      control.Value = value;
    }
  }

  delegate void SetProgressBarMaximumCallback(ProgressBar control, int value);
  public static void SetProgressBarMaximum(ProgressBar control, int value) {

    if (control.InvokeRequired) {

      SetProgressBarMaximumCallback d = new SetProgressBarMaximumCallback(SetProgressBarMaximum);
      control.Invoke(d, new object[] { control, value });
    } else {

      control.Maximum = value;
    }
  }

  delegate void SetToolStripProgressBarIncrementCallback(StatusStrip statusStrip, ToolStripProgressBar control, int steps);
  public static void SetToolStripProgressBarIncrement(StatusStrip statusStrip, ToolStripProgressBar control, int steps) {

    if (statusStrip.InvokeRequired) {

      SetToolStripProgressBarIncrementCallback d = new SetToolStripProgressBarIncrementCallback(SetToolStripProgressBarIncrement);
      statusStrip.Invoke(d, new object[] { statusStrip, control, steps });
    } else {

      control.Increment(steps);
    }
  }

  delegate void SetProgressBarIncrementCallback(ProgressBar control, int steps);
  public static void SetProgressBarIncrement(ProgressBar control, int steps) {

    if (control.InvokeRequired) {

      SetProgressBarIncrementCallback d = new SetProgressBarIncrementCallback(SetProgressBarIncrement);
      control.Invoke(d, new object[] { control, steps });
    } else {

      control.Increment(steps);
      control.Update();
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

  delegate void SetOpacityCallback(Form form, double opacity);
  public static void SetOpacity(Form form, double opacity) {

    try {

      if (form.InvokeRequired) {

        SetOpacityCallback d = new SetOpacityCallback(SetOpacity);
        form.Invoke(d, new object[] { form, opacity });
      } else {

        form.Opacity = opacity;
      }
    } catch {
    }
  }

  delegate void ClearControlsback(Control control);
  public static void ClearControls(Control control) {

    if (control.InvokeRequired) {

      ClearControlsback d = new ClearControlsback(ClearControls);
      control.Invoke(d, new object[] { control });
    } else {

      control.Controls.Clear();
    }
  }

  delegate void DisposeControlback(Control control);
  public static void DisposeControl(Control control) {

    if (control.InvokeRequired) {

      DisposeControlback d = new DisposeControlback(DisposeControl);
      control.Invoke(d, new object[] { control });
    } else {

      control.Dispose();
    }
  }

  delegate void ShowFormback(Form form);
  public static void ShowForm(Form form) {

    if (form.InvokeRequired) {

      ShowFormback d = new ShowFormback(ShowForm);
      form.Invoke(d, new object[] { form });
    } else {

      form.Show();
    }
  }

  delegate void ShowUserControlback(UserControl uc);
  public static void ShowUserControl(UserControl uc) {

    if (uc.InvokeRequired) {

      ShowUserControlback d = new ShowUserControlback(ShowUserControl);
      uc.Invoke(d, new object[] { uc });
    } else {

      uc.Show();
    }
  }

  delegate int GetUserControlHeightback(UserControl uc);
  public static int GetUserControlHeight(UserControl uc) {

    try {

      if (uc.InvokeRequired) {

        GetUserControlHeightback d = new GetUserControlHeightback(GetUserControlHeight);
        return (int)uc.Invoke(d, new object[] { uc });
      } else {

        return uc.Height;
      }
    } catch {

      return -1;
    }
  }

  delegate void SetUserControlHeightback(UserControl uc, int height);
  public static void SetUserControlHeight(UserControl uc, int height) {

    if (uc.InvokeRequired) {

      SetUserControlHeightback d = new SetUserControlHeightback(SetUserControlHeight);
      uc.Invoke(d, new object[] { uc, height });
    } else {

      uc.Height = height;
    }
  }

  delegate void HideUserControlback(UserControl uc);
  public static void HideUserControl(UserControl uc) {

    if (uc.InvokeRequired) {

      HideUserControlback d = new HideUserControlback(HideUserControl);
      uc.Invoke(d, new object[] { uc });
    } else {

      uc.Hide();
    }
  }

  delegate void HideFormback(Form form);
  public static void HideForm(Form form) {

    if (form.InvokeRequired) {

      HideFormback d = new HideFormback(HideForm);
      form.Invoke(d, new object[] { form });
    } else {

      form.Hide();
    }
  }

  delegate void ShowDialogFormback(Form form);
  public static void ShowDialogForm(Form form) {

    if (form.InvokeRequired) {

      ShowDialogFormback d = new ShowDialogFormback(ShowDialogForm);
      form.Invoke(d, new object[] { form });
    } else {

      form.ShowDialog();
    }
  }

  delegate void CloseFormback(Form form);
  public static void CloseForm(Form form) {

    if (form.InvokeRequired) {

      CloseFormback d = new CloseFormback(CloseForm);
      form.Invoke(d, new object[] { form });
    } else {

      form.Close();
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
