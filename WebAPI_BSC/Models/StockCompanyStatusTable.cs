using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockCompanyStatusTable
    {
        public StockCompanyStatusTable()
        {
            StockCompanyTable = new HashSet<StockCompanyTable>();
        }

        public int StockCompanyStatusId { get; set; }
        public string StockCompanyStatusKey { get; set; }
        public string StockCompanyStatusName { get; set; }
        public string StockCompanyStatusNote { get; set; }

        public virtual ICollection<StockCompanyTable> StockCompanyTable { get; set; }
    }
}
