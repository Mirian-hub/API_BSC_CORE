using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockItemUnitTypeTable
    {
        public StockItemUnitTypeTable()
        {
            StockItemUnitTable = new HashSet<StockItemUnitTable>();
        }

        public int StockItemUnitTypeId { get; set; }
        public string StockItemUnitTypeKey { get; set; }
        public string StockItemUnitTypeName { get; set; }
        public string StockItemUnitTypeNote { get; set; }

        public virtual ICollection<StockItemUnitTable> StockItemUnitTable { get; set; }
    }
}
