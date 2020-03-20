using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellReportFilterTable
    {
        public ShellReportFilterTable()
        {
            ShellReportFilterValueTable = new HashSet<ShellReportFilterValueTable>();
        }

        public int ShellReportFilterId { get; set; }
        public int ShellReportFilterSortId { get; set; }
        public string ShellReportFilterKey { get; set; }
        public string ShellReportFilterName { get; set; }
        public int ShellReportFilterTypeId { get; set; }
        public int ShellReportFilterStatusId { get; set; }
        public int ShellReportId { get; set; }

        public virtual ShellReportTable ShellReport { get; set; }
        public virtual ShellReportFilterStatusTable ShellReportFilterStatus { get; set; }
        public virtual ShellReportFilterTypeTable ShellReportFilterType { get; set; }
        public virtual ICollection<ShellReportFilterValueTable> ShellReportFilterValueTable { get; set; }
    }
}
