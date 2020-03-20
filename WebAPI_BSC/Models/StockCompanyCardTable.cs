using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockCompanyCardTable
    {
        public int StockCompanyCardId { get; set; }
        public int StockCompanyCardStatusId { get; set; }
        public string StockCompanyCardKey { get; set; }
        public string StockCompanyCardName { get; set; }
        public string StockCompanyCardNote { get; set; }
        public DateTime StockCompanyCardValidFrom { get; set; }
        public DateTime StockCompanyCardValidTo { get; set; }
        public int StockCompanyId { get; set; }
        public int StockCompanyCardTypeId { get; set; }
        public int StockCompanyCardGroupId { get; set; }
        public int StockItemId { get; set; }
        public double StockQuantity { get; set; }
        public double StockAmountLimit { get; set; }
        public double StockAmountBalance { get; set; }
    }
}
