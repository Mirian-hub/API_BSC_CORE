using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockCustomerTypeTable
    {
        public int StockCustomerTypeId { get; set; }
        public string StockCustomerTypeKey { get; set; }
        public string StockCustomerTypeName { get; set; }
        public string StockCustomerTypeNote { get; set; }
    }
}
