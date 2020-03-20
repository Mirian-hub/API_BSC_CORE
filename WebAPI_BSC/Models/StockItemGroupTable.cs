using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockItemGroupTable
    {
        public StockItemGroupTable()
        {
            InverseStockItemGroupParent = new HashSet<StockItemGroupTable>();
            StockItemTable = new HashSet<StockItemTable>();
        }

        public int StockItemGroupId { get; set; }
        public string StockItemGroupKey { get; set; }
        public string StockItemGroupName { get; set; }
        public string StockItemGroupNote { get; set; }
        public int StockItemGroupParentId { get; set; }
        public int StockItemTypeId { get; set; }
        public int StockItemGroupSortId { get; set; }
        public int StockItemGroupDiscountId { get; set; }
        public double StockItemGroupDiscountFactor { get; set; }
        public double StockItemGroupDiscountTime { get; set; }
        public double StockItemGroupDiscountDuration { get; set; }

        public virtual StockItemGroupTable StockItemGroupParent { get; set; }
        public virtual ICollection<StockItemGroupTable> InverseStockItemGroupParent { get; set; }
        public virtual ICollection<StockItemTable> StockItemTable { get; set; }
    }
}
