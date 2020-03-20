using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellDataSortTable
    {
        public int ShellDataId { get; set; }
        public int ShellDataSortId { get; set; }
        public string ShellDataSortKey { get; set; }
        public string ShellDataSortName { get; set; }
        public string ShellDataSortFormat { get; set; }

        public virtual ShellDataTable ShellData { get; set; }
    }
}
