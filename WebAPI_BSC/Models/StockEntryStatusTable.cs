using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockEntryStatusTable
    {
        public StockEntryStatusTable()
        {
            StockEntryTable = new HashSet<StockEntryTable>();
        }

        public int StockEntryStatusId { get; set; }
        public string StockEntryStatusKey { get; set; }
        public string StockEntryStatusName { get; set; }
        public string StockEntryStatusNote { get; set; }
        public int StockR9flag { get; set; }
        public int StockR5flag { get; set; }
        public int StockR3flag { get; set; }
        public int StockR2flag { get; set; }
        public int StockR0flag { get; set; }

        public virtual ICollection<StockEntryTable> StockEntryTable { get; set; }
    }
}
