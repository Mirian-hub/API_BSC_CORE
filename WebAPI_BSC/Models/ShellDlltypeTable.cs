using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellDlltypeTable
    {
        public ShellDlltypeTable()
        {
            ShellDlltable = new HashSet<ShellDlltable>();
        }

        public int ShellDlltypeId { get; set; }
        public string ShellDlltypeKey { get; set; }
        public string ShellDlltypeName { get; set; }
        public string ShellDlltypeNote { get; set; }

        public virtual ICollection<ShellDlltable> ShellDlltable { get; set; }
    }
}
