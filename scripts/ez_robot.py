import zmq
import cv2
import numpy as np
import time

class ez_robot:
    def __init__(self):
        self.context = zmq.Context()
        self.subscriber = None
        self.requester  = None
        self.subscription = None
        
    def subscribe(self,subscription=b"Img"):
        if  self.requester :
            print( "Already in RequestMode" )
            return
        self.subscriber = self.context.socket( zmq.SUB )
        self.subscriber.connect( "tcp://localhost:5563" )
        self.subscription = subscription
        self.subscriber.setsockopt(zmq.SUBSCRIBE, subscription)
        
    def set_request_mode(self):
        if  self.subscriber :
            print( "Already Subscribed" )
            return
        self.requester = self.context.socket( zmq.REQ )
        self.requester.connect( "tcp://localhost:5555" )

    def send_command(self,command,resp=True):
        self.requester.send( command )
        if resp:
            message = self.requester.recv()
            return message

    def spin_x_deg(self,x):
        msg = self.send_command("send:{}".format(x))
        print(msg)

    def get_servo_speed_fastest(self):
        msg = self.send_command("get_servo_speed_fastest:")
        print(msg)
        return msg

    def get_servo_speed_slowest(self):
        msg = self.send_command("get_servo_speed_slowest:")
        print(msg)
        return msg

    def get_servo_max_const(self):
        msg = self.send_command("get_servo_speed_slowest:")
        print(msg)
        return msg

    def get_servo_max_const(self):
        msg = self.send_command("get_servo_speed_slowest:")
        print(msg)
        return msg

    def get_servo_min_const(self):
        msg = self.send_command("get_servo_min_const:")
        print(msg)
        return msg

    def get_servo_off(self):
        msg = self.send_command("get_servo_off:")
        print(msg)
        return msg

    def reset_servo_fine_tune(self,servoport):
        self.send_command("reset_servo_fine_tune:"+servoport)
        
    def get_servo_fine_tune(self,servoport):
        msg = self.send_command("get_servo_fine_tune:"+servoport)
        print(msg)
        return msg

    def set_servo_fine_tune(self,servoport,val):
        self.send_command("set_servo_fine_tune:" +','.join([ servoport,val]) )

    def reset_servo_min_limits(self):
        self.send_command("reset_servo_min_limits:" )
        
    def get_servo_min(self,servoport):
        msg = self.send_command('get_servo_min:'+servoport)
        print(msg)
        return msg

    def set_servo_min(self,servoport,val):
        self.send_command("set_servo_min:"+','.join([servoport,str(val)]) )

    def reset_servo_max_limits(self):
        self.send_command('reset_servo_max_limits:')

    def get_servo_max(self,servoport):
        msg = self.send_command('get_servo_max:'+servoport)
        print(msg)
        return msg

    def set_servo_max(self,servoport,val):
        self.send_command('set_servo_max:'+','.join([servoport,str(val)]) )


    def set_servo_position_speed(self,servoport,pos,speed):
        self.send_command("set_servo_position_speed:"+','.join([servoport,str(pos),str(speed)]))

    def set_servo_position(self,servoport,pos):
        msg = self.send_command("set_servo_position:"+','.join([servoport,str(pos)]))
        print(msg)
    def set_servo_speed(self,servoport,spd):
        self.send_command("set_servo_speed:"+','.join([servoport,spd]))

    def set_multi_servo_speed(self,ports,speed):
        self.send_command("set_multi_servo_speed:" + ','.join(['['+','.join(ports)+']',speed]))
    def get_servo_speed(self,servoport):
        msg = self.send_command("get_servo_speed:" + servoport)
        print(msg)
        return msg

    def get_servo_position(self,servoport):
        msg = self.send_command("get_servo_position:"+servoport)
        print(msg)
        return msg

    def release_servo(self,servoport):
        self.send_command("release_servo:"+servoport)

    def release_all_servos(self):
        self.send_command("release_all_servos:")

    def reset_all_servo_speeds(self):
        self.send_command("rest_all_servo_speeds:")

        
    def wait_for_img(self):
        img = None
        while img is None:
            try:
                topic, data = self.subscriber.recv_multipart(flags=zmq.NOBLOCK)
                assert topic == self.subscription, "Wrong Topic"

                buff = np.fromstring( data, dtype=np.uint8 )
                img  = cv2.imdecode( buff, 1 )
            
            except zmq.Again as e:
                time.sleep(0.01)
        
        return img

    def servo_test(self):
        self.set_request_mode()
        import time
        #Test for the 360 servo position
        for x in xrange(100):
            zero = 90
            differential = 2 if (x%2) ==0 else -2
            self.set_servo_position('D1',zero + differential)
            time.sleep(0.1)
        self.set_servo_position('D1',zero)
