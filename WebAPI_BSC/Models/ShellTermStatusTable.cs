using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellTermStatusTable
    {
        public ShellTermStatusTable()
        {
            ShellTermTable = new HashSet<ShellTermTable>();
        }

        public int ShellTermStatusId { get; set; }
        public string ShellTermStatusKey { get; set; }
        public string ShellTermStatusName { get; set; }

        public virtual ICollection<ShellTermTable> ShellTermTable { get; set; }
    }
}
