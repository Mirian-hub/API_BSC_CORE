using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class CashEntryStatusTable
    {
        public CashEntryStatusTable()
        {
            CashEntryTable = new HashSet<CashEntryTable>();
        }

        public int CashEntryStatusId { get; set; }
        public string CashEntryStatusKey { get; set; }
        public string CashEntryStatusName { get; set; }
        public string CashEntryStatusNote { get; set; }

        public virtual ICollection<CashEntryTable> CashEntryTable { get; set; }
    }
}
