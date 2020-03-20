using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class SyncEntryTypeTable
    {
        public SyncEntryTypeTable()
        {
            SyncEntryTable = new HashSet<SyncEntryTable>();
        }

        public int SyncEntryTypeId { get; set; }
        public string SyncEntryTypeKey { get; set; }
        public string SyncEntryTypeName { get; set; }

        public virtual ICollection<SyncEntryTable> SyncEntryTable { get; set; }
    }
}
