using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class SyncEntryTable
    {
        public int SyncEntryId { get; set; }
        public string SyncEntryKey { get; set; }
        public string SyncEntryName { get; set; }
        public int SyncEntryStatusId { get; set; }
        public int SyncEntryTypeId { get; set; }
        public DateTime SyncEntryDate { get; set; }
        public string SyncEntryValue { get; set; }

        public virtual SyncEntryStatusTable SyncEntryStatus { get; set; }
        public virtual SyncEntryTypeTable SyncEntryType { get; set; }
    }
}
