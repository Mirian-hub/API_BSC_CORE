using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellMessageStatusTable
    {
        public ShellMessageStatusTable()
        {
            ShellMessageTable = new HashSet<ShellMessageTable>();
        }

        public int ShellMessageStatusId { get; set; }
        public string ShellMessageStatusKey { get; set; }
        public string ShellMessageStatusName { get; set; }

        public virtual ICollection<ShellMessageTable> ShellMessageTable { get; set; }
    }
}
