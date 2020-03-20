using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellTermTable
    {
        public ShellTermTable()
        {
            ShellTermNameTable = new HashSet<ShellTermNameTable>();
        }

        public int ShellTermId { get; set; }
        public string ShellTermKey { get; set; }
        public string ShellTermName { get; set; }
        public int ShellTermTypeId { get; set; }
        public int ShellTermStatusId { get; set; }
        public int ShellTermGroupId { get; set; }
        public int ShellTermSortId { get; set; }
        public string ShellTermFormat { get; set; }

        public virtual ShellTermGroupTable ShellTermGroup { get; set; }
        public virtual ShellTermStatusTable ShellTermStatus { get; set; }
        public virtual ShellTermTypeTable ShellTermType { get; set; }
        public virtual ICollection<ShellTermNameTable> ShellTermNameTable { get; set; }
    }
}
