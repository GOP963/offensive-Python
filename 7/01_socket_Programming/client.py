import socket

print("[+] initialaze socket")
client = socket.socket(socket.AF_INET,socket.SOCK_STREAM) # SOCK_STREAM ----> TCP | AF_INET ---> IPv4

target_host = "127.0.0.1"    #"www.google.com"
target_port =  9090   #80

try:
    print("[+] connect to server")
    client.connect((target_host,target_port)) #---> Destination Host & dst port
except:
    print("[-] cannot access target_host")
    exit(0)
data = "GET / HTTP/1.1\r\nHost: google.com\r\n\r\n"
client.sendall(bytes(data,"utf-8"))  # ----> this is function for send data useage
print("[+] data send")

responce = client.recv(4096)   # ----> max responce that of get server
print(responce)
