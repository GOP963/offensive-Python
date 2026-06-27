import sys
import os


args = sys.argv

if len(args) < 1:
    print("enter path")
    
if len(args) > 1:
    path = args[1]
    try:
        dir_list = os.listdir(path)
        print(dir_list)
    except:
        check = os.system(f"test-path {path}")
        if check == "true":
            #print("please enter string path ---> 'c:\users\...' ")
            sys.exit()
        elif check == "false":
            print("path is not found")
    
    
    