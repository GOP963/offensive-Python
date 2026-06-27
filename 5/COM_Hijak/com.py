import win32com.client

comwmi = win32com.client.Dispatch("Wbemscripting.SwbemLocator")
objLocalWmi = comwmi.ConnectServer(".","root\\cimv2")
query = objLocalWmi.ExecQuery("SELECT * FROM Win32_COMSetting")

for item in query:
    try:
        if item.AppID != None:
            print(item.AppID,item.LocalServer32)
    except:
        pass

#print(query)