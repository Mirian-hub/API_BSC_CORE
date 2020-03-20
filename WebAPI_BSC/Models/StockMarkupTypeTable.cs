using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockMarkupTypeTable
    {
        public StockMarkupTypeTable()
        {
            StockMarkupTable = new HashSet<StockMarkupTable>();
        }

        public int StockMarkupTypeId { get; set; }
        public string StockMarkupTypeKey { get; set; }
        public string StockMarkupTypeName { get; set; }
        public string StockMarkupTypeNote { get; set; }

        public virtual ICollection<StockMarkupTable> StockMarkupTable { get; set; }
    }
}
