using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockDeliveryStatusTable
    {
        public int StockDeliveryStatusId { get; set; }
        public string StockDeliveryStatusKey { get; set; }
        public string StockDeliveryStatusName { get; set; }
        public string StockDeliveryStatusNote { get; set; }
    }
}
