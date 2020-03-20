using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockItemKindTable
    {
        public int StockItemId { get; set; }
        public string StockItemKindKey { get; set; }
        public string StockItemKindName { get; set; }
        public int StockItemKindId { get; set; }
        public int StockItemKindStatusId { get; set; }
    }
}
