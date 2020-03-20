using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockMarkupGroupTable
    {
        public StockMarkupGroupTable()
        {
            InverseStockMarkupGroupParent = new HashSet<StockMarkupGroupTable>();
            StockItemTable = new HashSet<StockItemTable>();
            StockMarkupTable = new HashSet<StockMarkupTable>();
        }

        public int StockMarkupGroupId { get; set; }
        public string StockMarkupGroupKey { get; set; }
        public string StockMarkupGroupName { get; set; }
        public string StockMarkupGroupNote { get; set; }
        public int? StockMarkupGroupParentId { get; set; }

        public virtual StockMarkupGroupTable StockMarkupGroupParent { get; set; }
        public virtual ICollection<StockMarkupGroupTable> InverseStockMarkupGroupParent { get; set; }
        public virtual ICollection<StockItemTable> StockItemTable { get; set; }
        public virtual ICollection<StockMarkupTable> StockMarkupTable { get; set; }
    }
}
