using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ZStockEntryProcessTable
    {
        public int StockEntryProcessId { get; set; }
        public string StockEntryProcessKey { get; set; }
        public string StockEntryProcessName { get; set; }
        public string StockEntryProcesssNote { get; set; }
    }
}
