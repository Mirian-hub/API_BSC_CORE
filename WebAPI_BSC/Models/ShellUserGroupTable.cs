using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellUserGroupTable
    {
        public ShellUserGroupTable()
        {
            InverseShellUserGroupParent = new HashSet<ShellUserGroupTable>();
            ShellUserTable = new HashSet<ShellUserTable>();
        }

        public int ShellUserGroupId { get; set; }
        public string ShellUserGroupKey { get; set; }
        public string ShellUserGroupName { get; set; }
        public int ShellUserGroupParentId { get; set; }

        public virtual ShellUserGroupTable ShellUserGroupParent { get; set; }
        public virtual ICollection<ShellUserGroupTable> InverseShellUserGroupParent { get; set; }
        public virtual ICollection<ShellUserTable> ShellUserTable { get; set; }
    }
}
