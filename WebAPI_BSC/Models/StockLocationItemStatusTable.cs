using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockLocationItemStatusTable
    {
        public StockLocationItemStatusTable()
        {
            StockLocationItemTable = new HashSet<StockLocationItemTable>();
        }

        public int StockLocationItemStatusId { get; set; }
        public string StockLocationItemStatusKey { get; set; }
        public string StockLocationItemStatusName { get; set; }
        public string StockLocationItemStatusNote { get; set; }

        public virtual ICollection<StockLocationItemTable> StockLocationItemTable { get; set; }
    }
}
