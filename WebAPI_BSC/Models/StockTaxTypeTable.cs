using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockTaxTypeTable
    {
        public StockTaxTypeTable()
        {
            StockTaxTable = new HashSet<StockTaxTable>();
        }

        public int StockTaxTypeId { get; set; }
        public string StockTaxTypeKey { get; set; }
        public string StockTaxTypeName { get; set; }
        public string StockTaxTypeNote { get; set; }

        public virtual ICollection<StockTaxTable> StockTaxTable { get; set; }
    }
}
