using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockEntryLineTypeTable
    {
        public StockEntryLineTypeTable()
        {
            StockEntryLineTable = new HashSet<StockEntryLineTable>();
        }

        public int StockEntryLineTypeId { get; set; }
        public string StockEntryLineTypeKey { get; set; }
        public string StockEntryLineTypeName { get; set; }
        public string StockEntryLineTypeNote { get; set; }

        public virtual ICollection<StockEntryLineTable> StockEntryLineTable { get; set; }
    }
}
