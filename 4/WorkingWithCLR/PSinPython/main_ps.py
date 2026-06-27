import clr
clr.AddReference("System")
clr.AddReference("System.Management")
clr.AddReference("System.Management.Automation")
clr.AddReference("System.Collections")
import sys
import System
import System.Collections.ObjectModel
import System.Management.Automation
import System.Management.Automation.Runspaces

def RunPs(script):
    r = System.Management.Automation.Runspaces.RunspaceFactory.CreateRunspace()
    r.Open()
    pipeline = r.CreatePipeline()
    pipeline.Commands.AddScript(script)
    result = pipeline.Invoke()
    
    output = []
    for i in result:
        output.append(i.ToString())
        
    r.Close()
    return output

try:
    if len(sys.argv) < 2:
        print("enter command")
    else:
        args = " ".join(sys.argv[1:]) 
        r = RunPs(args)
        for i in r:
            print(i)
except Exception as e:
    print(e)
