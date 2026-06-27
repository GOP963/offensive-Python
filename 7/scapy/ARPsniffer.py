from scapy.all import *

ip_mac = {}
def wath_arp(pkt):
    if(ARP not in pkt):
        return
    if(pkt[ARP].op == 2):
        srcip = pkt[ARP].psrc
        macaddress = pkt[ARP].hwdst
        if(ip_mac.get(srcip) == None):
            print(f"[+] Found New Device {srcip} : {macaddress}")
            ip_mac.update({srcip:macaddress})
        if(ip_mac.get(srcip) and ip_mac.get(srcip) != macaddress):
            print(f"{macaddress} has got new IP {srcip}")
            ip_mac[srcip] = macaddress
sniff(filter='arp',prn=wath_arp)
