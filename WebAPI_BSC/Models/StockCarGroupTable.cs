using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockCarGroupTable
    {
        public StockCarGroupTable()
        {
            InverseStockCarGroupParent = new HashSet<StockCarGroupTable>();
            StockCarTable = new HashSet<StockCarTable>();
        }

        public int StockCarGroupId { get; set; }
        public string StockCarGroupKey { get; set; }
        public string StockCarGroupName { get; set; }
        public string StockCarGroupNote { get; set; }
        public int StockCarGroupParentId { get; set; }

        public virtual StockCarGroupTable StockCarGroupParent { get; set; }
        public virtual ICollection<StockCarGroupTable> InverseStockCarGroupParent { get; set; }
        public virtual ICollection<StockCarTable> StockCarTable { get; set; }
    }
}
