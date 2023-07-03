
# import cv2
# import numpy as np

# """
#     This is a simple example on how to use OpenCV for MSER
# """

# def mser(cv_image):
#     vis = cv_image.copy()
#     mser = cv2.MSER_create()
#     regions, _ = mser.detectRegions(cv_image)
#     for p in regions:
#         xmax, ymax = np.amax(p, axis=0)
#         xmin, ymin = np.amin(p, axis=0)
        
#         # overlapRatio = bboxOverlapRatio(expandedBBoxes, expandedBBoxes);
        
#         cv2.rectangle(vis, (xmin,ymax), (xmax,ymin), (0, 255, 0), 1)
#     return vis

# mser(cv2.imread(r'C:\Users\ADDJ\Downloads\New folder\a.jpg', 0))
# cv2.imwrite(r'C:\Users\ADDJ\Downloads\New folder\b.jpg', 
#             mser(cv2.imread(r'C:\Users\ADDJ\Downloads\New folder\a.jpg', 0)))


import os
import re
from argparse import ArgumentParser

import cv2
import numpy as np
from pdf2image import convert_from_path
from PIL import Image


def pdf_to_jpg(pdf_file_path, jpg_file_path):
    # pytesseract.pytesseract.tesseract_cmd = r"C:\Program Files\Tesseract-OCR\tesseract.exe"
    Image.MAX_IMAGE_PIXELS = 1000000000000


    pattern = re.compile(".*pdf$")
    if pattern.match(pdf_file_path):
        pages = convert_from_path(pdf_file_path, 300)
        image_counter = 1
        for page in pages:
            output_path = jpg_file_path
            if(not os.path.exists(output_path)):
                page.save(output_path, 'JPEG')


def detect_region(jpgRoot, jpgDetect):
    # tuplify
    def tup(point):
        return (point[0], point[1]);

    # returns true if the two boxes overlap
    def overlap(source, target):
        # unpack points
        tl1, br1 = source;
        tl2, br2 = target;

        # checks
        if (tl1[0] >= br2[0] or tl2[0] >= br1[0]):
            return False;
        if (tl1[1] >= br2[1] or tl2[1] >= br1[1]):
            return False;
        return True;

    # returns all overlapping boxes
    def getAllOverlaps(boxes, bounds, index):
        overlaps = [];
        for a in range(len(boxes)):
            if a != index:
                if overlap(bounds, boxes[a]):
                    overlaps.append(a);
        return overlaps;

    img = cv2.imread(jpgRoot)
    orig = np.copy(img);
    blue, green, red = cv2.split(img)

    def medianCanny(img, thresh1, thresh2):
        median = np.median(img)
        img = cv2.Canny(img, int(thresh1 * median), int(thresh2 * median))
        return img

    blue_edges = medianCanny(blue, 0, 1)
    green_edges = medianCanny(green, 0, 1)
    red_edges = medianCanny(red, 0, 1)

    edges = blue_edges | green_edges | red_edges

    # I'm using OpenCV 3.4. This returns (contours, hierarchy) in OpenCV 2 and 4
    contours,hierarchy = cv2.findContours(edges, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)

    # go through the contours and save the box edges
    boxes = []; # each element is [[top-left], [bottom-right]];
    hierarchy = hierarchy[0]
    for component in zip(contours, hierarchy):
        currentContour = component[0]
        currentHierarchy = component[1]
        x,y,w,h = cv2.boundingRect(currentContour)
        if currentHierarchy[3] < 0:
            cv2.rectangle(img,(x,y),(x+w,y+h),(0,255,0),1)
            boxes.append([[x,y], [x+w, y+h]]);

    # filter out excessively large boxes
    filtered = [];
    max_area = 30000;
    for box in boxes:
        w = box[1][0] - box[0][0];
        h = box[1][1] - box[0][1];
        if w*h < max_area:
            filtered.append(box);
    boxes = filtered;

    # go through the boxes and start merging
    merge_margin = 15;

    # this is gonna take a long time
    finished = False;
    highlight = [[0,0], [1,1]];
    points = [[[0,0]]];

    # xử lý gộp
    while not finished:
        # set end con
        finished = True;

        # check progress
        # boxes: là tổng số ô vuông được phát hiện trong hình ảnh
        # print(f"Len Boxes: {len(boxes)}");
            
        # time.sleep(1)

        # draw boxes # comment this section out to run faster
        copy = np.copy(orig);
        
        # vẽ ô vuông của từng chữ
        for box in boxes:
            cv2.rectangle(copy, tup(box[0]), tup(box[1]), (0,200,0), 1);
        
        # vẽ ô vuông khi grow box
        cv2.rectangle(copy, tup(highlight[0]), tup(highlight[1]), (0,0,255), 2);
        
        for point in points:
            point = point[0];
            cv2.circle(copy, tup(point), 4, (255,0,0), -1);
            
        cv2.imshow("Copy", cv2.resize(copy, (610, 780)));
        # cv2.imshow("Copy", copy);
        key = cv2.waitKey(1);
        if key == ord('q'):
            break;

        # loop through boxes
        # lặp từng ô để gộp
        index = len(boxes) - 1;
        while index >= 0:
            # grab current box
            curr = boxes[index];

            # add margin
            tl = curr[0][:];
            br = curr[1][:];
            tl[0] -= merge_margin;
            tl[1] -= merge_margin;
            br[0] += merge_margin;
            br[1] += merge_margin;

            # get matching boxes
            overlaps = getAllOverlaps(boxes, [tl, br], index);
            
            # check if empty
            if len(overlaps) > 0:
                # combine boxes
                # convert to a contour
                con = [];
                overlaps.append(index);
                for ind in overlaps:
                    tl, br = boxes[ind];
                    con.append([tl]);
                    con.append([br]);
                con = np.array(con);

                # get bounding rect
                x,y,w,h = cv2.boundingRect(con);

                # stop growing
                w -= 1;
                h -= 1;
                merged = [[x,y], [x+w, y+h]];

                # highlights
                highlight = merged[:];
                points = con;

                # remove boxes from list
                overlaps.sort(reverse = True);
                # print(overlaps)
                for ind in overlaps:
                    del boxes[ind];
                boxes.append(merged);
                
                # print(boxes)

                # set flag
                finished = False;
                # curr
                # br
                # box
                # highlight
                # tl
                break;

            # increment
            index -= 1;
    cv2.destroyAllWindows();

    # show final
    copy = np.copy(orig);
    for box in boxes:
        with open('toado.txt', 'a+', encoding='utf-8') as f:
            f.write(f'{tup(box[0])}, {tup(box[1])}\n')
        # print(f'{tup(box[0])}, {tup(box[1])}')
        cv2.rectangle(copy, tup(box[0]), tup(box[1]), (0,0,200), 1);
        
    # cv2.imshow("Final", cv2.resize(copy, (610, 780)));
    cv2.imwrite(jpgDetect, copy)
    # cv2.imshow("Final", copy);
    cv2.waitKey(0);
    

if __name__ == '__main__':
    ap = ArgumentParser()
    ap.add_argument("-i", "--input", required=True, help="Path file")
    args = vars(ap.parse_args())
    # display a friendly message to the user
    # print("Hi there {}, it's nice to meet you!".format(args["input"]))


    pattern = re.compile(".*pdf$")
    if pattern.match(args["input"]):
        pdf_to_jpg(args["input"], 'input.jpg')
        detect_region('input.jpg', 'output.jpg')
    else:
        detect_region(args["input"], 'output.jpg')
        

