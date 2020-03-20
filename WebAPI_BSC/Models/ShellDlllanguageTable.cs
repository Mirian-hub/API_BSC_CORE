using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellDlllanguageTable
    {
        public int ShellDllid { get; set; }
        public int ShellDlllanguageId { get; set; }
        public string ShellDllname { get; set; }

        public virtual ShellDlltable ShellDll { get; set; }
        public virtual ShellLanguageTable ShellDlllanguage { get; set; }
    }
}
