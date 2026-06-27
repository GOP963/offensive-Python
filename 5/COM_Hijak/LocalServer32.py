import win32com.client

def checkfile(path):
	path = path.replace('%SystemRoot%','c:\\windows')
	try:
		f = open(path,'r')
		f.close()
		return True
	except:
		return False
		
		
objWMIService = win32com.client.Dispatch("WbemScripting.SWbemLocator")
objLocalWMI = objWMIService.ConnectServer('.','root\\cimv2')
items = objLocalWMI.ExecQuery("SELECT * FROM Win32_COMSetting")
for item in items:
	try:
		if(item.AppID != None and item.InprocServer32 != None):
			#if(checkfile(item.InprocServer32)):
				#print(item.AppID,item.ProgId,item.LocalServer32)
			print(item.AppID,item.ProgId,item.InprocServer32)
	except:
		pass