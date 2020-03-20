using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockDiscountLineTable
    {
        public long StockDiscountLineId { get; set; }
        public string StockDiscountLineKey { get; set; }
        public string StockDiscountLineName { get; set; }
        public int StockDiscountLineSortId { get; set; }
        public int StockDiscountLineTypeId { get; set; }
        public int StockDiscountLineStatusId { get; set; }
        public DateTime StockDiscountLineValidFrom { get; set; }
        public DateTime StockDiscountLineValidTo { get; set; }
        public int StockDiscountId { get; set; }
        public int StockItemId { get; set; }
        public double StockDiscountLineFactor { get; set; }
        public double StockDisccountLineQuantityInitial { get; set; }
        public double StockDisccountLineQuantity { get; set; }
    }
}
