using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellTermTypeTable
    {
        public ShellTermTypeTable()
        {
            ShellTermTable = new HashSet<ShellTermTable>();
        }

        public int ShellTermTypeId { get; set; }
        public string ShellTermTypeKey { get; set; }
        public string ShellTermTypeName { get; set; }

        public virtual ICollection<ShellTermTable> ShellTermTable { get; set; }
    }
}
