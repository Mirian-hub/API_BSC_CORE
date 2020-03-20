using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockDiscountMethodTable
    {
        public int StockDiscountMethodId { get; set; }
        public string StockDiscountMethodKey { get; set; }
        public string StockDiscountMethodName { get; set; }
        public string StockDiscountMethodNote { get; set; }
        public int StockDiscountMethodTypeId { get; set; }
        public int StockDiscountMethodStatusId { get; set; }
        public DateTime? StockDiscountMethodValidFrom { get; set; }
        public DateTime? StockDiscountMethodValidTo { get; set; }
        public double StockDiscountMethodServiceFactor { get; set; }
        public double StockDiscountMethodfFactor { get; set; }
        public double StockDiscountMethodFiscalFactor { get; set; }
    }
}
