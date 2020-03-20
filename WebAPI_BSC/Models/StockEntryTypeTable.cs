using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockEntryTypeTable
    {
        public StockEntryTypeTable()
        {
            StockEntryTable = new HashSet<StockEntryTable>();
        }

        public int StockEntryTypeId { get; set; }
        public string StockEntryTypeKey { get; set; }
        public string StockEntryTypeName { get; set; }
        public string StockEntryTypeNote { get; set; }

        public virtual ICollection<StockEntryTable> StockEntryTable { get; set; }
    }
}
