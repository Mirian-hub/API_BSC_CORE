using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellDataTable
    {
        public ShellDataTable()
        {
            ShellDataRightTable = new HashSet<ShellDataRightTable>();
            ShellDataSearchTable = new HashSet<ShellDataSearchTable>();
            ShellDataSortTable = new HashSet<ShellDataSortTable>();
        }

        public int ShellDataId { get; set; }
        public string ShellDataKey { get; set; }
        public string ShellDataName { get; set; }
        public int ShellDataTypeId { get; set; }
        public int ShellDataStatusId { get; set; }
        public int ShellDataGroupId { get; set; }
        public int ShellDataSortId { get; set; }
        public int ShellDataValueId { get; set; }
        public int ShellDataValueGroupId { get; set; }
        public bool ShellDataFlagHasHierarchy { get; set; }
        public bool ShellDataFlagHasGroup { get; set; }
        public bool ShellDataFlagHasGroupHierarchy { get; set; }
        public bool ShellDataFlagIsReadOnly { get; set; }
        public bool ShellDataFlagIsGroupReadOnly { get; set; }

        public virtual ShellDataGroupTable ShellDataGroup { get; set; }
        public virtual ShellDataStatusTable ShellDataStatus { get; set; }
        public virtual ShellDataTypeTable ShellDataType { get; set; }
        public virtual ICollection<ShellDataRightTable> ShellDataRightTable { get; set; }
        public virtual ICollection<ShellDataSearchTable> ShellDataSearchTable { get; set; }
        public virtual ICollection<ShellDataSortTable> ShellDataSortTable { get; set; }
    }
}
