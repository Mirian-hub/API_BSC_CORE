using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellReportFilterStatusTable
    {
        public ShellReportFilterStatusTable()
        {
            ShellReportFilterTable = new HashSet<ShellReportFilterTable>();
        }

        public int ShellReportFilterStatusId { get; set; }
        public string ShellReportFilterStatusKey { get; set; }
        public string ShellReportFilterStatusName { get; set; }

        public virtual ICollection<ShellReportFilterTable> ShellReportFilterTable { get; set; }
    }
}
