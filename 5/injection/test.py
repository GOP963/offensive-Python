from ctypes import *
try:
    kernel = windll.kernel32
except:
    print("ERROR")