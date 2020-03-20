using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellSchedulerTypeTable
    {
        public ShellSchedulerTypeTable()
        {
            ShellSchedulerTable = new HashSet<ShellSchedulerTable>();
        }

        public int ShellSchedulerTypeId { get; set; }
        public string ShellSchedulerTypeKey { get; set; }
        public string ShellSchedulerTypeName { get; set; }
        public string ShellSchedulerTypeNote { get; set; }

        public virtual ICollection<ShellSchedulerTable> ShellSchedulerTable { get; set; }
    }
}
