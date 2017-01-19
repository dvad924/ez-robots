#! /usr/bin/env python
import os
from glob import glob
import zmq
import cv2
import numpy as np
from ez_robot import ez_robot
from multiprocessing import Process





def main():
    print('initializing commander')
    commander()


def commander():
    import rospy
    from std_msgs.msg import String, Header
    
    rospy.init_node( 'ez_robot_cmds' )

    cmdr = ez_robot()
    cmdr.set_request_mode()
    rate = rospy.Rate(2)
    x = 20
    print("I Started")
    while not rospy.is_shutdown():
        
        cmdr.set_servo_position("D0",x)
        rate.sleep()
        x = (x + 10) % 180
        
if __name__ == '__main__':
    main()
    print("I'm Not Dead Yet")
    print("Now I'm Dead")
