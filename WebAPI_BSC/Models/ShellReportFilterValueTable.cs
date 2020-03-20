using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellReportFilterValueTable
    {
        public int ShellReportFilterValueId { get; set; }
        public string ShellReportFilterValue { get; set; }
        public int ShellUserId { get; set; }
        public int ShellReportFilterId { get; set; }
        public int ShellMessageId { get; set; }

        public virtual ShellReportFilterTable ShellReportFilter { get; set; }
        public virtual ShellUserTable ShellUser { get; set; }
    }
}
