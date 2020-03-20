using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockItemByLocationTable
    {
        public int StockLocationId { get; set; }
        public int StockItemId { get; set; }
        public double StockQuantity { get; set; }
        public double StockAmount { get; set; }
        public double StockCostPrice { get; set; }
        public int SalesItemId { get; set; }
        public int SalesItemUnitId { get; set; }
        public double SalesItemUnitFactor { get; set; }
        public double SalesPrice { get; set; }
        public int SalesTaxId { get; set; }
    }
}
