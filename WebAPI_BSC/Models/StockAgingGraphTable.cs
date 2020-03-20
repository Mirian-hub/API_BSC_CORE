using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockAgingGraphTable
    {
        public int StockAgingGraphId { get; set; }
        public string StockAgingGraphKey { get; set; }
        public string StockAgingGraphName { get; set; }
        public int? StockAgingGraphFrom { get; set; }
        public int? StockAgingGraphTo { get; set; }
    }
}
