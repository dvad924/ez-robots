using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using EZ_B;
using System.IO;
using EZ_B.CameraDetection;
using EZ_B.Joystick;

namespace Robot___Omnibot {

  public partial class Form1 : Form {

    Random _random = new Random();
    Camera _camera;
    Joystick _joystick;

    private bool _joystickMove = false;

    private enum MODE_ENUM {
      Sleeping,
      HeadFollowMotion,
      HeadFollowColor,
      Autonomous,
      NudgeLeft,
      NudgeRight,
      LookRandom,
      TurnToFreedom,
      Picture
    }

    private enum DIRECTION_ENUM {
      Left,
      Right
    }

    static readonly EZ_B.Digital.DigitalPortEnum _CAMERA_PIN          = EZ_B.Digital.DigitalPortEnum.D15;
    static readonly EZ_B.Digital.DigitalPortEnum _PING_TRIGGER_PIN    = EZ_B.Digital.DigitalPortEnum.D1;
    static readonly EZ_B.Digital.DigitalPortEnum _PING_ECHO_PIN       = EZ_B.Digital.DigitalPortEnum.D0;
    static readonly EZ_B.Digital.DigitalPortEnum _RIGHT_EYE_PIN       = EZ_B.Digital.DigitalPortEnum.D13;
    static readonly EZ_B.Digital.DigitalPortEnum _LEFT_EYE_PIN        = EZ_B.Digital.DigitalPortEnum.D12;
    static readonly EZ_B.ADC.ADCPortEnum         _MOTOR_LOAD_SENSE    = EZ_B.ADC.ADCPortEnum.ADC1;
    static readonly EZ_B.Servo.ServoPortEnum     _HEAD_SERVO_PIN      = EZ_B.Servo.ServoPortEnum.D7;
    static readonly EZ_B.Servo.ServoPortEnum     _SCAN_SERVO_PIN      = Servo.ServoPortEnum.D6;


    static readonly int _HEAD_LEFT_MAX  = 25;
    static readonly int _HEAD_CENTER   = 19;
    static readonly int _HEAD_RIGHT_MIN = 12;

    static readonly int _SCAN_LEFT_MAX  = 25;
    static readonly int _SCAN_CENTER   = 19;
    static readonly int _SCAN_RIGHT_MIN = 15;

    // Maximum number of times something is close in distance sensor when stopped before turning around
    static readonly int _IN_FRONT_MAX_BEFORE_TURN_AROUND = 3;

    // This is moving collision detect
    static readonly int _MIN_AUTONOMOUS_COLLISION_INCHES = 8;

    // This is the standing still nearest object
    static readonly int _MIN_OBJECT_IN_FRONT_INCHES = 12;

    // this is the turn to freedom openness
    static readonly int _MIN_TURN_TO_FREEDOM_INCHES = 18;

    // when the motor is stuck, the load will go high, this is the value to determine that we are stuck
    static readonly int _MIN_LOAD_VALUE = 4;

    // Where the image snapshots are saved from the camera
    static readonly string _SNAPSHOT_FOLDER = @"c:\omnibot";

    // ----------------------------------------------------------------------------------------------------------------------------------

    // Direction he is scanning with his micro scanner servo
    bool _scanDirection = false;

    // Counts down to zero for current mode
    int _modeCountDown = 0;

    // An array of the distances. Used for determing which way to go when cruising yo
    int [] _scanArray = new int[Servo.SERVO_MAX + 1];

    // To avoid the timer from launching more than one instance
    bool _inProgress = false;

    // Counts how many times an object is in front before turn around
    int _inFrontTurnAroundCount = 0;

    // Color to be scanning for

    ColorDetection.ColorEnum _cameraColor = ColorDetection.ColorEnum.Red;

    private enum PHRASE_ENUM {
      omnibot_move,
      omnibot_stop,
      omnibot_look_left,
      omnibot_look_right,
      omnibot_look_forward,
      omnibot_turn_around,
      omnibot_follow_red,
      omnibot_follow_blue,
      omnibot_follow_green,
      omnibot_follow_motion,
      omnibot_speak,
      hello_omnibot,
      how_are_you,
      thank_you,
      where_are_you,
      omnibot_follow_me,
      omnibot_move_forward,
      omnibot_explore,
      omnibot_backup,
      omnibot_nudge_left,
      omnibot_nudge_right,
      picture
    };

    public Form1() {

      InitializeComponent();
    }

    private MODE_ENUM currentMode {
      get {
        return (MODE_ENUM)lbModes.SelectedItem;
      }
      set {
        ezbConnect.EZB.Servo.SetServoPosition(_SCAN_SERVO_PIN, _SCAN_CENTER);
        setRandomCountDown();
        lbModes.SelectedItem = value;
      }
    }

    private void log(string txt, params object[] values) {

      try {

        tbLog.AppendText(string.Format(txt, values));
        tbLog.AppendText(Environment.NewLine);
      } catch {
      }
    }

    private void Form1_Load(object sender, EventArgs e) {

      _camera = new Camera(ezbConnect.EZB);

      ezbConnect.EZB.Movement.MovementType = Movement.MovementTypeEnum.HBridge;
      ezbConnect.EZB.Movement.HBridgeLeftWheelTriggerA = EZ_B.Digital.DigitalPortEnum.D2;
      ezbConnect.EZB.Movement.HBridgeLeftWheelTriggerB = EZ_B.Digital.DigitalPortEnum.D3;

      ezbConnect.EZB.Movement.HBridgeRightWheelTriggerA = EZ_B.Digital.DigitalPortEnum.D8;
      ezbConnect.EZB.Movement.HBridgeRightWheelTriggerB = EZ_B.Digital.DigitalPortEnum.D9;

      populateVideoCaptureDeviceList();

      ezbConnect.EZB.HC_SR04.MinPoolTimeMS = 10;

      lblPhrase.Text = string.Empty;
      List<string> phrases = new List<string>();
      foreach (PHRASE_ENUM phrase in Enum.GetValues(typeof(PHRASE_ENUM))) {

        string tmp = phrase.ToString().Replace("_", " ");
        phrases.Add(tmp);
        lblPhrase.Text += tmp + Environment.NewLine;
      }

      ezbConnect.EZB.SpeechSynth.SetDictionaryOfPhrases(phrases.ToArray());
      ezbConnect.EZB.SpeechSynth.OnPhraseRecognized += new EZ_B.SpeechSynth.OnPhraseRecognizedEvent(SpeechSynth_OnPhraseRecognized);
      ezbConnect.EZB.SpeechSynth.StartListening();

      lbModes.Items.Clear();
      foreach (MODE_ENUM item in Enum.GetValues(typeof(MODE_ENUM)))
        lbModes.Items.Add(item);

      btnRefreshJoystick_Click(this, new EventArgs());

      timer1.Interval = 80;
      timer1.Start();

      log("Started");
    }

    private void checkJoystick() {

      _joystick.RefreshState();

      if (_joystick.ButtonStateChanged(4) && currentMode != MODE_ENUM.Sleeping && _joystick.ButtonPressed(4))
        currentMode = MODE_ENUM.Sleeping;

      if (_joystick.ButtonStateChanged(2) && _joystick.ButtonPressed(2))
        currentMode = MODE_ENUM.HeadFollowColor;

      if (cbStop.Checked)
        return;

      if (_joystick.ButtonStateChanged(1) && _joystick.ButtonPressed(1))
        currentMode = MODE_ENUM.Autonomous;

      if (_joystick.AxisXStateChanged() && ezbConnect.EZB.Movement.GetCurrentDirection != Movement.MovementDirectionEnum.Right && _joystick.GetAxisX > Servo.SERVO_MAX - 5) {

        ezbConnect.EZB.Movement.GoRight();
        _joystickMove = true;
      }

      if (_joystick.AxisXStateChanged() && ezbConnect.EZB.Movement.GetCurrentDirection != Movement.MovementDirectionEnum.Left && _joystick.GetAxisX < Servo.SERVO_MIN + 5) {

        ezbConnect.EZB.Movement.GoLeft();
        _joystickMove = true;
      }

      if (_joystick.AxisYStateChanged() && ezbConnect.EZB.Movement.GetCurrentDirection != Movement.MovementDirectionEnum.Reverse && _joystick.GetAxisY > Servo.SERVO_MAX - 5) {

        ezbConnect.EZB.Movement.GoReverse();
        _joystickMove = true;
      }

      if (_joystick.AxisYStateChanged() && ezbConnect.EZB.Movement.GetCurrentDirection != Movement.MovementDirectionEnum.Forward && _joystick.GetAxisY < Servo.SERVO_MIN + 5) {

        ezbConnect.EZB.Movement.GoForward();
        _joystickMove = true;
      }

      if (_joystickMove &&
          ezbConnect.EZB.Movement.GetCurrentDirection != Movement.MovementDirectionEnum.Stop
          && _joystick.GetAxisX > Servo.SERVO_MIN + 5
          && _joystick.GetAxisX < Servo.SERVO_MAX - 5
          && _joystick.GetAxisY > Servo.SERVO_MIN + 5
          && _joystick.GetAxisY < Servo.SERVO_MAX - 5) {

        ezbConnect.EZB.Movement.GoStop();
        _joystickMove = false;
      }
    }

    private void ezB_Connect1_OnConnection() {

      currentMode = MODE_ENUM.Sleeping;

      ezbConnect.EZB.Digital.SetDigitalPort(_LEFT_EYE_PIN, true);
      ezbConnect.EZB.Digital.SetDigitalPort(_RIGHT_EYE_PIN, true);

      buttonStop_Click(this, new EventArgs());

      lookStraight();

      ezbConnect.EZB.Servo.SetServoPosition(_SCAN_SERVO_PIN, _SCAN_CENTER);
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

      timer1.Stop();

      buttonStop_Click(this, new EventArgs());
    }

    private void populateVideoCaptureDeviceList() {

      cbVideoDevices.Items.Clear();
      cbVideoDevices.Items.AddRange(Camera.GetVideoCaptureDevices());

      // Select the last device in the list to automatically start the video
      cbVideoDevices.SelectedIndex = cbVideoDevices.Items.Count - 1;
    }

    void SpeechSynth_OnPhraseRecognized(string text, float confidence) {

      if (cbListen.Checked)
        return;

      if (confidence < 0.90)
        return;

      log("{0} {1}", confidence, text);

      text = text.Replace(" ", "_");

      if (text == PHRASE_ENUM.omnibot_move.ToString()) {

        currentMode = MODE_ENUM.Autonomous;
        _modeCountDown = 20;
      } else if (text == PHRASE_ENUM.omnibot_stop.ToString()) {

        buttonStop_Click(this, new EventArgs());
        currentMode = MODE_ENUM.Sleeping;
      } else if (text == PHRASE_ENUM.omnibot_look_left.ToString()) {

        lookLeft();
      } else if (text == PHRASE_ENUM.omnibot_look_right.ToString()) {

        lookRight();
      } else if (text == PHRASE_ENUM.omnibot_look_forward.ToString()) {

        lookStraight();
      } else if (text == PHRASE_ENUM.omnibot_turn_around.ToString()) {

        currentMode = MODE_ENUM.Sleeping;
        turnAround();
      } else if (text == PHRASE_ENUM.omnibot_follow_red.ToString()) {

        _cameraColor = ColorDetection.ColorEnum.Red;
        currentMode = MODE_ENUM.HeadFollowColor;
      } else if (text == PHRASE_ENUM.omnibot_follow_blue.ToString()) {

        _cameraColor = ColorDetection.ColorEnum.Blue;
        currentMode = MODE_ENUM.HeadFollowColor;
      } else if (text == PHRASE_ENUM.omnibot_follow_green.ToString()) {

        _cameraColor = ColorDetection.ColorEnum.Green;
        currentMode = MODE_ENUM.HeadFollowColor;
      } else if (text == PHRASE_ENUM.omnibot_follow_motion.ToString() || text == PHRASE_ENUM.omnibot_follow_me.ToString()) {

        currentMode = MODE_ENUM.HeadFollowMotion;
      } else if (text == PHRASE_ENUM.omnibot_move_forward.ToString()) {

        lookStraight();
        buttonForward_Click(this, new EventArgs());
        System.Threading.Thread.Sleep(1500);
        buttonStop_Click(this, new EventArgs());
      } else if (text == PHRASE_ENUM.omnibot_explore.ToString()) {

        currentMode = MODE_ENUM.Autonomous;
      } else if (text == PHRASE_ENUM.omnibot_backup.ToString()) {

        lookStraight();
        buttonBack_Click(this, new EventArgs());
        System.Threading.Thread.Sleep(1500);
        buttonStop_Click(this, new EventArgs());
      } else if (text == PHRASE_ENUM.omnibot_nudge_left.ToString()) {

        currentMode = MODE_ENUM.NudgeLeft;
      } else if (text == PHRASE_ENUM.omnibot_nudge_right.ToString()) {

        currentMode = MODE_ENUM.NudgeRight;
      } else if (text == PHRASE_ENUM.picture.ToString()) {

        btnSnapshot_Click(this, new EventArgs());
      }
    }

    private void setRandomCountDown() {

      _modeCountDown = _random.Next(1, 20) * 10;
    }

    private void buttonForward_Click(object sender, EventArgs e) {

      if (cbStop.Checked)
        return;

      if (ezbConnect.EZB.Movement.GetCurrentDirection == Movement.MovementDirectionEnum.Forward)
        return;

      lookStraight();

      ezbConnect.EZB.Movement.GoForward();
    }

    private void buttonRight_Click(object sender, EventArgs e) {

      if (cbStop.Checked)
        return;

      if (ezbConnect.EZB.Movement.GetCurrentDirection == Movement.MovementDirectionEnum.Right)
        return;

      ezbConnect.EZB.Movement.GoRight();
    }

    private void buttonBack_Click(object sender, EventArgs e) {

      if (cbStop.Checked)
        return;

      if (ezbConnect.EZB.Movement.GetCurrentDirection == Movement.MovementDirectionEnum.Reverse)
        return;

      ezbConnect.EZB.Movement.GoReverse();
    }

    private void buttonLeft_Click(object sender, EventArgs e) {

      if (cbStop.Checked)
        return;

      if (ezbConnect.EZB.Movement.GetCurrentDirection == Movement.MovementDirectionEnum.Left)
        return;

      ezbConnect.EZB.Movement.GoLeft();
    }

    private void buttonStop_Click(object sender, EventArgs e) {

      if (ezbConnect.EZB.Movement.GetCurrentDirection == Movement.MovementDirectionEnum.Stop)
        return;

      ezbConnect.EZB.Movement.GoStop();
    }

    private void cbVideoDevices_SelectedIndexChanged(object sender, EventArgs e) {

      ValuePair videoCaptureDevice = (ValuePair)cbVideoDevices.SelectedItem;

      _camera.StartCamera(videoCaptureDevice, panel1, 160, 120);
    }

    private void tbHead_Scroll(object sender, EventArgs e) {

      ezbConnect.EZB.Servo.SetServoPosition(_HEAD_SERVO_PIN, tbHead.Value);
    }

    private void turnAround() {

      if (_random.Next(1, 10) > 5) {

        lookRight();

        buttonRight_Click(this, new EventArgs());
      } else {

        lookLeft();

        buttonLeft_Click(this, new EventArgs());
      }

      System.Threading.Thread.Sleep(1150);

      buttonStop_Click(this, new EventArgs());

      lookStraight();
    }

    private void lookLeft() {

      ezbConnect.EZB.Servo.SetServoPosition(_HEAD_SERVO_PIN, _HEAD_LEFT_MAX);
    }

    private void lookRight() {

      ezbConnect.EZB.Servo.SetServoPosition(_HEAD_SERVO_PIN, _HEAD_RIGHT_MIN);
    }

    private void lookStraight() {

      ezbConnect.EZB.Servo.SetServoPosition(_HEAD_SERVO_PIN, _HEAD_CENTER);
    }

    private void randomMode() {

      int modeCnt = Enum.GetValues(typeof(MODE_ENUM)).Length;

      int newMode = _random.Next(0, modeCnt);

      currentMode = (MODE_ENUM)newMode;
    }

    private DIRECTION_ENUM getAvailableDirection() {

      int totalLeft = 0;
      int totalRight = 0;

      if (ezbConnect.EZB.Servo.GetServoPosition(_SCAN_SERVO_PIN) < _SCAN_CENTER) {

        for (int x = _SCAN_RIGHT_MIN; x <= _SCAN_LEFT_MAX; x += 2) {

          ezbConnect.EZB.Servo.SetServoPosition(_SCAN_SERVO_PIN, x);
          ezbConnect.EZB.Servo.SetServoPosition(_HEAD_SERVO_PIN, x);

          int distance = getDistance();

          if (x <= _SCAN_CENTER)
            totalRight += distance;
          else
            totalLeft += distance;
        }
      } else {

        for (int x = _SCAN_LEFT_MAX; x >= _SCAN_RIGHT_MIN; x -= 2) {

          ezbConnect.EZB.Servo.SetServoPosition(_SCAN_SERVO_PIN, x);
          ezbConnect.EZB.Servo.SetServoPosition(_HEAD_SERVO_PIN, x);

          int distance = getDistance();

          if (x <= _SCAN_CENTER)
            totalRight += distance;
          else
            totalLeft += distance;
        }
      }

      ezbConnect.EZB.Servo.SetServoPosition(_SCAN_SERVO_PIN, _SCAN_CENTER);
      ezbConnect.EZB.Servo.SetServoPosition(_HEAD_SERVO_PIN, _HEAD_CENTER);

      log("left: {0}, right: {1}", totalLeft, totalRight);

      if (totalLeft > totalRight)
        return DIRECTION_ENUM.Left;

      return DIRECTION_ENUM.Right;
    }

    private void nudgeTowardsFreedom() {

      int totalLeft = 0;
      int totalRight = 0;

      string tmp = string.Empty;

      for (int x = _SCAN_RIGHT_MIN; x <= _SCAN_LEFT_MAX; x++) {

        if (x <= _SCAN_CENTER)
          totalRight += _scanArray[x];
        else
          totalLeft += _scanArray[x];

        tmp += _scanArray[x].ToString() + "-";
      }

      tmp += string.Format("({0},{1})", totalRight, totalLeft);

      log(tmp);

      if (totalRight < 80 && totalLeft < 80)
        turnAround();

      if (totalRight > 90 && totalLeft > 90)
        return;

      if (totalLeft > totalRight)
        buttonLeft_Click(this, new EventArgs());

      if (totalRight > totalLeft)
        buttonRight_Click(this, new EventArgs());
    }

    private void scanArrayClear() {

      for (int x=0; x < _scanArray.Length; x++)
        _scanArray[x] = 0;
    }

    private void doMoveScanner() {

      int scanPosition = ezbConnect.EZB.Servo.GetServoPosition(_SCAN_SERVO_PIN);

      if (_scanDirection)
        scanPosition += 2;
      else
        scanPosition -= 2;

      if (scanPosition >= _SCAN_LEFT_MAX) {

        _scanDirection = false;
        nudgeTowardsFreedom();
        scanArrayClear();
      } else if (scanPosition <= _SCAN_RIGHT_MIN) {

        _scanDirection = true;
        nudgeTowardsFreedom();
        scanArrayClear();
      }

      ezbConnect.EZB.Servo.SetServoPosition(_SCAN_SERVO_PIN, scanPosition);
    }

    private void doAutonomous() {

      doMoveScanner();

      int distance = getDistance();

      if (distance > _MIN_AUTONOMOUS_COLLISION_INCHES) {

        buttonForward_Click(this, new EventArgs());
      } else if (distance == -1) {

        log("Stuck");

        buttonBack_Click(this, new EventArgs());

        System.Threading.Thread.Sleep(1000);

        turnAround();

        doTurnToFreedom();
      } else if (distance < _MIN_AUTONOMOUS_COLLISION_INCHES) {

        log("Distance: {0}", distance);

        _modeCountDown -= 5;

        buttonStop_Click(this, new EventArgs());

        DIRECTION_ENUM availableDir = getAvailableDirection();

        log("AvailDir: {0}", availableDir);

        buttonBack_Click(this, new EventArgs());

        System.Threading.Thread.Sleep(1000);

        if (availableDir == DIRECTION_ENUM.Left) {

          lookLeft();
          buttonLeft_Click(this, new EventArgs());
        } else {

          lookRight();
          buttonRight_Click(this, new EventArgs());
        }
      }
    }

    private void doFollowColor() {

      ObjectLocation [] objectLocations = _camera.CameraBasicColorDetection.GetObjectLocationByColor(false, _cameraColor, 10, (byte)tbColorBrightness.Value);

      if (objectLocations.Length == 0)
        return;

      ObjectLocation objectLocation = objectLocations[0];

      int position = ezbConnect.EZB.Servo.GetServoPosition(_HEAD_SERVO_PIN);

      if (objectLocation.HorizontalLocation == ObjectLocation.HorizontalLocationEnum.Left)
        position++;
      else if (objectLocation.HorizontalLocation == ObjectLocation.HorizontalLocationEnum.Right)
        position--;

      ezbConnect.EZB.Servo.SetServoPosition(_HEAD_SERVO_PIN, position);

      if (_random.Next(0, 15) == 5)
        btnSnapshot_Click(this, new EventArgs());
    }

    private void doTurnBodyWithHead() {

      int position = ezbConnect.EZB.Servo.GetServoPosition(_HEAD_SERVO_PIN);

      if (position > _HEAD_LEFT_MAX) {

        buttonLeft_Click(this, new EventArgs());
        System.Threading.Thread.Sleep(150);
        buttonStop_Click(this, new EventArgs());
        lookStraight();
      }

      if (position < _HEAD_RIGHT_MIN) {

        buttonRight_Click(this, new EventArgs());
        System.Threading.Thread.Sleep(150);
        buttonStop_Click(this, new EventArgs());
        lookStraight();
      }
    }

    private void doFollowMotion() {

      ObjectLocation [] objectLocations = _camera.CameraMotionDetection.GetMotionDetection(tbMotionDifference.Value, tbMotionCount.Value, 0);

      if (objectLocations.Length == 0)
        return;

      ObjectLocation objectLocation = objectLocations[0];

      int position = ezbConnect.EZB.Servo.GetServoPosition(_HEAD_SERVO_PIN);

      if (objectLocation.HorizontalLocation == ObjectLocation.HorizontalLocationEnum.Left)
        position++;
      else if (objectLocation.HorizontalLocation == ObjectLocation.HorizontalLocationEnum.Right)
        position--;

      ezbConnect.EZB.Servo.SetServoPosition(_HEAD_SERVO_PIN, position);

      if (_random.Next(0, 15) == 5)
        btnSnapshot_Click(this, new EventArgs());
    }

    private void doAvoidObjectInFront() {

      if (getDistance() < _MIN_OBJECT_IN_FRONT_INCHES) {

        if (_random.Next(0, 25) != 4)
          return;

        if (_inFrontTurnAroundCount > _IN_FRONT_MAX_BEFORE_TURN_AROUND) {

          doTurnToFreedom();

          _inFrontTurnAroundCount = 0;
        } else {

          buttonBack_Click(this, new EventArgs());
          System.Threading.Thread.Sleep(300);
          buttonStop_Click(this, new EventArgs());

          _inFrontTurnAroundCount++;
        }
      }
    }

    private void doLookRandomLocation() {

      ezbConnect.EZB.Servo.SetServoPosition(_HEAD_SERVO_PIN, _random.Next(_HEAD_RIGHT_MIN, _HEAD_LEFT_MAX));
    }

    private void doTurnToFreedom() {

      ezbConnect.EZB.Servo.SetServoPosition(_SCAN_SERVO_PIN, _SCAN_CENTER);

      int cnt = 0;

      do {

        int distance = ezbConnect.EZB.HC_SR04.GetValue(_PING_TRIGGER_PIN, _PING_ECHO_PIN);

        if (distance > _MIN_TURN_TO_FREEDOM_INCHES)
          break;

        buttonLeft_Click(this, new EventArgs());

        if (cnt > 10)
          break;

        cnt++;
      } while (true);

      buttonStop_Click(this, new EventArgs());
    }

    private int getDistance() {

      int distance = ezbConnect.EZB.HC_SR04.GetValue(_PING_TRIGGER_PIN, _PING_ECHO_PIN);

      if (distance == -1)
        distance = 99;

      int adc = ezbConnect.EZB.ADC.GetADCValue(_MOTOR_LOAD_SENSE);

      if (adc >= _MIN_LOAD_VALUE)
        distance = -1;

      _scanArray[ezbConnect.EZB.Servo.GetServoPosition(_SCAN_SERVO_PIN)] = distance;

      lblDistance.Text = distance.ToString();

      return distance;
    }

    private void timer1_Tick(object sender, EventArgs e) {

      if (_inProgress)
        return;

      if (!ezbConnect.EZB.IsConnected)
        return;

      _inProgress = true;

      switch (currentMode) {

        case MODE_ENUM.Sleeping:

          doFollowMotion();
          doAvoidObjectInFront();
          break;
        case MODE_ENUM.Autonomous:

          doAutonomous();
          doFollowColor();
          break;
        case MODE_ENUM.HeadFollowColor:

          doAvoidObjectInFront();
          doFollowColor();
          break;
        case MODE_ENUM.HeadFollowMotion:

          doAvoidObjectInFront();
          doFollowMotion();
          break;
        case MODE_ENUM.NudgeLeft:

          buttonLeft_Click(this, new EventArgs());
          System.Threading.Thread.Sleep(50);
          buttonStop_Click(this, new EventArgs());
          currentMode = MODE_ENUM.Sleeping;
          break;
        case MODE_ENUM.NudgeRight:

          buttonRight_Click(this, new EventArgs());
          System.Threading.Thread.Sleep(50);
          buttonStop_Click(this, new EventArgs());
          currentMode = MODE_ENUM.Sleeping;
          break;
        case MODE_ENUM.LookRandom:

          doLookRandomLocation();
          currentMode = MODE_ENUM.Sleeping;
          break;
        case MODE_ENUM.TurnToFreedom:

          doFollowMotion();

          int distance = ezbConnect.EZB.HC_SR04.GetValue(_PING_TRIGGER_PIN, _PING_ECHO_PIN);

          if (distance < _MIN_TURN_TO_FREEDOM_INCHES)
            buttonLeft_Click(this, new EventArgs());
          else
            buttonStop_Click(this, new EventArgs());
          break;
        case MODE_ENUM.Picture:

          btnSnapshot_Click(this, new EventArgs());

          doLookRandomLocation();

          currentMode = MODE_ENUM.Sleeping;
          break;
      }

      doTurnBodyWithHead();

      checkJoystick();

      if (!cbFreezeMode.Checked)
        _modeCountDown--;

      if (_modeCountDown <= 0)
        randomMode();

      lblCountDown.Text = _modeCountDown.ToString();

      Application.DoEvents();

      _inProgress = false;
    }

    private void lbModes_SelectedIndexChanged(object sender, EventArgs e) {

      buttonStop_Click(this, new EventArgs());

      setRandomCountDown();
    }

    private void btnCamera_Click(object sender, EventArgs e) {

      if (ezbConnect.EZB.Digital.GetLastDigitalPortSet(_CAMERA_PIN)) {

        button1.BackColor = System.Drawing.Color.DarkRed;
        ezbConnect.EZB.Digital.SetDigitalPort(_CAMERA_PIN, false);
      } else {

        button1.BackColor = System.Drawing.Color.DarkGreen;
        ezbConnect.EZB.Digital.SetDigitalPort(_CAMERA_PIN, true);
      }
    }

    private void tbMove_keyDown(object sender, KeyEventArgs e) {

      if (ezbConnect.EZB.Movement.GetCurrentDirection != Movement.MovementDirectionEnum.Stop)
        return;

      if (e.KeyCode == Keys.Up)
        buttonForward_Click(this, new EventArgs());
      else if (e.KeyCode == Keys.Right)
        buttonRight_Click(this, new EventArgs());
      else if (e.KeyCode == Keys.Down)
        buttonBack_Click(this, new EventArgs());
      else if (e.KeyCode == Keys.Left)
        buttonLeft_Click(this, new EventArgs());
      else
        buttonStop_Click(this, new EventArgs());
    }

    private void tbMove_KeyUp(object sender, KeyEventArgs e) {

      buttonStop_Click(this, new EventArgs());
    }

    private void btnEyes_Click(object sender, EventArgs e) {

      if (ezbConnect.EZB.Digital.GetLastDigitalPortSet(_LEFT_EYE_PIN)) {

        button2.BackColor = Color.DarkRed;

        ezbConnect.EZB.Digital.SetDigitalPort(_LEFT_EYE_PIN, false);
        ezbConnect.EZB.Digital.SetDigitalPort(_RIGHT_EYE_PIN, false);
      } else {

        button2.BackColor = Color.DarkGreen;

        ezbConnect.EZB.Digital.SetDigitalPort(_LEFT_EYE_PIN, true);
        ezbConnect.EZB.Digital.SetDigitalPort(_RIGHT_EYE_PIN, true);
      }
    }

    private void btnRefreshCameraList_Click(object sender, EventArgs e) {

      populateVideoCaptureDeviceList();
    }

    private void btnSnapshot_Click(object sender, EventArgs e) {

      if (!Directory.Exists(_SNAPSHOT_FOLDER))
        Directory.CreateDirectory(_SNAPSHOT_FOLDER);

      log("Snapshot");

      _camera.SaveImageAsJPEG(Path.Combine(_SNAPSHOT_FOLDER, DateTime.Now.Ticks.ToString() + ".bmp"));
    }

    private void tbScanServo_Change(object sender, EventArgs e) {

      ezbConnect.EZB.Servo.SetServoPosition(_SCAN_SERVO_PIN, tbScanServo.Value);
      log("pos: {0}", tbScanServo.Value);
    }

    private void btnRefreshJoystick_Click(object sender, EventArgs e) {

      JoystickDevice [] devices = Joystick.GetAvailableDevices();

      if (devices.Length == 0)
        return;

      JoystickDevice device = devices[0];

      _joystick = new Joystick(device, ezbConnect.EZB);

      textBox1.Text = device.ToString();
    }
  }
}
