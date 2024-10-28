import cv2
from cvzone.HandTrackingModule import HandDetector
import socket

# parameter
width, height = 1280,720

# webcam
cap = cv2.VideoCapture(0)

cap.set(3, width)
cap.set(4, height)

# Hand Detector
detector = HandDetector(maxHands=1, detectionCon=0.8)

#communication
sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
serverAddressPort = ("127.0.0.1", 5052)

while True:
    #get frame from webcame

    success, img = cap.read()
    flip_img = cv2.flip(img, 1)

    #hands
    hands, img = detector.findHands(flip_img)
    cv2.imshow("Image", flip_img)

    data =[]
    #landmark values (x,y,z) * 21
    if hands:
        #get first hand detected
        hand = hands[0]
        # get landmark list
        lmList = hand['lmList']

        for lm in lmList:
            data.extend([width - lm[0], height - lm[1], lm[2]])

        sock.sendto(str.encode(str(data)), serverAddressPort)

    cv2.waitKey(1)