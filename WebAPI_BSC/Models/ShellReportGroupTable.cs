using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellReportGroupTable
    {
        public ShellReportGroupTable()
        {
            InverseShellReportGroupParent = new HashSet<ShellReportGroupTable>();
            ShellReportTable = new HashSet<ShellReportTable>();
        }

        public int ShellReportGroupId { get; set; }
        public string ShellReportGroupKey { get; set; }
        public string ShellReportGroupName { get; set; }
        public int ShellReportGroupParentId { get; set; }

        public virtual ShellReportGroupTable ShellReportGroupParent { get; set; }
        public virtual ICollection<ShellReportGroupTable> InverseShellReportGroupParent { get; set; }
        public virtual ICollection<ShellReportTable> ShellReportTable { get; set; }
    }
}
