using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockItemUnitStatusTable
    {
        public StockItemUnitStatusTable()
        {
            StockItemUnitTable = new HashSet<StockItemUnitTable>();
        }

        public int StockItemUnitStatusId { get; set; }
        public string StockItemUnitStatusKey { get; set; }
        public string StockItemUnitStatusName { get; set; }
        public string StockItemUnitStatusNote { get; set; }

        public virtual ICollection<StockItemUnitTable> StockItemUnitTable { get; set; }
    }
}
