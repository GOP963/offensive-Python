import socket
import struct
import binascii
from colorama import Fore as charon

rawsocket = socket.socket(socket.PF_PACKET, socket.SOCK_RAW, socket.htons(0x0806))
while True:
    pkt = rawsocket.recvfrom(4096)
    eth_header = pkt[0][0:14]
    ARP = struct.unpack("!6s6s2s", eth_header)
    IPHeader = pkt[0][14:42]  # 14 + 6 * 4 byte
    IPHeader = struct.unpack("!8s6s4s6s4s",IPHeader)
    def format_mac(mac_bytes, sep=":"):
        h = binascii.hexlify(mac_bytes).decode()
        return sep.join(h[i:i+2] for i in range(0, 12, 2))
    print(charon.GREEN+"Destination MAC:\t"+charon.WHITE+ format_mac(ARP[0]))
    print(charon.GREEN+"Source MAC:\t\t"+charon.WHITE+ format_mac(ARP[1]))
    print(charon.GREEN+"sender MAC:\t\t"+charon.WHITE+ format_mac(IPHeader[1]))
    print(charon.GREEN+"Target MAC:\t\t"+charon.WHITE+ format_mac(IPHeader[3]))
    print(charon.GREEN+"Source IP:\t\t"+charon.WHITE+socket.inet_ntoa(IPHeader[2]))
    print(charon.GREEN+"Destination IP:\t\t"+charon.WHITE+socket.inet_ntoa(IPHeader[4]))
# def format_mac(mac_bytes, sep=":"):
#     h = binascii.hexlify(mac_bytes).decode()
#     return sep.join(h[i:i+2] for i in range(0, 12, 2))
