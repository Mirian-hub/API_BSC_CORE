using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockPersonGroupTable
    {
        public StockPersonGroupTable()
        {
            InverseStockPersonGroupParent = new HashSet<StockPersonGroupTable>();
            StockPersonTable = new HashSet<StockPersonTable>();
        }

        public int StockPersonGroupId { get; set; }
        public string StockPersonGroupKey { get; set; }
        public string StockPersonGroupName { get; set; }
        public string StockPersonGroupNote { get; set; }
        public int? StockPersonGroupParentId { get; set; }

        public virtual StockPersonGroupTable StockPersonGroupParent { get; set; }
        public virtual ICollection<StockPersonGroupTable> InverseStockPersonGroupParent { get; set; }
        public virtual ICollection<StockPersonTable> StockPersonTable { get; set; }
    }
}
