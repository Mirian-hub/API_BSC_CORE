using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class CashEntryLineStatusTable
    {
        public CashEntryLineStatusTable()
        {
            CashEntryLineTable = new HashSet<CashEntryLineTable>();
        }

        public int CashEntryLineStatusId { get; set; }
        public string CashEntryLineStatusKey { get; set; }
        public string CashEntryLineStatusName { get; set; }
        public string CashEntryLineStatusNote { get; set; }

        public virtual ICollection<CashEntryLineTable> CashEntryLineTable { get; set; }
    }
}
