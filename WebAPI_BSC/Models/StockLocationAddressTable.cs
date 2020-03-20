using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockLocationAddressTable
    {
        public int StockCompanyId { get; set; }
        public string StockLocationAddress { get; set; }
        public int StockLocationId { get; set; }

        public virtual StockCompanyTable StockCompany { get; set; }
        public virtual StockLocationTable StockLocation { get; set; }
    }
}
