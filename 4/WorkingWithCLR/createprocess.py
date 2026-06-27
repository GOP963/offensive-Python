import clr
clr.AddReference("System")
import System

def createprocess(cmd):
    p = System.Diagnostics.Process()
    p.Start(cmd)
    print("*" * 20)

def win32_process(cmd):
    p = System.Diagnostics.Process()
    psi = System.Diagnostics.ProcessStartInfo()
    
    psi.FileName = "cmd.exe"
    psi.Arguments = "/c " + cmd
    psi.UseShellExecute = False
    psi.RedirectStandardOutput = True
    psi.CreateNoWindow = True
    
    p.StartInfo = psi
    p.Start()
    
    out = p.StandardOutput.ReadToEnd()
    p.WaitForExit()
    
    return out

print(win32_process("whoami"))

