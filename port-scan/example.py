import socket
from colorama import Fore as charon
import threading
import sys
import signal
import os

try:
    global_ports = list(range(1, 500))

    def scan(ip):
        while len(global_ports) != 0:
            try:
                port = global_ports.pop(0)
            except IndexError:
                break
                
            try:
                s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
                s.settimeout(1) 
                s.connect((ip, port))
                print(charon.GREEN + "[+] Port: " + str(port) + " Open")
                s.close() 
            except:
                print(charon.RED + "[-] Port: " + str(port) + " Closed")
                print(charon.WHITE)
    if len(sys.argv) > 1:
        ip = sys.argv[1]
    else:
        print("Please enter an IP address.")
        sys.exit()

    threads = []

    for i in range(10):
        t = threading.Thread(target=scan, args=(ip,)) 
        threads.append(t)

    for t in threads:
        t.start()

    for t in threads:
        t.join()
except KeyboardInterrupt:
    print("Ctrl-C Stoped")
    os.exit()
    signal.signal(signal.SIGINT, scan)