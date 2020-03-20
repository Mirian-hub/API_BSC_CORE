using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellUserTypeTable
    {
        public ShellUserTypeTable()
        {
            ShellUserTable = new HashSet<ShellUserTable>();
        }

        public int ShellUserTypeId { get; set; }
        public string ShellUserTypeKey { get; set; }
        public string ShellUserTypeName { get; set; }
        public string ShellUserTypeNote { get; set; }

        public virtual ICollection<ShellUserTable> ShellUserTable { get; set; }
    }
}
