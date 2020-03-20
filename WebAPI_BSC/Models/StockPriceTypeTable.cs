using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockPriceTypeTable
    {
        public StockPriceTypeTable()
        {
            StockPriceTable = new HashSet<StockPriceTable>();
        }

        public int StockPriceTypeId { get; set; }
        public string StockPriceTypeKey { get; set; }
        public string StockPriceTypeName { get; set; }
        public string StockPriceTypeNote { get; set; }

        public virtual ICollection<StockPriceTable> StockPriceTable { get; set; }
    }
}
