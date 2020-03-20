using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockCompanyCardGroupTable
    {
        public int StockCompanyCardGroupId { get; set; }
        public string StockCompanyCardGroupKey { get; set; }
        public string StockCompanyCardGroupName { get; set; }
        public string StockCompanyCardGroupNote { get; set; }
        public int StockCompanyCardGroupParentId { get; set; }
    }
}
