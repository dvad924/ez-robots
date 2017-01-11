using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using EZ_B;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

namespace ArscolorVr.Hubs {

  public class VrHub : Hub {

    public static EZB Ezb {
      get;
      set;
    }

    public static Camera Camera {
      get;
      set;
    }

    public override Task OnConnected() {

      if (Ezb == null) {

        Ezb = new EZB();
        Ezb.OnConnectionChange += Ezb_OnConnectionChange;
      }

      if (!Ezb.IsConnected)
        Ezb.Connect("192.168.1.1:23");

      if (Camera == null) {

        Camera = new Camera(Ezb);
        Camera.OnNewFrame += Camera_OnNewFrame;
      }

      if (!Camera.IsActive)
        Camera.StartCamera(new ValuePair("192.168.1.1:24", "192.168.1.1:24"), 640, 480);

      return base.OnConnected();
    }

    public override async Task OnDisconnected(bool stopCalled) {

      if (Ezb != null) {

        Ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D2, 50);
        Ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D1, 50);

        await Task.Delay(1000);

        Ezb.Servo.ReleaseAllServos();

        Ezb.Disconnect();
      }

      return base.OnDisconnected(stopCalled);
    }

    public void ChangePosition(int x, int y) {

      if (Ezb == null || !Ezb.IsConnected)
        return;

      x = 180 - x;
      x = x + 30;
      y = y + 30;
      x = MyRound(x * 80 / 180);
      y = MyRound(y * 80 / 180);

      if (x > 10 && x < 90)
        Ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D2, x);

      if (y > 10 && y < 90)
        Ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D1, y);
    }

    private void Ezb_OnConnectionChange(bool isConnected) {

      if (isConnected) {

        Ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D2, 50);
        Ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D1, 50);
      } else {

        if (Camera != null && Camera.IsActive) 
          Camera.StopCamera();
      }
    }

    private void Camera_OnNewFrame() {

      if (Camera == null || !Camera.IsActive)
        return;

      var base64Image = ImageToBase64(Camera.GetCurrentBitmap, ImageFormat.Jpeg);

      Clients.All.getImage(base64Image);
    }

    private static int MyRound(double d) {

      return (int)(d + 0.5);
    }

    private string ImageToBase64(Image image, ImageFormat format) {

      using (var ms = new MemoryStream()) {

        image.Save(ms, format);

        var imageBytes = ms.ToArray();

        var base64String = Convert.ToBase64String(imageBytes);

        return base64String;
      }
    }
  }
}