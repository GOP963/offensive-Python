import socket
import threading

def handle_thread(client):
        client_recv = client.recv(2048)
        print(client_recv)
        client.sendall(bytes("Hi","utf-8"))
        client.close()
print("[+] initialaze socket")
server = socket.socket(socket.AF_INET,socket.SOCK_STREAM)

ip_interface    = "0.0.0.0" # -----> bind on all interfaces OR network ip OR loopback ip
port_interface  =  9090
try:
    server.bind((ip_interface,port_interface))  # -----> listen for interfaces this is reauest most on kernel os get handle for my process
    print(f"[+] bind socket on {ip_interface}:{port_interface}")
except:
    print("[-] cannot bind all interface please specific interface")
    exit(0)

server.listen(5) #-----> how count connection if more then of numbered on Queue
print("[+] server listen count 5")

while True:
        client,addr = server.accept()   # htis is method return tuple that of tow get object for server
        print("[+] Accepted Connection From"+str(addr[0])+"to"+str(addr[1]))
        thread = threading.Thread(target=handle_thread,args=(client))
        thread.start()

# client ----> send,recv
# addr ------> srcIP srcPORT
