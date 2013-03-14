About
========================================

Visual Studio 2012 project template for **PowerShell 3.0** module to access azure storage using [Windows Azure Storage Client Library 2.0](http://nuget.org/packages/WindowsAzure.Storage/).

Sample Usage
========================================

```
PS C:\azure-storage-cmdlets> Get-Host | select Version

Version
-------
3.0

PS C:\azure-storage-cmdlets> Import-Module .\AzureStorage2PowerShellSample\bin\Debug\AzureStorage2PowerShellSample.dll
PS C:\azure-storage-cmdlets> Get-Module -Name AzureStorage2PowerShellSample

ModuleType Name                                ExportedCommands
---------- ----                                ----------------
Binary     AzureStorage2PowerShellSample       Get-AzureStorageAccount

PS C:\azure-storage-cmdlets> $account = Get-AzureStorageAccount -AccountName <name> -KeyValue <key>
PS C:\azure-storage-cmdlets> $client = $account.CreateCloudBlobClient()
PS C:\azure-storage-cmdlets> $container = $client.GetContainerReference("test")
PS C:\azure-storage-cmdlets> $container.CreateIfNotExists()
True
PS C:\azure-storage-cmdlets> $blob = $container.GetBlockBlobReference("empty")
PS C:\azure-storage-cmdlets> $blob.UploadFromStream([IO.Stream]::Null)
```

Note
========================================

* To add reference to **System.Management.Automation**, edited the `.csproj` file in a text editor
* See the following stackoverflow question for details
    * [Referencing system.management.automation.dll in Visual Studio](http://stackoverflow.com/questions/1186270/referencing-system-management-automation-dll-in-visual-studio)

License
========================================

You may use this sample under the terms of the [MIT License](LICENSE).
