using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockItemUnitGroupTable
    {
        public StockItemUnitGroupTable()
        {
            InverseStockItemUnitGroupParent = new HashSet<StockItemUnitGroupTable>();
            StockItemUnitTable = new HashSet<StockItemUnitTable>();
        }

        public int StockItemUnitGroupId { get; set; }
        public string StockItemUnitGroupKey { get; set; }
        public string StockItemUnitGroupName { get; set; }
        public string StockItemUnitGroupNote { get; set; }
        public int? StockItemUnitGroupParentId { get; set; }

        public virtual StockItemUnitGroupTable StockItemUnitGroupParent { get; set; }
        public virtual ICollection<StockItemUnitGroupTable> InverseStockItemUnitGroupParent { get; set; }
        public virtual ICollection<StockItemUnitTable> StockItemUnitTable { get; set; }
    }
}
