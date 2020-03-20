using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockBudgetTypeTable
    {
        public int StockBudgetTypeId { get; set; }
        public string StockBudgetTypeKey { get; set; }
        public string StockBudgetTypeName { get; set; }
        public string StockBudgetTypeNote { get; set; }
    }
}
