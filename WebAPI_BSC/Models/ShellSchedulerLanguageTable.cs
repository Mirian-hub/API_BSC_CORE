using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellSchedulerLanguageTable
    {
        public int ShellSchedulerId { get; set; }
        public int ShellSchedulerLanguageId { get; set; }
        public string ShellSchedulerName { get; set; }

        public virtual ShellSchedulerTable ShellScheduler { get; set; }
        public virtual ShellLanguageTable ShellSchedulerLanguage { get; set; }
    }
}
