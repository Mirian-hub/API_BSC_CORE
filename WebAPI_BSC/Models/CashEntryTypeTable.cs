using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class CashEntryTypeTable
    {
        public CashEntryTypeTable()
        {
            CashEntryTable = new HashSet<CashEntryTable>();
        }

        public int CashEntryTypeId { get; set; }
        public string CashEntryTypeKey { get; set; }
        public string CashEntryTypeName { get; set; }
        public string CashEntryTypeNote { get; set; }

        public virtual ICollection<CashEntryTable> CashEntryTable { get; set; }
    }
}
