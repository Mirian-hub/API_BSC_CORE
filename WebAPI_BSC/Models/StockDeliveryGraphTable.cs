using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockDeliveryGraphTable
    {
        public StockDeliveryGraphTable()
        {
            StockLocationItemTable = new HashSet<StockLocationItemTable>();
        }

        public int StockDeliveryGraphId { get; set; }
        public string StockDeliveryGraphKey { get; set; }
        public string StockDeliveryGraphName { get; set; }
        public bool D1 { get; set; }
        public bool D2 { get; set; }
        public bool D3 { get; set; }
        public bool D4 { get; set; }
        public bool D5 { get; set; }
        public bool D6 { get; set; }
        public bool D7 { get; set; }
        public int StockDeliveryGraphTypeId { get; set; }

        public virtual ICollection<StockLocationItemTable> StockLocationItemTable { get; set; }
    }
}
