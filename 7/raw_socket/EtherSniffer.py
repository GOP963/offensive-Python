import socket
import struct
import binascii

rawsocket = socket.socket(socket.PF_PACKET, socket.SOCK_RAW, socket.htons(0x0800))

while True:
    pkt = rawsocket.recvfrom(4096)

    eth_header = pkt[0][:14]
    dst, src, eth_type = struct.unpack("!6s6s2s", eth_header)
    IPHeader = pkt[0][14:34]  # 14 + 20
    IPHeader = struct.unpack("!12s4s4s",IPHeader)
    def format_mac(mac_bytes, sep=":"):
        h = binascii.hexlify(mac_bytes).decode()  
        return sep.join(h[i:i+2] for i in range(0, 12, 2))

    print("Destination MAC:", format_mac(dst))
    print("Source MAC     :", format_mac(src))
    print("Ethertype      :", binascii.hexlify(eth_type).decode())
    print("dstIP:" + str(socket.inet_ntoa(IPHeader[1])))
    print("srcIP:" + str(socket.inet_ntoa(IPHeader[2])))
#print("Source MAC" + Ethernet[1])


# PF_PACKET ----> linux
# AF_INET  -----> windows

# SOCK_RAW -----> connect to NIC(Network Interface Card)
