names = ('activeconsole',
              'amsi.dll',
              'authtap',
              'avast',
              'avecto',
              'canary',
              'carbon',
              'cb.exe',
              'ciscoamp',
              'cisco amp',
              'countertack',
              'cramtray',
              'crssvc',
              'crowdstrike',
              'csagent',
              'csfalcon',
              'csshell',
              'cybereason',
              'cyclorama',
              'cylance',
              'cyoptics',
              'cyupdate',
              'cyvera',
              'cyserver',
              'cytray',
              'defendpoint',
              'defender',
              'eectrl',
              'emcoreservice',
              'emsystem',
              'endgame',
              'fireeye',
              'forescout',
              'groundling',
              'GRRservice'
              'inspector',
              'ivanti',
              'kaspersky',
              'lacuna',
              'logrhythm',
              'malware',
              'mandiant',
              'mcafee',
              'morphisec',
              'msascuil',
              'msmpeng',
              'nissrv',
              'ntrtscan',
              'osquery',
              'Palo Alto Networks',
              'pgeposervice',
              'pgsystemtray',
              'privilegeguard',
              'procwall',
              'protectorservice'
              'qradar',
              'redcloak',
              'secureconnector',
              'Elastic-Agent',
              'Elastic-Endpoint',
              'secureworks',
              'securityhealthservice',
              'semlaunchsvc'
              'sentinel',
              'sepliveupdate'
              'sisidsservice',
              'sisipsservice',
              'sisipsutil',
              'smc.exe',
              'smcgui',
              'snac64',
              'sophos',
              'splunk',
              'srtsp',
              'symantec',
              'symcorpui'
              'symefasi',
              'sysinternal',
              'sysmon',
              'tanium',
              'tda.exe',
              'tdawork',
              'tmlisten',
              'tmbmsrv',
              'tmssclient',
              'tmccsf',
              'tpython',
              'trend',
              'watchdogagent',
              'wincollect',
              'windowssensor',
              'wireshark',
              'xagt',
             )

import os, psutil
pid = os.getpid()
hpid = psutil.Process(pid)
for dll in hpid.memory_maps():
	name_dll = dll.path
	name_dll = name_dll.split('\\')[-1]
	if(name_dll in names):
		print(name_dll)
	name_dll = name_dll.split('.')[0]
	if(name_dll in names):
		print(name_dll)


for proc in psutil.process_iter():
	if(proc.name() in names):
		print(proc.name(),proc.pid)
