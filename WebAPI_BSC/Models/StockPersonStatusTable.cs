using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockPersonStatusTable
    {
        public StockPersonStatusTable()
        {
            StockPersonTable = new HashSet<StockPersonTable>();
        }

        public int StockPersonStatusId { get; set; }
        public string StockPersonStatusKey { get; set; }
        public string StockPersonStatusName { get; set; }
        public string StockPersonStatusNote { get; set; }

        public virtual ICollection<StockPersonTable> StockPersonTable { get; set; }
    }
}
