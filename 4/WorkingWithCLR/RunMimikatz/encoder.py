import base64

file  = open("mimikatz.exe",'rb')
m = file.read()
file.close()

m = base64.b64encode(m)

file = open("loader.b64",'wb')
file.write(m)
file.close()