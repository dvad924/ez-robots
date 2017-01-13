using System;
using System.IO;
using EZ_B;
using System.Threading;
using KeyJ;


using ZeroMQ;

namespace ROS_EXT {

    public class ROSActions
    {
        static ZSocket _publisher;
        public static void VideoThread ()
        {
            Console.WriteLine("Starting Video Server");
            ZContext context = new ZContext();
            ZSocket publisher = new ZSocket(context,ZSocketType.PUB);
            
            publisher.Linger = TimeSpan.Zero;
            publisher.Bind("tcp://*:5563");

            _publisher = publisher;
            Thread.Sleep(1000);


            Console.WriteLine("Publishing");
            Ez_Bot bot = new Ez_Bot();
            string url = "192.168.1.1";
            int port = 24;
            bot.init(url);
            bot.camConnect( url, port );
            bot.setSocket( _publisher );
            bot.setImgCb();
            
            
        }
        public static void Main()
        {
            //Start background video handling thread for video events
            Thread t = new Thread ( new ThreadStart( VideoThread ) );
            t.Start();

            while(true)
            {
                Thread.Sleep(1);
            }
        }

        
    }
    
    public class Ez_Bot {

        static EZB _ezb;
        static int port;
        static EZBv4Video _vid;
        static NanoJPEG nj;
        static int index;
        static int imgcount;
        static int maxindex;
        static ZSocket _socket;
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

        public void setSocket (ZSocket socket)
        {
            _socket = socket;
        }
        
        public void onImageDataReady(byte[] imgdata)
        {
            Console.WriteLine("Image Data Received");
            Console.WriteLine("Len : " + imgdata.Length);
            _socket.SendMore( new ZFrame("Img") );
            _socket.Send( new ZFrame(imgdata) );
        }

        public void setImgCb()
        {
            _vid.OnImageDataReady += onImageDataReady;
        }
        
        public void init (string url) {
            maxindex = 1000;
            index = 0;
            nj   = new NanoJPEG();
            imgcount = 0;
            _ezb = new EZB( "MY_BOOOY" );
            _vid = new EZBv4Video();
            Console.WriteLine("Connecting to EZ-B v4...");
            _ezb.Connect( url );

            if (!_ezb.IsConnected) {

                Console.WriteLine("Unable to connect to EZ-B v4");

                return;
            }
            
        }
        public void camConnect ( string url, int port )
        {
            
            Console.WriteLine("Attempting To Capture Image");
            port = 24;
            _vid.CameraSetting((EZBv4Video.CameraSettingsEnum) 2);
            _vid.Start(_ezb,_ezb.ConnectedEndPointAddress,port);

        }

        public void camDisconnect()
        {
            _vid.Stop();
        }

        public void uninit ()
        {
            _ezb.Disconnect();
        }
        
        public static void Test() {
            
            maxindex = 1000;
            index = 0;
            nj   = new NanoJPEG();

            _ezb = new EZB("MY_BOOOY");
            _vid = new EZBv4Video();
            Console.WriteLine("Connecting to EZ-B v4...");
            _ezb.Connect("192.168.1.1");

            if (!_ezb.IsConnected) {

                Console.WriteLine("Unable to connect to EZ-B v4");

                return;
            }


            Console.WriteLine("Hello World, I am moving servo d0 to position 90!");

            Console.WriteLine("Attempting To Capture Image");

            port = 24;

            _vid.Start(_ezb,_ezb.ConnectedEndPointAddress,port);

            _vid.OnImageDataReady += Video_OnImageDataReady;

            Console.WriteLine("Settings: Res640x480 : " +
                              EZBv4Video.CameraSettingsEnum.Res640x480 == (EZBv4Video.CameraSettingsEnum)2+ "\n");

            _vid.CameraSetting((EZBv4Video.CameraSettingsEnum) 2);



            Thread.Sleep(2000);

            while(true){

            }

            _vid.Stop();

            _ezb.Disconnect();
        }
    }
}
