using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockCarStatusTable
    {
        public StockCarStatusTable()
        {
            StockCarTable = new HashSet<StockCarTable>();
        }

        public int StockCarStatusId { get; set; }
        public string StockCarStatusKey { get; set; }
        public string StockCarStatusName { get; set; }
        public string StockCarStatusNote { get; set; }

        public virtual ICollection<StockCarTable> StockCarTable { get; set; }
    }
}
