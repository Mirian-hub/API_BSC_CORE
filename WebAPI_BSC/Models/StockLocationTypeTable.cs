using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockLocationTypeTable
    {
        public StockLocationTypeTable()
        {
            StockLocationTable = new HashSet<StockLocationTable>();
        }

        public int StockLocationTypeId { get; set; }
        public string StockLocationTypeKey { get; set; }
        public string StockLocationTypeName { get; set; }
        public string StockLocationTypeNote { get; set; }

        public virtual ICollection<StockLocationTable> StockLocationTable { get; set; }
    }
}
