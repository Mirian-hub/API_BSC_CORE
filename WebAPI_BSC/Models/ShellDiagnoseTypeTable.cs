using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellDiagnoseTypeTable
    {
        public ShellDiagnoseTypeTable()
        {
            ShellDiagnoseTable = new HashSet<ShellDiagnoseTable>();
        }

        public int ShellDiagnoseTypeId { get; set; }
        public string ShellDiagnoseTypeKey { get; set; }
        public string ShellDiagnoseTypeName { get; set; }

        public virtual ICollection<ShellDiagnoseTable> ShellDiagnoseTable { get; set; }
    }
}
