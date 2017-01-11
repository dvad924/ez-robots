Imports EZ_B
Imports EZ_B.CameraDetection
Imports System

Public Class Form1

  Private _stopWatch As New Stopwatch()
  Private _camera As Camera

  Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    _camera = New Camera(EzB_Connect1.EZB)

    AddHandler _camera.OnNewFrame, AddressOf OnNewFrame

    comboBox1.Items.Clear()
    comboBox1.Items.AddRange(Camera.GetVideoCaptureDevices())

    comboBox3.Items.Clear()
    For Each item As ColorDetection.ColorEnum In [Enum].GetValues(GetType(ColorDetection.ColorEnum))
      comboBox3.Items.Add(item)
    Next

    comboBox3.SelectedIndex = 0
  End Sub

  Private Sub comboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles comboBox1.SelectedIndexChanged

    Dim videoCaptureDevice As ValuePair = comboBox1.SelectedItem

    _camera.StartCamera(videoCaptureDevice, panel1, panel2, 320, 240)

    Log("Video started: {0}", videoCaptureDevice)
  End Sub

  Private Sub Log(txt As Object, ParamArray values() As Object)

    tbLog.AppendText(String.Format(txt.ToString(), values))
    tbLog.AppendText(Environment.NewLine)
  End Sub


  Private Sub OnNewFrame()

    _stopWatch.Restart()

    Dim objectLocation As ObjectLocation

    ' Uncomment the type of tracking you wish to use
    'objectLocation = _camera.CameraBasicColorDetection.GetObjectLocationByColor(comboBox3.SelectedItem, tbMinObjectSize.Value, tbBrightness.Value)
    objectLocation = _camera.CameraFaceDetection.GetFaceDetection()
    'objectLocation = _camera.CameraMotionDetection.GetMotionDetection(30, 80)
    'objectLocation = _camera.CameraShapeDetection.GetShapeDetection()

    _camera.UpdatePreview()

    _stopWatch.Stop()

    Log("Detection Took: {0} ticks ({1}ms)", _stopWatch.ElapsedTicks, _stopWatch.ElapsedMilliseconds)

    If (objectLocation.IsObjectFound = False) Then
      Return
    End If

    If (EzB_Connect1.EZB.IsConnected) Then

      Dim position As Integer = EzB_Connect1.EZB.Servo.GetServoPosition(Servo.ServoPortEnum.D12)

      If (objectLocation.horizontalLocation = objectLocation.HorizontalLocationEnum.Left) Then

        position = position + 1

      ElseIf (objectLocation.horizontalLocation = objectLocation.HorizontalLocationEnum.Right) Then

        position = position - 1

      End If

      EzB_Connect1.EZB.Servo.SetServoPosition(Servo.ServoPortEnum.D12, position)

    End If

    Log("Object found at {0} {1}", objectLocation.horizontalLocation, objectLocation.verticalLocation)

  End Sub

End Class
