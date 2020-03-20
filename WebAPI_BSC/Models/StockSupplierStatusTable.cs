using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockSupplierStatusTable
    {
        public int StockSupplierStatusId { get; set; }
        public string StockSupplierStatusKey { get; set; }
        public string StockSupplierStatusName { get; set; }
        public string StockSupplierStatusNote { get; set; }
    }
}
