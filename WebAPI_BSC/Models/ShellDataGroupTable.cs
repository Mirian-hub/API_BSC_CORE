using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellDataGroupTable
    {
        public ShellDataGroupTable()
        {
            InverseShellDataGroupParent = new HashSet<ShellDataGroupTable>();
            ShellDataTable = new HashSet<ShellDataTable>();
        }

        public int ShellDataGroupId { get; set; }
        public string ShellDataGroupKey { get; set; }
        public string ShellDataGroupName { get; set; }
        public int ShellDataGroupParentId { get; set; }

        public virtual ShellDataGroupTable ShellDataGroupParent { get; set; }
        public virtual ICollection<ShellDataGroupTable> InverseShellDataGroupParent { get; set; }
        public virtual ICollection<ShellDataTable> ShellDataTable { get; set; }
    }
}
