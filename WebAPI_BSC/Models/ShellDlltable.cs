using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellDlltable
    {
        public ShellDlltable()
        {
            ShellDlllanguageTable = new HashSet<ShellDlllanguageTable>();
        }

        public int ShellDllid { get; set; }
        public string ShellDllkey { get; set; }
        public string ShellDllpath { get; set; }
        public string ShellDllname { get; set; }
        public string ShellDllnote { get; set; }
        public int ShellDlltypeId { get; set; }
        public int ShellDllstatusId { get; set; }
        public DateTime ShellDllvalidFrom { get; set; }
        public DateTime ShellDllvalidTo { get; set; }
        public int ShellDllsort { get; set; }
        public int ShellDllgroupId { get; set; }

        public virtual ShellDllgroupTable ShellDllgroup { get; set; }
        public virtual ShellDllstatusTable ShellDllstatus { get; set; }
        public virtual ShellDlltypeTable ShellDlltype { get; set; }
        public virtual ICollection<ShellDlllanguageTable> ShellDlllanguageTable { get; set; }
    }
}
