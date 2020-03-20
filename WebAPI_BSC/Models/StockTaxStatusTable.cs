using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockTaxStatusTable
    {
        public StockTaxStatusTable()
        {
            StockTaxTable = new HashSet<StockTaxTable>();
        }

        public int StockTaxStatusId { get; set; }
        public string StockTaxStatusKey { get; set; }
        public string StockTaxStatusName { get; set; }
        public string StockTaxStatusNote { get; set; }

        public virtual ICollection<StockTaxTable> StockTaxTable { get; set; }
    }
}
