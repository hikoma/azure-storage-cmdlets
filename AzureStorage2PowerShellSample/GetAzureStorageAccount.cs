using System.Management.Automation;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;

namespace AzureStorage2PowerShellSample
{
    [Cmdlet(VerbsCommon.Get, "AzureStorageAccount")]
    public class GetAzureStorageAccount : Cmdlet
    {
        [Parameter(Mandatory = true)]
        public string AccountName;

        [Parameter(Mandatory = true)]
        public string KeyValue;

        [Parameter]
        public bool UseHttps = false;

        protected override void BeginProcessing()
        {
            var credentials = new StorageCredentials(AccountName, KeyValue);
            var account = new CloudStorageAccount(credentials, UseHttps);
            WriteObject(account);
        }
    }
}
