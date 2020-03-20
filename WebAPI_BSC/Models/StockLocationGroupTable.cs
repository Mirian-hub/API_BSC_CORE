using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockLocationGroupTable
    {
        public StockLocationGroupTable()
        {
            InverseStockLocationGroupParent = new HashSet<StockLocationGroupTable>();
            StockLocationTable = new HashSet<StockLocationTable>();
        }

        public int StockLocationGroupId { get; set; }
        public string StockLocationGroupKey { get; set; }
        public string StockLocationGroupName { get; set; }
        public string StockLocationGroupNote { get; set; }
        public int? StockLocationGroupParentId { get; set; }

        public virtual StockLocationGroupTable StockLocationGroupParent { get; set; }
        public virtual ICollection<StockLocationGroupTable> InverseStockLocationGroupParent { get; set; }
        public virtual ICollection<StockLocationTable> StockLocationTable { get; set; }
    }
}
