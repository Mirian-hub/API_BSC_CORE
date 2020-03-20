using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellReportStatusTable
    {
        public ShellReportStatusTable()
        {
            ShellReportTable = new HashSet<ShellReportTable>();
        }

        public int ShellReportStatusId { get; set; }
        public string ShellReportStatusKey { get; set; }
        public string ShellReportStatusName { get; set; }

        public virtual ICollection<ShellReportTable> ShellReportTable { get; set; }
    }
}
