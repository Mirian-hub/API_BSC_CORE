using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockLocationShelfTypeTable
    {
        public StockLocationShelfTypeTable()
        {
            StockLocationShelfTable = new HashSet<StockLocationShelfTable>();
        }

        public int StockLocationShelfTypeId { get; set; }
        public string StockLocationShelfTypeKey { get; set; }
        public string StockLocationShelfTypeName { get; set; }
        public string StockLocationShelfTypeNote { get; set; }

        public virtual ICollection<StockLocationShelfTable> StockLocationShelfTable { get; set; }
    }
}
