using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockAllocationBaseTable
    {
        public int StockAllocationBaseId { get; set; }
        public string StockAllocationBaseKey { get; set; }
        public string StockAllocationBaseName { get; set; }
        public string StockAllocationBaseNote { get; set; }
    }
}
