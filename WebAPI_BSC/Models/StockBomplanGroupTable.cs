using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockBomplanGroupTable
    {
        public StockBomplanGroupTable()
        {
            InverseStockBomplanGroupParent = new HashSet<StockBomplanGroupTable>();
            StockBomplanTable = new HashSet<StockBomplanTable>();
        }

        public int StockBomplanGroupId { get; set; }
        public string StockBomplanGroupKey { get; set; }
        public string StockBomplanGroupName { get; set; }
        public string StockBomplanGroupNote { get; set; }
        public int? StockBomplanGroupParentId { get; set; }

        public virtual StockBomplanGroupTable StockBomplanGroupParent { get; set; }
        public virtual ICollection<StockBomplanGroupTable> InverseStockBomplanGroupParent { get; set; }
        public virtual ICollection<StockBomplanTable> StockBomplanTable { get; set; }
    }
}
