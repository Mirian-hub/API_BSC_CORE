using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockBomplanTypeTable
    {
        public StockBomplanTypeTable()
        {
            StockBomplanTable = new HashSet<StockBomplanTable>();
        }

        public int StockBomplanTypeId { get; set; }
        public string StockBomplanTypeKey { get; set; }
        public string StockBomplanTypeName { get; set; }
        public string StockBomplanTypeNote { get; set; }

        public virtual ICollection<StockBomplanTable> StockBomplanTable { get; set; }
    }
}
