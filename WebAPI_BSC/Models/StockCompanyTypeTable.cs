using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockCompanyTypeTable
    {
        public StockCompanyTypeTable()
        {
            StockCompanyTable = new HashSet<StockCompanyTable>();
        }

        public int StockCompanyTypeId { get; set; }
        public string StockCompanyTypeKey { get; set; }
        public string StockCompanyTypeName { get; set; }
        public string StockCompanyTypeNote { get; set; }

        public virtual ICollection<StockCompanyTable> StockCompanyTable { get; set; }
    }
}
