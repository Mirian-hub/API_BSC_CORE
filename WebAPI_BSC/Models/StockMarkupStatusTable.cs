using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockMarkupStatusTable
    {
        public StockMarkupStatusTable()
        {
            StockMarkupTable = new HashSet<StockMarkupTable>();
        }

        public int StockMarkupStatusId { get; set; }
        public string StockMarkupStatusKey { get; set; }
        public string StockMarkupStatusName { get; set; }
        public string StockMarkupStatusNote { get; set; }

        public virtual ICollection<StockMarkupTable> StockMarkupTable { get; set; }
    }
}
