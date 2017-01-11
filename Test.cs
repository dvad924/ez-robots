using System;
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
 
        _ezb.Servo.SetServoPosition(Servo.ServoPortEnum.D0, 90);

        _ezb.Disconnect();
    }
}
