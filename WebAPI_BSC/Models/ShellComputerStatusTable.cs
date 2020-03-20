using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellComputerStatusTable
    {
        public ShellComputerStatusTable()
        {
            ShellComputerTable = new HashSet<ShellComputerTable>();
        }

        public int ShellComputerStatusId { get; set; }
        public string ShellComputerStatusKey { get; set; }
        public string ShellComputerStatusName { get; set; }

        public virtual ICollection<ShellComputerTable> ShellComputerTable { get; set; }
    }
}
