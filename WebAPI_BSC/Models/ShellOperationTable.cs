using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellOperationTable
    {
        public ShellOperationTable()
        {
            ShellOperationLineTable = new HashSet<ShellOperationLineTable>();
        }

        public int ShellOperationId { get; set; }
        public string ShellOperationKey { get; set; }
        public string ShellOperationName { get; set; }
        public int ShellOperationTypeId { get; set; }
        public int ShellOperationStatusId { get; set; }
        public int ShellOperationGroupId { get; set; }
        public int ShellOperationSortId { get; set; }
        public int ShellEntryTypeId { get; set; }
        public int ShellEntryStatusId { get; set; }
        public int ShellEntryAcceptedStatusId { get; set; }
        public int ShellEntryRejectedStatusId { get; set; }
        public int ShellEntryVoidStatusId { get; set; }
        public int ShellEntryAccessId { get; set; }
        public int ShellDataId { get; set; }
        public int ShellDataValueTypeId { get; set; }
        public int ShellDataValueStatusId { get; set; }

        public virtual ShellOperationGroupTable ShellOperationGroup { get; set; }
        public virtual ShellOperationStatusTable ShellOperationStatus { get; set; }
        public virtual ShellOperationTypeTable ShellOperationType { get; set; }
        public virtual ICollection<ShellOperationLineTable> ShellOperationLineTable { get; set; }
    }
}
