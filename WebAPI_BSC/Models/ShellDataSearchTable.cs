using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellDataSearchTable
    {
        public int ShellDataId { get; set; }
        public int ShellDataSearchId { get; set; }
        public string ShellDataSearchKey { get; set; }
        public string ShellDataSearchName { get; set; }
        public string ShellDataSearchFormat { get; set; }

        public virtual ShellDataTable ShellData { get; set; }
    }
}
