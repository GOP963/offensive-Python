import socket
import os
from impacket.smbconnection import SMBConnection, SessionError
from impacket.smb import SMB_DIALECT
from impacket.examples.secretsdump import RemoteOperations, SAMHashes, LSASecrets, NTDSHashes
from impacket.nmb import NetBIOSError
from impacket.dcerpc.v5 import transport, lsat, lsad
from impacket.dcerpc.v5.rpcrt import DCERPCException
from impacket.dcerpc.v5.transport import DCERPCTransportFactory
from impacket.dcerpc.v5.rpcrt import RPC_C_AUTHN_GSS_NEGOTIATE
from impacket.dcerpc.v5.epm import MSRPC_UUID_PORTMAP
from impacket.dcerpc.v5.dcom.wmi import WBEM_FLAG_FORWARD_ONLY
from impacket.dcerpc.v5.samr import SID_NAME_USE
from impacket.dcerpc.v5.dtypes import MAXIMUM_ALLOWED
from time import time
from datetime import datetime

def get_os_arch(host):
    try:
        stringBinding = r'ncacn_ip_tcp:{}[135]'.format(host)
        transport = DCERPCTransportFactory(stringBinding)
        transport.set_connect_timeout(5)
        dce = transport.get_dce_rpc()
        dce.connect()

        try:
            dce.bind(MSRPC_UUID_PORTMAP, transfer_syntax=('71710533-BEBA-4937-8319-B5DBEF9CCC36', '1.0'))
        except DCERPCException as e:
            if str(e).find('syntaxes_not_supported') >= 0:
                return 32
            else:
                pass
        else:
            return 64
        dce.disconnect()

    except Exception as e:
        print('Error retrieving os arch of {}: {}'.format(host, str(e)))

    return 0
        
def enum_host_info(conn,smbv1,host):
	local_ip = conn.getSMBServer().get_socket().getsockname()[0]

	try:
		conn.login('' , '')
	except:
		pass
	domain    = conn.getServerDNSDomainName()
	hostname  = conn.getServerName()
	server_os = conn.getServerOS()
	signing   = conn.isSigningRequired() if smbv1 else conn._SMBConnection._Connection['RequireSigning']
	os_arch   = get_os_arch(host)

	if not domain:
		domain = hostname

	try:
		conn.logoff()
	except:
		pass

	print(host,domain,server_os,os_arch)
	
def create_smbv1_conn(host):
	smbv1 = None
	try:
		conn = SMBConnection(host, host, None, 445, preferredDialect=SMB_DIALECT)
		smbv1 = True
	except socket.error as e:
		if str(e).find('Connection reset by peer') != -1:
			print('SMBv1 might be disabled on {}'.format(host))
		return False,smbv1
	except Exception as e:
		print('Error creating SMBv1 connection to {}: {}'.format(host, e))
		return False,smbv1

	return conn,smbv1

def create_smbv3_conn(host):
	smbv1 = None
	try:
		conn = SMBConnection(host, host, None, 445)
		smbv1 = False
	except socket.error:
		return False,smbv1
	except Exception as e:
		print('Error creating SMBv3 connection to {}: {}'.format(host, e))
		return False,smbv1

	return conn,smbv1
    
host = "192.168.1.155"
conn,smbv1 = create_smbv3_conn(host)
enum_host_info(conn,smbv1,host)
