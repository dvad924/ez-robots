using System;
using System.Windows.Forms;

namespace Tutorial_63___EZTaskScheduler {

  public partial class Form1 : Form {

    EZ_B.EZTaskScheduler _ez;

    public Form1() {

      InitializeComponent();

      _ez = new EZ_B.EZTaskScheduler("EZ Task Scheduler Example");

      // This event is raised when there is an error. Unless you provide proper exception handling in your events (start, run, completed) then this should never be needed
      // An error that occurs in here is bad news bears
      _ez.OnEventError += _ez_OnEventError;

      // The event raised when a task starts
      _ez.OnEventStart += _ez_OnEventStart;

      // The task
      _ez.OnEventToRun += _ez_OnEventToRun;

      // The event raised when a task ends
      _ez.OnEventCompleted += _ez_OnEventCompleted;
    }

    private void button1_Click(object sender, EventArgs e) {

      // We will add a task to scheduler.
      // Send the value of 50 to the task, which will be the number to count down from.
      // Once the task has hit 0, it will exit. 
      // If there are other tasks in the queue, the next in the queue (FIFO) will be executed.

      _ez.StartNew(50);

      Invokers.SetText(label2, _ez.GetTaskCountInQueue);
    }

    void _ez_OnEventStart(int taskId, object o) {

      // When a task starts, this event is raised

      int val = Convert.ToInt16(o);

      Invokers.SetAppendText(textBox1, true, "Task ID: {0} starting with countdown from {1}", taskId, val);

      Invokers.SetText(label2, _ez.GetTaskCountInQueue);
    }

    void _ez_OnEventToRun(int taskId, object o) {

      int val = Convert.ToInt16(o);

      Invokers.SetText(groupBox1, "Current Task Id: {0}", taskId);

      Invokers.SetAppendText(textBox1, true, "Task ID: {0} running. Starting with countdown from {1}", taskId, val);

      for (int x = val; x > 0; x--) {

        Invokers.SetText(label1, x);

        if (_ez.IsCancelRequested) {

          Invokers.SetAppendText(textBox1, true, "Task ID: {0} cancel requested by user", taskId);

          return;
        }

        System.Threading.Thread.Sleep(50);
      }
    }

    void _ez_OnEventCompleted(int taskId, object o) {

      int val = Convert.ToInt16(o);

      Invokers.SetAppendText(textBox1, true, "Task ID: {0} completed with countdown from {1}", taskId, val);
      Invokers.SetAppendText(textBox1, true, string.Empty);

      Invokers.SetText(label2, _ez.GetTaskCountInQueue);
    }

    private void btnCancel_Click(object sender, EventArgs e) {

      _ez.CancelCurrentTask();
    }

    void _ez_OnEventError(int taskId, object o, Exception ex) {

      Invokers.SetAppendText(textBox1, true, "Error from task scheduler:. Task Id: {0}, Exception: {1}", taskId, ex);
    }

    private void btnCancelAll_Click(object sender, EventArgs e) {

      _ez.ClearAllQeuedTasks();
      _ez.CancelCurrentTask();
    }
  }
}
