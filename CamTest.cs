using System;
using System.IO;
using EZ_B;
using System.Threading;

public class HelloCamera {
       
    static EZB _ezb;
    static int idk;
    static EZBv4Video _vid;
    static int written;

    private static void Video_OnImageDataReady(byte[] imdata)
    {
        Console.WriteLine("Array Length " +
                          imdata.Length + " \n");
        if (written < 1)
            File.WriteAllBytes("./t.jpg",imdata);
        written = 1 ;
        // MemoryStream ms = new MemoryStream(imdata);

        // JpegBitmapDecoder jpbd =
        //     new JpegBitmapDecoder(ms.asRandomAccessStream(),
        //                          BitmapCreateOptions.PreservePixelFormat,
        //                          BitmapCacheOption.Default);
        // WritableBitmap bm =
        //     new WritableBitmap((int)bd.PixelWidth,
        //                        (int)bd.PixelHeight);
            
    }
    
    public static void Main() {
        written = 0;
        _ezb = new EZB("MY_BOOOOY");
        _vid = new EZBv4Video();
        Console.WriteLine("Connecting to EZ-B v4...");

        _ezb.Connect("192.168.1.1");

        if (!_ezb.IsConnected) {

            Console.WriteLine("Unable to connect to EZ-B v4");

            return;
        }

        Console.WriteLine("Hello World, I am moving servo d0 to position 90!");

        Console.WriteLine("Attempting To Capture Image");
        
        idk = 24;
        
        _vid.Start(_ezb,_ezb.ConnectedEndPointAddress,idk);

        _vid.OnImageDataReady += Video_OnImageDataReady;
        
        _vid.CameraSetting(EZBv4Video.CameraSettingsEnum.Res640x480);

        
        
        Thread.Sleep(2000);

        while(true){

        }
        
        _vid.Stop();

        _ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D0, 90);

        _ezb.Disconnect();
    }
}
