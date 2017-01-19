#! /usr/bin/env python
import os
from glob import glob
import zmq
import cv2
import numpy as np
from ez_robot import ez_robot






def main():
    print('initializing imgPublisher')
    imgPublisher()

        
def imgPublisher():
    import rospy
    from sensor_msgs.msg import Image
    from std_msgs.msg import String, Header
    from cv_bridge import CvBridge, CvBridgeError

    bridge = CvBridge()
    
    rospy.init_node( 'ez_robot_publist' )
    print ( "I do Live" )
    image_topic = 'ez_robot_cam'
    
    outimg = rospy.resolve_name( "out" )
    
    outimg = outimg if outimg != "/out"     else "/ez_robot_cam/image_raw"
    
    print( "out: ", outimg )

    ipub = ez_robot()
    ipub.subscribe()

    publisher1 = rospy.Publisher( outimg , Image , queue_size = 1 )
    rate = rospy.Rate(100) # no more than 100fps !! :)


    while not rospy.is_shutdown():
        img = ipub.wait_for_img()
        #cv2.imshow('test',img)
        rosmsg = bridge.cv2_to_imgmsg( img, 'bgr8' )
        publisher1.publish( rosmsg )
        #cv2.waitKey(3)

        rate.sleep()

if __name__ == '__main__':
    main()
    print("I'm Not Dead Yet")
    print("Now I'm Dead")

