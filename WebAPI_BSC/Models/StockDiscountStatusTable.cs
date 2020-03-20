using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockDiscountStatusTable
    {
        public StockDiscountStatusTable()
        {
            StockDiscountTable = new HashSet<StockDiscountTable>();
        }

        public int StockDiscountStatusId { get; set; }
        public string StockDiscountStatusKey { get; set; }
        public string StockDiscountStatusName { get; set; }
        public string StockDiscountStatusNote { get; set; }

        public virtual ICollection<StockDiscountTable> StockDiscountTable { get; set; }
    }
}
