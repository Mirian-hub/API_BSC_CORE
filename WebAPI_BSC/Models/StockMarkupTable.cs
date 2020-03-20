using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockMarkupTable
    {
        public int StockMarkupId { get; set; }
        public string StockMarkupKey { get; set; }
        public string StockMarkupName { get; set; }
        public int StockMarkupTypeId { get; set; }
        public int StockMarkupStatusId { get; set; }
        public int StockMarkupGroupId { get; set; }
        public int StockCustomerId { get; set; }
        public int StockSupplierId { get; set; }
        public double StockMarkupFactor { get; set; }
        public double StockMarkupValue { get; set; }
        public double StockMarkupRoundFactor { get; set; }

        public virtual StockMarkupGroupTable StockMarkupGroup { get; set; }
        public virtual StockMarkupStatusTable StockMarkupStatus { get; set; }
        public virtual StockMarkupTypeTable StockMarkupType { get; set; }
    }
}
