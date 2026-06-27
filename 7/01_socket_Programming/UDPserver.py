import socket

server = socket.socket(socket.AF_INET,socket.SOCK_DGRAM)
server.bind(("0.0.0.0",9090))

while True:
    data,addr = server.recvfrom(4096)
    print(f"[+] recv data from"+str(addr[0])+":"+str(addr[1]))
    print(data)
    server.sendto(bytes("Hi","utf-8"),addr)
    
