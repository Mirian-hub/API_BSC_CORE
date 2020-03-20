using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellOperationStatusTable
    {
        public ShellOperationStatusTable()
        {
            ShellOperationTable = new HashSet<ShellOperationTable>();
        }

        public int ShellOperationStatusId { get; set; }
        public string ShellOperationStatusKey { get; set; }
        public string ShellOperationStatusName { get; set; }

        public virtual ICollection<ShellOperationTable> ShellOperationTable { get; set; }
    }
}
