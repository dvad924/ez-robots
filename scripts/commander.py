#! /usr/bin/env python
import os
from glob import glob
import zmq
import cv2
import numpy as np
from Ros_Coms.srv import *
from ez_robot import ez_robot
from multiprocessing import Process
import rospy
from std_msgs.msg import Float64


class Commander:
    def __init__(self):
        #self.cmdr = ez_robot()
        #self.cmdr.set_request_mode()
        
        self.publisher_z = rospy.Publisher('ezbot/joint1_velocity_controller/command',Float64,queue_size=1)
        self.publisher_y = rospy.Publisher('ezbot/joint2_velocity_controller/command',Float64,queue_size=1)

    def differential_client(self):
        rospy.wait_for_service('get_diff')
        try:
            get_diff = rospy.ServiceProxy('get_diff',Movement)
            resp = get_diff()
            return resp.diffx,resp.diffy
        except rospy.ServiceException, e:
            print "Service call failed: %s"%e
            
        return 0,0



def main():
    print('initializing commander')
    commander()


def commander():
    import rospy
    from std_msgs.msg import String, Header
    rospy.init_node( 'ez_robot_cmds' )
    
    com = Commander()
    rate = rospy.Rate(2)
    print("I Started")
    while not rospy.is_shutdown():
        diffx, diffy = com.differential_client()
        adjustx = max( -10, min( 10,diffx*2 ) )
        adjusty = max( -10, min( 10,diffy*2 ) )

        z_axis_msg = Float64()
        z_axis_msg.data = 0.02 * adjustx * -1
        y_axis_msg = Float64()
        y_axis_msg.data = 0.02 * adjusty 
        print ( "Changing {} {}".format( z_axis_msg.data, y_axis_msg.data ) )
        #gazebo form
        com.publisher_z.publish( z_axis_msg )
        com.publisher_y.publish( y_axis_msg )
        #original ez-bot form    
        #com.cmdr.set_servo_position("D0", adjustment + 90 )
        rate.sleep()
        
        
if __name__ == '__main__':
    main()
    print("I'm Not Dead Yet")
    print("Now I'm Dead")
