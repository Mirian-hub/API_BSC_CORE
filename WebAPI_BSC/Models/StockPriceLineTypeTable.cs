using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockPriceLineTypeTable
    {
        public int StockPriceLineTypeId { get; set; }
        public string StockPriceLineTypeKey { get; set; }
        public string StockPriceLineTypeName { get; set; }
        public string StockPriceLineTypeNote { get; set; }
    }
}
