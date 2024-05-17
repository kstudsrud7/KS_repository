https://www.c-sharpcorner.com/article/how-to-download-the-dynamics-365-ce-plugin-registration-tool/

Step 1: Create a folder in D Drive and name it as “Dynamics_365_Development_Tools“

Step 2: Click on Windows, search for Windows PowerShell and open it.

Step 3: Run Command cd D:\Dynamics_365_Development_Tools

**This can also be on c drive, where you want it installed

Step 4: Run the followiing PowerShell script

$sourceNugetExe = "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe"
$targetNugetExe = ".\nuget.exe"
Remove-Item .\Tools -Force -Recurse -ErrorAction Ignore
Invoke-WebRequest $sourceNugetExe -OutFile $targetNugetExe
Set-Alias nuget $targetNugetExe -Scope Global -Verbose

##
##Download Plugin Registration Tool
##
./nuget install Microsoft.CrmSdk.XrmTooling.PluginRegistrationTool -O .\Tools
md .\Tools\PluginRegistration
$prtFolder = Get-ChildItem ./Tools | Where-Object {$_.Name -match 'Microsoft.CrmSdk.XrmTooling.PluginRegistrationTool.'}
move .\Tools\$prtFolder\tools\*.* .\Tools\PluginRegistration
Remove-Item .\Tools\$prtFolder -Force -Recurse

##
##Remove NuGet.exe
##
Remove-Item nuget.exe