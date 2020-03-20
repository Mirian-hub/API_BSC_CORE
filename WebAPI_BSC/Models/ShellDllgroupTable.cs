using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellDllgroupTable
    {
        public ShellDllgroupTable()
        {
            InverseShellDllgroupParent = new HashSet<ShellDllgroupTable>();
            ShellDlltable = new HashSet<ShellDlltable>();
        }

        public int ShellDllgroupId { get; set; }
        public string ShellDllgroupKey { get; set; }
        public string ShellDllgroupName { get; set; }
        public string ShellDllgroupNote { get; set; }
        public int ShellDllgroupSort { get; set; }
        public int ShellDllgroupParentId { get; set; }

        public virtual ShellDllgroupTable ShellDllgroupParent { get; set; }
        public virtual ICollection<ShellDllgroupTable> InverseShellDllgroupParent { get; set; }
        public virtual ICollection<ShellDlltable> ShellDlltable { get; set; }
    }
}
