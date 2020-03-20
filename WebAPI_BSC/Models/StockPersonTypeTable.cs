using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockPersonTypeTable
    {
        public StockPersonTypeTable()
        {
            StockPersonTable = new HashSet<StockPersonTable>();
        }

        public int StockPersonTypeId { get; set; }
        public string StockPersonTypeKey { get; set; }
        public string StockPersonTypeName { get; set; }
        public string StockPersonTypeNote { get; set; }

        public virtual ICollection<StockPersonTable> StockPersonTable { get; set; }
    }
}
