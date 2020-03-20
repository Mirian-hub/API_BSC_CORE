using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellLanguageTypeTable
    {
        public ShellLanguageTypeTable()
        {
            ShellLanguageTable = new HashSet<ShellLanguageTable>();
        }

        public int ShellLanguageTypeId { get; set; }
        public string ShellLanguageTypeKey { get; set; }
        public string ShellLanguageTypeName { get; set; }

        public virtual ICollection<ShellLanguageTable> ShellLanguageTable { get; set; }
    }
}
