using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellLanguageStatusTable
    {
        public ShellLanguageStatusTable()
        {
            ShellLanguageTable = new HashSet<ShellLanguageTable>();
        }

        public int ShellLanguageStatusId { get; set; }
        public string ShellLanguageStatusKey { get; set; }
        public string ShellLanguageStatusName { get; set; }

        public virtual ICollection<ShellLanguageTable> ShellLanguageTable { get; set; }
    }
}
