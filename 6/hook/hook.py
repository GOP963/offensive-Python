import ctypes
from ctypes import wintypes

kernel32 = ctypes.WinDLL("kernel32.dll")
user32 = ctypes.WinDLL("user32.dll")

FindWindoW = user32.FindWindowW
FindWindoW.argtypes = [wintypes.LPCWSTR,wintypes.LPCWSTR]
FindWindoW.restype = wintypes.HWND

hwnd = FindWindoW("notepad",None)

GetWindowThreadProcessId = user32.GetWindowThreadProcessId
GetWindowThreadProcessId.argtypes = [wintypes.HWND,wintypes.LPDWORD]
GetWindowThreadProcessId.restype = wintypes.DWORD

pid  = wintypes.DWORD(0)
tid = GetWindowThreadProcessId(hwnd,ctypes.byref(pid))
#print(f"PID: {pid.value}\nTID: {tid}")

#loadlibrary

LoadLibrary = kernel32.LoadLibraryExW
LoadLibrary.argtypes = [wintypes.LPCWSTR,wintypes.HANDLE,wintypes.DWORD]
LoadLibrary.restype = wintypes.HMODULE
DONT_RESOLVE_DLL_REFERENCES = 0x00000001
library = LoadLibrary("C:\\Users\\charon\\Desktop\\offensive python\\6\\hook\\HockAndInject.dll",None,DONT_RESOLVE_DLL_REFERENCES)

GetProcAddress =  kernel32.GetProcAddress
GetProcAddress.argtypes = [wintypes.HMODULE,wintypes.LPCSTR]
GetProcAddress.restype = wintypes.LPHANDLE
address = GetProcAddress(library,ctypes.c_char_p("NextHook".encode('utf-8')))

print(address)

SetWindowHookEx = user32.SetWindowsHookExW
SetWindowHookEx.argtypes = [wintypes.DWORD,wintypes.LPHANDLE,wintypes.HMODULE,wintypes.DWORD]
SetWindowHookEx.restype = wintypes.LPHANDLE
WH_GETMESSAGE = 3
SetWindowHookEx(WH_GETMESSAGE,address,library,tid)

PostThreadMessage = user32.PostThreadMessageW
PostThreadMessage.argtypes = [wintypes.DWORD,wintypes.UINT,wintypes.WPARAM,wintypes.LPARAM]
PostThreadMessage.restype 	= wintypes.BOOL
PostThreadMessage(tid,0,0,0)
