using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockPayMethodTable
    {
        public int StockPayMethodId { get; set; }
        public string StockPayMethodKey { get; set; }
        public string StockPayMethodName { get; set; }
        public string StockPayMethodNote { get; set; }
        public int StockPayMethodStatusId { get; set; }
    }
}
