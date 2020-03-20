using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockPriceStatusTable
    {
        public StockPriceStatusTable()
        {
            StockPriceTable = new HashSet<StockPriceTable>();
        }

        public int StockPriceStatusId { get; set; }
        public string StockPriceStatusKey { get; set; }
        public string StockPriceStatusName { get; set; }
        public string StockPriceStatusNote { get; set; }

        public virtual ICollection<StockPriceTable> StockPriceTable { get; set; }
    }
}
