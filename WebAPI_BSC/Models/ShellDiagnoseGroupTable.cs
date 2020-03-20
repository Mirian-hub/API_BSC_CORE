using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellDiagnoseGroupTable
    {
        public ShellDiagnoseGroupTable()
        {
            InverseShellDiagnoseGroupParent = new HashSet<ShellDiagnoseGroupTable>();
            ShellDiagnoseTable = new HashSet<ShellDiagnoseTable>();
        }

        public int ShellDiagnoseGroupId { get; set; }
        public string ShellDiagnoseGroupKey { get; set; }
        public string ShellDiagnoseGroupName { get; set; }
        public int ShellDiagnoseGroupParentId { get; set; }

        public virtual ShellDiagnoseGroupTable ShellDiagnoseGroupParent { get; set; }
        public virtual ICollection<ShellDiagnoseGroupTable> InverseShellDiagnoseGroupParent { get; set; }
        public virtual ICollection<ShellDiagnoseTable> ShellDiagnoseTable { get; set; }
    }
}
