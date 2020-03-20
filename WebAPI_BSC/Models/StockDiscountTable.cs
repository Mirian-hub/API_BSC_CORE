using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockDiscountTable
    {
        public int StockDiscountId { get; set; }
        public int StockDiscountGroupId { get; set; }
        public string StockDiscountKey { get; set; }
        public string StockDiscountName { get; set; }
        public string StockDiscountNote { get; set; }
        public int StockDiscountTypeId { get; set; }
        public int StockDiscountStatusId { get; set; }
        public DateTime StockDiscountValidFrom { get; set; }
        public DateTime StockDiscountValidTo { get; set; }

        public virtual StockDiscountStatusTable StockDiscountStatus { get; set; }
        public virtual StockDiscountTypeTable StockDiscountType { get; set; }
    }
}
