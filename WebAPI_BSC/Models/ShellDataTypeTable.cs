using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellDataTypeTable
    {
        public ShellDataTypeTable()
        {
            ShellDataTable = new HashSet<ShellDataTable>();
        }

        public int ShellDataTypeId { get; set; }
        public string ShellDataTypeKey { get; set; }
        public string ShellDataTypeName { get; set; }

        public virtual ICollection<ShellDataTable> ShellDataTable { get; set; }
    }
}
