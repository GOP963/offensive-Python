import socket

client = socket.socket(socket.AF_INET,socket.SOCK_DGRAM)

IP_server = "127.0.0.1"
Port_server = 9090

client.sendto(bytes("hello","utf-8"),(IP_server,Port_server))
data,addr = client.recvfrom(4096)
print(f"[+] recv data from"+str(addr[0])+":"+str(addr[1]))
print(data)
