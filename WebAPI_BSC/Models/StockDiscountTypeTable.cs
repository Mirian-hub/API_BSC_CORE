using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockDiscountTypeTable
    {
        public StockDiscountTypeTable()
        {
            StockDiscountTable = new HashSet<StockDiscountTable>();
        }

        public int StockDiscountTypeId { get; set; }
        public string StockDiscountTypeKey { get; set; }
        public string StockDiscountTypeName { get; set; }
        public string StockDiscountTypeNote { get; set; }

        public virtual ICollection<StockDiscountTable> StockDiscountTable { get; set; }
    }
}
