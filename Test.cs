using System;
using System.Threading;
using EZ_B;
  
public class HelloWorld {

    static EZB _ezb;

    public static void Main() {

        _ezb = new EZB("helloRobot");

        Console.WriteLine("Connecting to EZ-B v4...");

        _ezb.Connect("192.168.1.1");

        if (!_ezb.IsConnected) {

            Console.WriteLine("Unable to connect to EZ-B v4");

            return;
        }

        Console.WriteLine("Hello World, I am moving servo d0 to position 90!");
	
 	// for ( int deg = -10; deg < 11 ; deg++  ){
	//     Console.WriteLine("Moving to " + deg);
        //     _ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D0, 90 + deg);
	//     Thread.Sleep(2000);
	// }   
	//_ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D0, 90);
        //Thread.Sleep(2000);
        _ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D1,80,3);

        
        _ezb.Disconnect();
    }
}
