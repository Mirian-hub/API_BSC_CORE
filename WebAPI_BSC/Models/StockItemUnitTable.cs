using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockItemUnitTable
    {
        public StockItemUnitTable()
        {
            StockItemTable = new HashSet<StockItemTable>();
        }

        public int StockItemUnitId { get; set; }
        public string StockItemUnitKey { get; set; }
        public string StockItemUnitName { get; set; }
        public int StockItemUnitTypeId { get; set; }
        public int StockItemUnitStatusId { get; set; }
        public int StockItemUnitGroupId { get; set; }
        public int StockItemUnitSortId { get; set; }

        public virtual StockItemUnitGroupTable StockItemUnitGroup { get; set; }
        public virtual StockItemUnitStatusTable StockItemUnitStatus { get; set; }
        public virtual StockItemUnitTypeTable StockItemUnitType { get; set; }
        public virtual ICollection<StockItemTable> StockItemTable { get; set; }
    }
}
