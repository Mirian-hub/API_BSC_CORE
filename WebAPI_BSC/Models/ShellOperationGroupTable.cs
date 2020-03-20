using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellOperationGroupTable
    {
        public ShellOperationGroupTable()
        {
            InverseShellOperationGroupParent = new HashSet<ShellOperationGroupTable>();
            ShellOperationTable = new HashSet<ShellOperationTable>();
        }

        public int ShellOperationGroupId { get; set; }
        public string ShellOperationGroupKey { get; set; }
        public string ShellOperationGroupName { get; set; }
        public int ShellOperationGroupParentId { get; set; }

        public virtual ShellOperationGroupTable ShellOperationGroupParent { get; set; }
        public virtual ICollection<ShellOperationGroupTable> InverseShellOperationGroupParent { get; set; }
        public virtual ICollection<ShellOperationTable> ShellOperationTable { get; set; }
    }
}
