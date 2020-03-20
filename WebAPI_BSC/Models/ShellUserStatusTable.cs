using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellUserStatusTable
    {
        public ShellUserStatusTable()
        {
            ShellUserTable = new HashSet<ShellUserTable>();
        }

        public int ShellUserStatusId { get; set; }
        public string ShellUserStatusKey { get; set; }
        public string ShellUserStatusName { get; set; }

        public virtual ICollection<ShellUserTable> ShellUserTable { get; set; }
    }
}
