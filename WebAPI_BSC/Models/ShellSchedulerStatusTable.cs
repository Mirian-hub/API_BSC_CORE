using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellSchedulerStatusTable
    {
        public ShellSchedulerStatusTable()
        {
            ShellSchedulerTable = new HashSet<ShellSchedulerTable>();
        }

        public int ShellSchedulerStatusId { get; set; }
        public string ShellSchedulerStatusKey { get; set; }
        public string ShellSchedulerStatusName { get; set; }
        public string ShellSchedulerStatusNote { get; set; }

        public virtual ICollection<ShellSchedulerTable> ShellSchedulerTable { get; set; }
    }
}
