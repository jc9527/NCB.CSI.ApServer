cd /D "%~dp0"

del /s /f /q .\packages\*.xml
del /s /f /q .\packages\*dll.config
del /s /f /q .\NCB.CSI.ApClient\bin\*.xml
del /s /f /q .\NCB.CSI.ApClient\bin\*.config
del /s /f /q .\NCB.CSI.ApServer\bin\*.xml
del /s /f /q .\NCB.CSI.ApServer\bin\*.config
del /s /f /q .\NCB.CSI.ApServer\Web.Debug.config
del /s /f /q .\NCB.CSI.ApServer\Web.Release.config

powershell $config = '.\NCB.CSI.ApServer\web.config'; $doc = (Get-Content $config) -as [Xml]; $doc.get_DocumentElement().SelectNodes('system.web').compilation.SetAttribute('debug', 'false'); $doc.Save($config);
pause

