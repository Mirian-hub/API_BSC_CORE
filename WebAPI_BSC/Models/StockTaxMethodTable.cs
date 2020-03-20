using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockTaxMethodTable
    {
        public int StockTaxMethodId { get; set; }
        public string StockTaxMethodKey { get; set; }
        public string StockTaxMethodName { get; set; }
        public string StockTaxMethodNote { get; set; }
        public int StockTaxMethodStatusId { get; set; }
        public double StockTaxMethodFactor { get; set; }
    }
}
