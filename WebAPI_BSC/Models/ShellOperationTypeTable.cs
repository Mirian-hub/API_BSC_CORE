using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellOperationTypeTable
    {
        public ShellOperationTypeTable()
        {
            ShellOperationTable = new HashSet<ShellOperationTable>();
        }

        public int ShellOperationTypeId { get; set; }
        public string ShellOperationTypeKey { get; set; }
        public string ShellOperationTypeName { get; set; }

        public virtual ICollection<ShellOperationTable> ShellOperationTable { get; set; }
    }
}
