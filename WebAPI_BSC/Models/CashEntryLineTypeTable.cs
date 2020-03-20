using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class CashEntryLineTypeTable
    {
        public CashEntryLineTypeTable()
        {
            CashEntryLineTable = new HashSet<CashEntryLineTable>();
        }

        public int CashEntryLineTypeId { get; set; }
        public string CashEntryLineTypeKey { get; set; }
        public string CashEntryLineTypeName { get; set; }
        public string CashEntryLineTypeNote { get; set; }

        public virtual ICollection<CashEntryLineTable> CashEntryLineTable { get; set; }
    }
}
