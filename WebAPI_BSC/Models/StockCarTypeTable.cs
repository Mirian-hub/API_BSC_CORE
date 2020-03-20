using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockCarTypeTable
    {
        public StockCarTypeTable()
        {
            StockCarTable = new HashSet<StockCarTable>();
        }

        public int StockCarTypeId { get; set; }
        public string StockCarTypeKey { get; set; }
        public string StockCarTypeName { get; set; }
        public string StockCarTypeNote { get; set; }

        public virtual ICollection<StockCarTable> StockCarTable { get; set; }
    }
}
