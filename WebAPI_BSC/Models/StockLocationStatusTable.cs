using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockLocationStatusTable
    {
        public StockLocationStatusTable()
        {
            StockLocationTable = new HashSet<StockLocationTable>();
        }

        public int StockLocationStatusId { get; set; }
        public string StockLocationStatusKey { get; set; }
        public string StockLocationStatusName { get; set; }
        public string StockLocationStatusNote { get; set; }

        public virtual ICollection<StockLocationTable> StockLocationTable { get; set; }
    }
}
