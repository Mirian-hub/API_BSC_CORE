using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockBomplanStatusTable
    {
        public StockBomplanStatusTable()
        {
            StockBomplanTable = new HashSet<StockBomplanTable>();
        }

        public int StockBomplanStatusId { get; set; }
        public string StockBomplanStatusKey { get; set; }
        public string StockBomplanStatusName { get; set; }
        public string StockBomplanStatusNote { get; set; }

        public virtual ICollection<StockBomplanTable> StockBomplanTable { get; set; }
    }
}
