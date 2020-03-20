using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockCustomerStatusTable
    {
        public int StockCustomerStatusId { get; set; }
        public string StockCustomerStatusKey { get; set; }
        public string StockCustomerStatusName { get; set; }
        public string StockCustomerStatusNote { get; set; }
    }
}
