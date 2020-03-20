using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellReportTable
    {
        public ShellReportTable()
        {
            ShellReportFilterTable = new HashSet<ShellReportFilterTable>();
            ShellReportFormTable = new HashSet<ShellReportFormTable>();
        }

        public int ShellReportId { get; set; }
        public string ShellReportKey { get; set; }
        public string ShellReportName { get; set; }
        public int ShellReportTypeId { get; set; }
        public int ShellReportStatusId { get; set; }
        public int ShellReportGroupId { get; set; }
        public string ShellReportSource { get; set; }
        public string ShellReportFilter { get; set; }

        public virtual ShellReportGroupTable ShellReportGroup { get; set; }
        public virtual ShellReportStatusTable ShellReportStatus { get; set; }
        public virtual ShellReportTypeTable ShellReportType { get; set; }
        public virtual ICollection<ShellReportFilterTable> ShellReportFilterTable { get; set; }
        public virtual ICollection<ShellReportFormTable> ShellReportFormTable { get; set; }
    }
}
