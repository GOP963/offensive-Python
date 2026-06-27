import win32com.client
import time
obj = win32com.client.Dispatch("Excel.Application")
obj.Visible = 1
work = obj.Workbooks.Add("")
macro = """
sub exec()
CreateObject("Wscript.Shell").Exec("notepad.exe")
End Sub
"""
work.VBProject.VBComponents.Item(1).CodeModule.AddFromString(macro)


# if Visible value == 1 ---->  running excel
# if Visible value == 0 ----> background (hidden) running Excel
