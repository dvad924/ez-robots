using System;
using System.IO;
using EZ_B;
using System.Threading;
using KeyJ;
using ZeroMQ;

namespace ROS_EXT {


    public class CommandHandler
    {
        public Servo.ServoPortEnum GetPort( string portstr )
        {
            if ( Enum.IsDefined( typeof(Servo.ServoPortEnum), portstr ) )
                return (Servo.ServoPortEnum) Enum.Parse( typeof(Servo.ServoPortEnum ), portstr );
            else
                return Servo.ServoPortEnum.NA;
        }

            
    }
        
    
    public class ROSActions
    {
        static ZSocket _publisher;
        static ZContext _context;
        static Ez_Bot bot;
        public static void VideoThread ()
        {
            Console.WriteLine("Starting Video Server");
            
            ZSocket publisher = new ZSocket(_context,ZSocketType.PUB);
            
            publisher.Linger = TimeSpan.Zero;
            publisher.Bind("tcp://*:5563");

            _publisher = publisher;
            Thread.Sleep(1000);

            Console.WriteLine("Publishing");
            int port = 24;
            string url = "192.168.1.1";
            bot.camConnect( url, port );
            bot.setSocket( _publisher );
            bot.setImgCb();
            
        }
        public static void Main()
        {
            //Start background video handling thread for video events
            _context = new ZContext();
            
            bot = new Ez_Bot();
            string url = "192.168.1.1";
            bot.init(url);

            CommandHandler ch = new CommandHandler();
            
            Thread t = new Thread ( new ThreadStart( VideoThread ) );
            t.Start();
            using( var socket = new ZSocket(_context, ZSocketType.REP) )
            {
                socket.Bind("tcp://*:5555");

                Console.WriteLine("Listening For Commands");
                while(true)
                {
                    using( ZFrame request = socket.ReceiveFrame() )
                    {
                        string command = request.ReadString();
                        int headend = command.IndexOf(":");
                        string cmdhead = command.Substring(0, headend );
                        string optsstr = command.Substring(headend+1,
                                                           command.Length-1-headend);

                        string[] opts  = optsstr.Split(new string[] {","},
                                                       StringSplitOptions.None);
                        
                        string response = "";
                        switch( cmdhead ){
                            case "send":
                                response = "THIS IS A TEST";
                                break;
                            case "get_servo_speed_fastest":
                                response = Servo.SERVO_SPEED_FASTEST.ToString();
                                break;
                            case  "get_servo_speed_slowest":
                                response = Servo.SERVO_SPEED_SLOWEST.ToString();
                                break;
                            case "get_servo_max_const":
                                response = Servo.SERVO_CENTER.ToString();
                                break;
                            case "get_servo_min_const":
                                response = Servo.SERVO_MIN.ToString();
                                break;
                            case "get_servo_off":
                                response = Servo.SERVO_OFF.ToString();
                                break;
                            case "reset_servo_fine_tune":
                                bot._ezb.Servo.ResetServoFineTune();
                                response = "servo_fine_tune_reset";
                                break;
                            case "get_servo_fine_tune":
                                response =
                                    bot._ezb.Servo.GetServoFineTune( ch.GetPort(opts[0]) ).ToString();
                                break;
                            case "set_servo_fine_tune":
                                bot._ezb.Servo.SetServoFineTune(ch.GetPort(opts[0]),
                                                                Int32.Parse(opts[1]) );
                                response = "servo_fine_tune_set";
                                break;
                            case "reset_servo_min_limits":
                                bot._ezb.Servo.ResetServoMinLimits();
                                response = "servo_min_limits_reset";
                                break;
                            case "get_servo_min":
                                response = bot._ezb.Servo.GetServoMin( ch.GetPort(opts[0]) ).ToString();                             
                                break;
                            case "set_servo_min":
                                bot._ezb.Servo.SetServoMin( ch.GetPort(opts[0]),
                                                            Int32.Parse(opts[1]) );
                                response = "servo_min_set";
                                break;
                            case "reset_servo_max_limits":
                                bot._ezb.Servo.ResetServoMaxLimits();
                                response = "servo_max_limits_reset";
                                break;
                            case "get_servo_max":
                                response = bot._ezb.Servo.GetServoMax( ch.GetPort(opts[0]) ).ToString();
                                
                                break;
                            case "set_servo_max":
                                bot._ezb.Servo.SetServoMax( ch.GetPort(opts[0]),
                                                           Int32.Parse(opts[1]) );
                                response = "servo_max_set";
                                break;
                            case "set_servo_position_speed":
                                bot._ezb.Servo.SetServoPosition(ch.GetPort(opts[0]),
                                                                Int32.Parse(opts[1]),
                                                                Int32.Parse(opts[2]) );
                                response = "servo_position_speed_set";
                                break;
                            case "set_servo_position":
                                bot._ezb.Servo.SetServoPosition(ch.GetPort(opts[0]),
                                                                Int32.Parse(opts[1]) );
                                response = "servo_position_set : " + opts[1];
                                break;
                            case "set_servo_speed":
                                bot._ezb.Servo.SetServoSpeed(ch.GetPort(opts[0]),
                                                             Int32.Parse(opts[1]) );
                                response = "servo_speed_set";
                                break;
                            case "set_multi_servo_speed":
                                //bot._ezb.Servo.SetServoSpeed(ch.GetPort(),)
                                break;
                            case "get_servo_speed":
                                response = bot._ezb.Servo.GetServoSpeed( ch.GetPort(opts[0]) ).ToString();
                                break;
                            case "get_servo_position":
                                response = bot._ezb.Servo.GetServoPosition( ch.GetPort(opts[0]) ).ToString();
                                break;
                            case "release_servo":
                                bot._ezb.Servo.ReleaseServo( ch.GetPort(opts[0]) );
                                response = "servo_released";
                                break;
                            case "release_all_servos":
                                bot._ezb.Servo.ReleaseAllServos();
                                response = "all_servos_released";
                                break;
                            case "reset_all_servo_speeds":
                                bot._ezb.Servo.ResetAllServoSpeeds();
                                response = "all_servo_speeds_reset";
                                break;


                            default:
                                Console.WriteLine("Unknown Command: {0}", command );
                                break;
                        }
                            
                        socket.Send(new ZFrame( response ) );
                    }
                }
            }
        }
    }
    
    public class Ez_Bot {

        public EZB _ezb;
        private int port;
        private EZBv4Video _vid;
        static NanoJPEG nj;
        static int index;

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

            Ez_Bot bot = new Ez_Bot();
            bot.init("192.168.1.1");
            

            Console.WriteLine("Hello World, I am moving servo d0 to position 90!");

            Console.WriteLine("Attempting To Capture Image");

            bot.camConnect("192.168.1.1",24);

            bot.setImgCb();
            Thread.Sleep(2000);

            while(true){

            }

            // _vid.Stop();

            // _ezb.Disconnect();
        }
    }
}
