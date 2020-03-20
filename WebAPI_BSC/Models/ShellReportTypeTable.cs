using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellReportTypeTable
    {
        public ShellReportTypeTable()
        {
            ShellReportTable = new HashSet<ShellReportTable>();
        }

        public int ShellReportTypeId { get; set; }
        public string ShellReportTypeKey { get; set; }
        public string ShellReportTypeName { get; set; }

        public virtual ICollection<ShellReportTable> ShellReportTable { get; set; }
    }
}
