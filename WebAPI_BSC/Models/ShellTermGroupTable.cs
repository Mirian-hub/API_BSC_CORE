using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellTermGroupTable
    {
        public ShellTermGroupTable()
        {
            InverseShellTermGroupParent = new HashSet<ShellTermGroupTable>();
            ShellTermTable = new HashSet<ShellTermTable>();
        }

        public int ShellTermGroupId { get; set; }
        public string ShellTermGroupKey { get; set; }
        public string ShellTermGroupName { get; set; }
        public int ShellTermGroupParentId { get; set; }

        public virtual ShellTermGroupTable ShellTermGroupParent { get; set; }
        public virtual ICollection<ShellTermGroupTable> InverseShellTermGroupParent { get; set; }
        public virtual ICollection<ShellTermTable> ShellTermTable { get; set; }
    }
}
