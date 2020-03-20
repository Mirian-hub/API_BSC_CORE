using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ZzShellSyncTable
    {
        public int ShellSyncId { get; set; }
        public string ShellSyncKey { get; set; }
        public string ShellSyncName { get; set; }
        public string ShellSyncNote { get; set; }
        public int ShellSyncTypeId { get; set; }
        public int ShellSyncStatusId { get; set; }
        public string ShellSyncLicenseKey { get; set; }
        public string ShellSyncLicenseFrom { get; set; }
        public string ShellSyncLicenseTo { get; set; }
        public string ShellSyncTableFrom { get; set; }
        public string ShellSyncTableTo { get; set; }
        public string ShellSyncDataId { get; set; }
        public string ShellSyncDataStatusId { get; set; }
        public DateTime? ShellSyncDateFrom { get; set; }
        public DateTime? ShellSyncDateTo { get; set; }
        public int? ShellSyncProcessId { get; set; }
        public string ShellSyncComputerKey { get; set; }
    }
}
