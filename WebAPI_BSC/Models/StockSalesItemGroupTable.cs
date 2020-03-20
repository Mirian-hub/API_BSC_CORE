using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockSalesItemGroupTable
    {
        public StockSalesItemGroupTable()
        {
            InverseStockSalesItemGroupParent = new HashSet<StockSalesItemGroupTable>();
            StockSalesItemGroupNameTable = new HashSet<StockSalesItemGroupNameTable>();
        }

        public int StockSalesItemGroupId { get; set; }
        public string StockSalesItemGroupKey { get; set; }
        public string StockSalesItemGroupName { get; set; }
        public string StockSalesItemGroupNote { get; set; }
        public int? StockSalesItemGroupParentId { get; set; }

        public virtual StockSalesItemGroupTable StockSalesItemGroupParent { get; set; }
        public virtual ICollection<StockSalesItemGroupTable> InverseStockSalesItemGroupParent { get; set; }
        public virtual ICollection<StockSalesItemGroupNameTable> StockSalesItemGroupNameTable { get; set; }
    }
}
