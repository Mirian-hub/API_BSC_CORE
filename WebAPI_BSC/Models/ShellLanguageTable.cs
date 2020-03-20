using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellLanguageTable
    {
        public ShellLanguageTable()
        {
            ShellDlllanguageTable = new HashSet<ShellDlllanguageTable>();
            ShellSchedulerLanguageTable = new HashSet<ShellSchedulerLanguageTable>();
            ShellTermNameTable = new HashSet<ShellTermNameTable>();
            ShellUserTable = new HashSet<ShellUserTable>();
        }

        public int ShellLanguageId { get; set; }
        public string ShellLanguageKey { get; set; }
        public string ShellLanguageName { get; set; }
        public int ShellLanguageStatusId { get; set; }
        public int ShellLanguageTypeId { get; set; }

        public virtual ShellLanguageStatusTable ShellLanguageStatus { get; set; }
        public virtual ShellLanguageTypeTable ShellLanguageType { get; set; }
        public virtual ICollection<ShellDlllanguageTable> ShellDlllanguageTable { get; set; }
        public virtual ICollection<ShellSchedulerLanguageTable> ShellSchedulerLanguageTable { get; set; }
        public virtual ICollection<ShellTermNameTable> ShellTermNameTable { get; set; }
        public virtual ICollection<ShellUserTable> ShellUserTable { get; set; }
    }
}
