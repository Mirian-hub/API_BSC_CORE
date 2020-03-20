using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockRecipeTypeTable
    {
        public int StockRecipeTypeId { get; set; }
        public string StockRecipeTypeKey { get; set; }
        public string StockRecipeTypeName { get; set; }
        public string StockRecipeTypeNote { get; set; }
    }
}
