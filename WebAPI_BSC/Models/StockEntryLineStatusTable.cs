using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockEntryLineStatusTable
    {
        public StockEntryLineStatusTable()
        {
            StockEntryLineTable = new HashSet<StockEntryLineTable>();
        }

        public int StockEntryLineStatusId { get; set; }
        public string StockEntryLineStatusKey { get; set; }
        public string StockEntryLineStatusName { get; set; }
        public string StockEntryLineStatusNote { get; set; }

        public virtual ICollection<StockEntryLineTable> StockEntryLineTable { get; set; }
    }
}
