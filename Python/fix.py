import os
import re
import shutil

# lấy tên file => xóa data => xóa ảnh => up lại


# ghi file txt lỗi
with open('error.txt', 'w+') as f:               
    for root, dirs, files in os.walk(r'E:\reup\ocr'):
        for file in files:
            pattern = re.compile(".*"+'pdf'+"$")

            if pattern.match(file):        
                f.write(file + '\n')
                
    for root, dirs, files in os.walk(r'E:\reup\goc'):
        for file in files:
            pattern = re.compile(".*"+'pdf'+"$")

            if pattern.match(file):        
                f.write(file + '\n')
                
# di chuyển ảnh về thư mục lỗi
lst = []
for root, dirs, files in os.walk(r'D:\HoTich\HOTICH_HG\source - haugiang\Files'):
    for file in files:    
        with open('error.txt', 'r') as f:           
            for line in f:
                if line.strip() == file:
                    # print (os.path.join(root, file))
                    try:
                        shutil.move(os.path.join(root, file), os.path.join('E:\Error', file))
                    except Exception as e:
                        pass
            



                    