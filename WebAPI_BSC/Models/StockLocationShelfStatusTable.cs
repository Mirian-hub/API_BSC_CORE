using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockLocationShelfStatusTable
    {
        public StockLocationShelfStatusTable()
        {
            StockLocationShelfTable = new HashSet<StockLocationShelfTable>();
        }

        public int StockLocationShelfStatusId { get; set; }
        public string StockLocationShelfStatusKey { get; set; }
        public string StockLocationShelfStatusName { get; set; }
        public string StockLocationShelfStatusNote { get; set; }

        public virtual ICollection<StockLocationShelfTable> StockLocationShelfTable { get; set; }
    }
}
