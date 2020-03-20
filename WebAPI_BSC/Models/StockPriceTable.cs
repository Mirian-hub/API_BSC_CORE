using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockPriceTable
    {
        public StockPriceTable()
        {
            StockCompanyTable = new HashSet<StockCompanyTable>();
            StockPriceLineTable = new HashSet<StockPriceLineTable>();
        }

        public int StockPriceId { get; set; }
        public string StockPriceKey { get; set; }
        public string StockPriceName { get; set; }
        public string StockPriceNote { get; set; }
        public int StockPriceTypeId { get; set; }
        public int StockPriceStatusId { get; set; }

        public virtual StockPriceStatusTable StockPriceStatus { get; set; }
        public virtual StockPriceTypeTable StockPriceType { get; set; }
        public virtual ICollection<StockCompanyTable> StockCompanyTable { get; set; }
        public virtual ICollection<StockPriceLineTable> StockPriceLineTable { get; set; }
    }
}
