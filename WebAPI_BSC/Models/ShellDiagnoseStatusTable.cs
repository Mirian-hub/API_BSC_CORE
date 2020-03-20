using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellDiagnoseStatusTable
    {
        public ShellDiagnoseStatusTable()
        {
            ShellDiagnoseTable = new HashSet<ShellDiagnoseTable>();
        }

        public int ShellDiagnoseStatusId { get; set; }
        public string ShellDiagnoseStatusKey { get; set; }
        public string ShellDiagnoseStatusName { get; set; }

        public virtual ICollection<ShellDiagnoseTable> ShellDiagnoseTable { get; set; }
    }
}
