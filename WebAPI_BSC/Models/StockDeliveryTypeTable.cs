using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockDeliveryTypeTable
    {
        public StockDeliveryTypeTable()
        {
            StockLocationItemTable = new HashSet<StockLocationItemTable>();
        }

        public int StockDeliveryTypeId { get; set; }
        public string StockDeliveryTypeKey { get; set; }
        public string StockDeliveryTypeName { get; set; }
        public string StockDeliveryTypeNote { get; set; }

        public virtual ICollection<StockLocationItemTable> StockLocationItemTable { get; set; }
    }
}
