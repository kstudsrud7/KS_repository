Link to Article: https://www.c-sharpcorner.com/article/how-to-download-the-dynamics-365-ce-configuration-migration-tool2/

The Configuration Migration tool is used to transport configuration and test data from one Dynamics 365 CE environment to another environment.

In this article, will explain how to download the Configuration Migration Tool using Power Shell Script from Nuget.

Follow the below steps to download the same.

Step 1

Create a folder in C Drive (Preferably any Other Drive, other than C Drive) and name it as “Dynamics_365_Development_Tools“

Step 2

Click on Windows, search for Windows PowerShell and open it.

How To Download The Dynamics 365 CE Configuration Migration Tool

Step 3

Type the below command and press Enter to change the directory.

cd C:\Dynamics_365_Development_Tools
BASIC
How To Download The Dynamics 365 CE Configuration Migration Tool

Directory changed.

How To Download The Dynamics 365 CE Configuration Migration Tool

Step 4

Copy & Paste the below PowerShell script in PowerShell Window to download Configuration Migration Tool from Nuget.

$sourceNugetExe = "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe"
$targetNugetExe = ".\nuget.exe"
Remove-Item .\Tools -Force -Recurse -ErrorAction Ignore
Invoke-WebRequest $sourceNugetExe -OutFile $targetNugetExe
Set-Alias nuget $targetNugetExe -Scope Global -Verbose

##
##Download Configuration Migration Tool
##
./nuget install Microsoft.CrmSdk.XrmTooling.ConfigurationMigration.Wpf -O .\Tools
md .\Tools\ConfigurationMigration
$configMigFolder = Get-ChildItem ./Tools | Where-Object {$_.Name -match 'Microsoft.CrmSdk.XrmTooling.ConfigurationMigration.Wpf.'}
move .\Tools\$configMigFolder\tools\*.* .\Tools\ConfigurationMigration
Remove-Item .\Tools\$configMigFolder -Force -Recurse

##
##Remove NuGet.exe
##
Remove-Item nuget.exe
BASIC
Step 5

Click on Paste anyway.

How To Download The Dynamics 365 CE Configuration Migration Tool

Configuration Migration Tool download is in progress.

How To Download The Dynamics 365 CE Configuration Migration Tool

Configuration Migration Tool is downloaded successfully.

How To Download The Dynamics 365 CE Configuration Migration Tool

Step 6

In the Power Shell, Press Enter to delete nuget.exe file.

Step 7

Go to C:\Dynamics_365_Development_Tools\Tools folder for Configuration Migration Tool.

How To Download The Dynamics 365 CE Configuration Migration Tool

To get the latest version of this Configuration Migration Tool, repeat the steps mentioned above

Hope you have successfully downloaded Configuration Migration Tool from NuGet using Powershell script.

Please like and share your valuable feedback on this article.