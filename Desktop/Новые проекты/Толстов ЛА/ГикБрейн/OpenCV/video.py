import cv2

cap = cv2.VideoCapture(0)

while True:
    success, frame = cap.read()
    cv2.imshow('Result', frame)
    if cv2.waitKey(1) & 0xff == ord('q'):
        break

   