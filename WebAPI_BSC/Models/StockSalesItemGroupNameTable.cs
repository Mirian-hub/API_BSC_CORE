using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockSalesItemGroupNameTable
    {
        public int StockCustomerId { get; set; }
        public int StockSalesItemGroupId { get; set; }
        public string StockSalesItemGroupName { get; set; }
        public int StockSalesItemGroupNameId { get; set; }
        public int StockSalesItemGroupNameStatusId { get; set; }
        public int StockItemGroupDiscountId { get; set; }
        public double StockItemGroupDiscountFactor { get; set; }
        public double StockItemGroupDiscountTime { get; set; }
        public double StockItemGroupDiscountDuration { get; set; }

        public virtual StockCompanyTable StockCustomer { get; set; }
        public virtual StockSalesItemGroupTable StockSalesItemGroup { get; set; }
    }
}
