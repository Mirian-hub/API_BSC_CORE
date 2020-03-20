using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockDeliveryTable
    {
        public int StockDeliveryId { get; set; }
        public string StockDeliveryKey { get; set; }
        public string StockDeliveryName { get; set; }
        public string StockDeliveryNote { get; set; }
        public int StockDeliveryTypeId { get; set; }
        public int StockDeliveryStatusId { get; set; }
        public int StockDeliveryGroupId { get; set; }
    }
}
