using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockLocationItemTable
    {
        public int StockLocationId { get; set; }
        public int StockItemId { get; set; }
        public double MinQuantity { get; set; }
        public double MaxQuantity { get; set; }
        public int StockDeliveryGraphId { get; set; }
        public double Dmquantity { get; set; }
        public double MinDays { get; set; }
        public double MaxDays { get; set; }
        public int StatisticDays { get; set; }
        public int StockLocationItemSortId { get; set; }
        public double SalesSpeed { get; set; }
        public double SalesFactor { get; set; }
        public int StockLocationItemStatusId { get; set; }
        public double OrderSpeed { get; set; }
        public int StockDeliveryTypeId { get; set; }
        public int StockUsageTypeId { get; set; }
        public int? StockLocationId2 { get; set; }
        public double StockQlimitFactor { get; set; }
        public double OrderFactor { get; set; }
        public int? StockSupplierId { get; set; }
        public double OrderDays { get; set; }
        public int StockRptypeId { get; set; }

        public virtual StockDeliveryGraphTable StockDeliveryGraph { get; set; }
        public virtual StockDeliveryTypeTable StockDeliveryType { get; set; }
        public virtual StockItemTable StockItem { get; set; }
        public virtual StockLocationTable StockLocation { get; set; }
        public virtual StockLocationItemStatusTable StockLocationItemStatus { get; set; }
        public virtual StockUsageTypeTable StockUsageType { get; set; }
    }
}
