using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellComputerGroupTable
    {
        public ShellComputerGroupTable()
        {
            InverseShellComputerGroupParent = new HashSet<ShellComputerGroupTable>();
            ShellComputerTable = new HashSet<ShellComputerTable>();
        }

        public int ShellComputerGroupId { get; set; }
        public string ShellComputerGroupKey { get; set; }
        public string ShellComputerGroupName { get; set; }
        public int ShellComputerGroupParentId { get; set; }

        public virtual ShellComputerGroupTable ShellComputerGroupParent { get; set; }
        public virtual ICollection<ShellComputerGroupTable> InverseShellComputerGroupParent { get; set; }
        public virtual ICollection<ShellComputerTable> ShellComputerTable { get; set; }
    }
}
