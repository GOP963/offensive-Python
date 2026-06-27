import ctypes
from ctypes import wintypes

Advapi32 = ctypes.WinDLL("Advapi32.dll")

#https://docs.microsoft.com/en-us/windows/win32/api/winbase/nf-winbase-logonuserw
LogonUser = Advapi32.LogonUserW
LogonUser.argtypes = [wintypes. LPCWSTR, wintypes. LPCWSTR, wintypes. LPCWSTR, wintypes. DWORD, wintypes. DWORD, wintypes. PHANDLE]
LogonUser.restype = wintypes.BOOL
user        = "target"
password    = "123"
domain      = "amin.com"
dwLogonType = 9 #define LOGON32_LOGON_NEW_CREDENTIALS
provider = 0 #define LOGON32_PROVIDER_DEFAULT
token = wintypes.HANDLE()
LogonUser(user,domain,password,dwLogonType,provider,ctypes.byref(token))


#impersonate logon user

ImpersonateLogonUser = Advapi32.ImpersonateLoggedOnUser
ImpersonateLogonUser.argtypes = [wintypes.HANDLE]
ImpersonateLogonUser.restype = wintypes.BOOL
ImpersonateLogonUser(token)

import os

print(os.listdir("\\\\192.168.0.128\C$"))
