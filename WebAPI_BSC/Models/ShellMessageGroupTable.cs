using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellMessageGroupTable
    {
        public ShellMessageGroupTable()
        {
            InverseShellMessageGroupParent = new HashSet<ShellMessageGroupTable>();
            ShellMessageTable = new HashSet<ShellMessageTable>();
        }

        public int ShellMessageGroupId { get; set; }
        public string ShellMessageGroupKey { get; set; }
        public string ShellMessageGroupName { get; set; }
        public int ShellMessageGroupParentId { get; set; }

        public virtual ShellMessageGroupTable ShellMessageGroupParent { get; set; }
        public virtual ICollection<ShellMessageGroupTable> InverseShellMessageGroupParent { get; set; }
        public virtual ICollection<ShellMessageTable> ShellMessageTable { get; set; }
    }
}
