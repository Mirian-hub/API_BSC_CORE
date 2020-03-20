using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellDiagnoseTable
    {
        public int ShellDiagnoseId { get; set; }
        public string ShellDiagnoseKey { get; set; }
        public string ShellDiagnoseName { get; set; }
        public int ShellDiagnoseTypeId { get; set; }
        public int ShellDiagnoseStatusId { get; set; }
        public int ShellDiagnoseGroupId { get; set; }
        public int ShellDiagnoseSortId { get; set; }
        public string ShellDiagnoseCommand { get; set; }

        public virtual ShellDiagnoseGroupTable ShellDiagnoseGroup { get; set; }
        public virtual ShellDiagnoseStatusTable ShellDiagnoseStatus { get; set; }
        public virtual ShellDiagnoseTypeTable ShellDiagnoseType { get; set; }
    }
}
