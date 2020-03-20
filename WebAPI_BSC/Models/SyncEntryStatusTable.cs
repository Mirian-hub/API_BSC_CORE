using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class SyncEntryStatusTable
    {
        public SyncEntryStatusTable()
        {
            SyncEntryTable = new HashSet<SyncEntryTable>();
        }

        public int SyncEntryStatusId { get; set; }
        public string SyncEntryStatusKey { get; set; }
        public string SyncEntryStatusName { get; set; }

        public virtual ICollection<SyncEntryTable> SyncEntryTable { get; set; }
    }
}
