using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellReportFormTable
    {
        public int ShellReportFormId { get; set; }
        public int ShellReportFormSortId { get; set; }
        public string ShellReportFormKey { get; set; }
        public string ShellReportFormName { get; set; }
        public int ShellReportId { get; set; }

        public virtual ShellReportTable ShellReport { get; set; }
    }
}
