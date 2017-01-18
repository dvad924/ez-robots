#! /usr/bin/env python
import os
from glob import glob
import zmq
import cv2
import numpy as np
from ez_robot import ez_robot
from multiprocessing import Process





def main():
    print('initializing Nodes')
    p1 = Process( target=imgPublisher )
    p1.start()
    p2 = Process( target=commander )
    p2.start()
    p1.join()
    p2.join()

def commander():
    import rospy
    from std_msgs.msg import String, Header
    
    rospy.init_node( 'ez_robot_cmds' )

    cmdr = ez_robot()
    cmdr.set_request_mode()
    rate = rospy.Rate(100)
    x = 10
    print("I Started")
    while not rospy.is_shutdown():
        
        cmdr.spin_x_deg(x)
        rate.sleep()
        x += 10 % 360
        
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
        rosmsg = bridge.cv2_to_imgmsg( img )
        publisher1.publish( rosmsg )


        rate.sleep()

if __name__ == '__main__':
    main()
    print("I'm Not Dead Yet")
    print("Now I'm Dead")




        # files = glob( "/tmp/*.finished" )
        # imgfiles = map( lambda x: x[x.rfind('/')+1:x.rfind('.finished')]+'.jpg',files )
        # for f in imgfiles:
        #     im = cv2.imread( os.path.join( '/tmp', f ) )
        #     framemsg = bridge.cv2_to_imgmsg( im, 'bgr8' )
        #     publisher1.publish( framemsg )
        #     os.remove( os.path.join('/tmp', f) )
        #     os.remove( os.path.join('/tmp', f.replace( 'jpg', 'finished' ) ) )


        
# def callback( im_msg, bbox_array ):
#     print("!RECIEVED IMAGE!")
#     try:
#         cv2_img = bridge.imgmsg_to_cv2( im_msg, "bgr8" )
#         bboxes = map( todrect, bbox_array.bboxes )
#         len( bboxes )
#         if len( bboxes ) == 0:
#             return
#         f,finfo = furtherCallback( ( bboxes, cv2_img ) )    
#         frame1_message = bridge.cv2_to_imgmsg( f, "bgr8" )
#         face_msg = toFaceMsgs( finfo )

#         publisher1.publish( frame1_message )
        
#     except CvBridgeError, e:
#         print( e )
