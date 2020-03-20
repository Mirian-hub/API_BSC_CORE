using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ZStockEntrySubTypeTable
    {
        public int StockEntrySubTypeId { get; set; }
        public string StockEntrySubTypeKey { get; set; }
        public string StockEntrySubTypeName { get; set; }
        public string StockEntrySubTypeNote { get; set; }
    }
}
