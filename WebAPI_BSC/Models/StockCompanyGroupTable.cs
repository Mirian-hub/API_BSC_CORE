using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockCompanyGroupTable
    {
        public StockCompanyGroupTable()
        {
            InverseStockCompanyGroupParent = new HashSet<StockCompanyGroupTable>();
            StockCompanyTable = new HashSet<StockCompanyTable>();
        }

        public int StockCompanyGroupId { get; set; }
        public string StockCompanyGroupKey { get; set; }
        public string StockCompanyGroupName { get; set; }
        public string StockCompanyGroupNote { get; set; }
        public int StockCompanyGroupParentId { get; set; }
        public int StockCompanyTypeId { get; set; }

        public virtual StockCompanyGroupTable StockCompanyGroupParent { get; set; }
        public virtual ICollection<StockCompanyGroupTable> InverseStockCompanyGroupParent { get; set; }
        public virtual ICollection<StockCompanyTable> StockCompanyTable { get; set; }
    }
}
