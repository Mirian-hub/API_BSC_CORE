using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellReportFilterTypeTable
    {
        public ShellReportFilterTypeTable()
        {
            ShellReportFilterTable = new HashSet<ShellReportFilterTable>();
        }

        public int ShellReportFilterTypeId { get; set; }
        public string ShellReportFilterTypeKey { get; set; }
        public string ShellReportFilterTypeName { get; set; }
        public string ShellControlKey { get; set; }
        public string Sqltype { get; set; }
        public string Sqlprefix { get; set; }
        public string Sqlsuffix { get; set; }

        public virtual ICollection<ShellReportFilterTable> ShellReportFilterTable { get; set; }
    }
}
