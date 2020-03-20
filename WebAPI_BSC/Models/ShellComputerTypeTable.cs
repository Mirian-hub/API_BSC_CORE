using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellComputerTypeTable
    {
        public ShellComputerTypeTable()
        {
            ShellComputerTable = new HashSet<ShellComputerTable>();
        }

        public int ShellComputerTypeId { get; set; }
        public string ShellComputerTypeKey { get; set; }
        public string ShellComputerTypeName { get; set; }

        public virtual ICollection<ShellComputerTable> ShellComputerTable { get; set; }
    }
}
