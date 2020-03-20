using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockDeliveryGroupTable
    {
        public int StockDeliveryGroupId { get; set; }
        public string StockDeliveryGroupKey { get; set; }
        public string StockDeliveryGroupName { get; set; }
        public string StockDeliveryGroupNote { get; set; }
        public int? StockDeliveryGroupParentId { get; set; }
    }
}
