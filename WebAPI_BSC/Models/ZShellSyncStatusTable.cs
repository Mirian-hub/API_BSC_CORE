using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ZShellSyncStatusTable
    {
        public int ShellSyncStatusId { get; set; }
        public string ShellSyncStatusKey { get; set; }
        public string ShellSyncStatusName { get; set; }
        public string ShellSyncStatusNote { get; set; }
    }
}
