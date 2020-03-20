using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockItemTypeTable
    {
        public StockItemTypeTable()
        {
            StockItemTable = new HashSet<StockItemTable>();
        }

        public int StockItemTypeId { get; set; }
        public string StockItemTypeKey { get; set; }
        public string StockItemTypeName { get; set; }
        public string StockItemTypeNote { get; set; }

        public virtual ICollection<StockItemTable> StockItemTable { get; set; }
    }
}
