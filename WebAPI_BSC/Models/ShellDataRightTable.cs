using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellDataRightTable
    {
        public int ParentDataId { get; set; }
        public int ParentId { get; set; }
        public int ChildDataId { get; set; }
        public int ChildId { get; set; }

        public virtual ShellDataTable ParentData { get; set; }
    }
}
