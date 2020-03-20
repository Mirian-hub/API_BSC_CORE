using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockDiscountGroupTable
    {
        public int StockDiscountGroupId { get; set; }
        public string StockDiscountGroupKey { get; set; }
        public string StockDiscountGroupName { get; set; }
        public string StockDiscountGroupNote { get; set; }
        public int StockDiscountGroupParentId { get; set; }
    }
}
