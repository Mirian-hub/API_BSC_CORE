using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellDataStatusTable
    {
        public ShellDataStatusTable()
        {
            ShellDataTable = new HashSet<ShellDataTable>();
        }

        public int ShellDataStatusId { get; set; }
        public string ShellDataStatusKey { get; set; }
        public string ShellDataStatusName { get; set; }

        public virtual ICollection<ShellDataTable> ShellDataTable { get; set; }
    }
}
