using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockPriceLineStatusTable
    {
        public int StockPriceLineStatusId { get; set; }
        public string StockPriceLineStatusKey { get; set; }
        public string StockPriceLineStatusName { get; set; }
        public string StockPriceLineStatusNote { get; set; }
    }
}
