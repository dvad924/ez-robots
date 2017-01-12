using System;
using System.IO;
using EZ_B;
using System.Threading;
using KeyJ;



public class HelloCamera {
       
    static EZB _ezb;
    static int idk;
    static EZBv4Video _vid;
    static NanoJPEG nj;
    static int index;
    static int maxindex;
    private static void Video_OnImageDataReady(byte[] imdata)
    {
        Console.WriteLine("Array Length " +
                          imdata.Length + " \n");
        
        nj.njDecode(imdata);

        File.WriteAllBytes("/tmp/" + index +".jpg",imdata);
	
	File.WriteAllText("/tmp/" + index + ".finished","");
	
        //Console.WriteLine("Buffer Length " + imbuff.Length +"\n");

	index = index + 1 % maxindex;
            
    }
    
    public static void Main() {
    	maxindex = 1000;
    	index = 0;
	nj   = new NanoJPEG();
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
