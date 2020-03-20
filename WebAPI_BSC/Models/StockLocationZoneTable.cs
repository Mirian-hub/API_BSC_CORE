using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockLocationZoneTable
    {
        public int StockLocationZoneId { get; set; }
        public string StockLocationZoneKey { get; set; }
        public string StockLocationZoneName { get; set; }
        public string StockLocationZoneNote { get; set; }
    }
}
