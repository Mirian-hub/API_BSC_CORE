using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellTermNameTable
    {
        public int ShellLanguageId { get; set; }
        public int ShellTermId { get; set; }
        public string ShellTermName { get; set; }

        public virtual ShellLanguageTable ShellLanguage { get; set; }
        public virtual ShellTermTable ShellTerm { get; set; }
    }
}
