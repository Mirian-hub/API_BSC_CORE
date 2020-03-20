using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockBomplanLineTypeTable
    {
        public StockBomplanLineTypeTable()
        {
            StockBomplanLineTable = new HashSet<StockBomplanLineTable>();
        }

        public int StockBomplanLineTypeId { get; set; }
        public string StockBomplanLineTypeKey { get; set; }
        public string StockBomplanLineTypeName { get; set; }
        public string StockBomplanLineTypeNote { get; set; }

        public virtual ICollection<StockBomplanLineTable> StockBomplanLineTable { get; set; }
    }
}
