using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellMessageTypeTable
    {
        public ShellMessageTypeTable()
        {
            ShellMessageTable = new HashSet<ShellMessageTable>();
        }

        public int ShellMessageTypeId { get; set; }
        public string ShellMessageTypeKey { get; set; }
        public string ShellMessageTypeName { get; set; }

        public virtual ICollection<ShellMessageTable> ShellMessageTable { get; set; }
    }
}
