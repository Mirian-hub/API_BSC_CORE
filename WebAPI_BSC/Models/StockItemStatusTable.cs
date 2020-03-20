using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockItemStatusTable
    {
        public StockItemStatusTable()
        {
            StockItemTable = new HashSet<StockItemTable>();
        }

        public int StockItemStatusId { get; set; }
        public string StockItemStatusKey { get; set; }
        public string StockItemStatusName { get; set; }
        public string StockItemStatusNote { get; set; }

        public virtual ICollection<StockItemTable> StockItemTable { get; set; }
    }
}
