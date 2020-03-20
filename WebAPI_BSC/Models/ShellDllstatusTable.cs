using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellDllstatusTable
    {
        public ShellDllstatusTable()
        {
            ShellDlltable = new HashSet<ShellDlltable>();
        }

        public int ShellDllstatusId { get; set; }
        public string ShellDllstatusKey { get; set; }
        public string ShellDllstatusName { get; set; }
        public string ShellDllstatusNote { get; set; }

        public virtual ICollection<ShellDlltable> ShellDlltable { get; set; }
    }
}
