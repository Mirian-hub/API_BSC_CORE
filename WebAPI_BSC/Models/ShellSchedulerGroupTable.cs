using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellSchedulerGroupTable
    {
        public ShellSchedulerGroupTable()
        {
            InverseShellSchedulerGroupParent = new HashSet<ShellSchedulerGroupTable>();
            ShellSchedulerTable = new HashSet<ShellSchedulerTable>();
        }

        public int ShellSchedulerGroupId { get; set; }
        public string ShellSchedulerGroupKey { get; set; }
        public string ShellSchedulerGroupName { get; set; }
        public string ShellSchedulerGroupNote { get; set; }
        public int ShellSchedulerGroupSort { get; set; }
        public int ShellSchedulerGroupParentId { get; set; }

        public virtual ShellSchedulerGroupTable ShellSchedulerGroupParent { get; set; }
        public virtual ICollection<ShellSchedulerGroupTable> InverseShellSchedulerGroupParent { get; set; }
        public virtual ICollection<ShellSchedulerTable> ShellSchedulerTable { get; set; }
    }
}
