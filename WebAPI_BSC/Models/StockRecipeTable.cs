using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockRecipeTable
    {
        public int StockRecipeId { get; set; }
        public string StockRecipeKey { get; set; }
        public string StockRecipeName { get; set; }
        public string StockRecipeNote { get; set; }
        public int StockRecipeTypeId { get; set; }
        public int StockRecipeStatusId { get; set; }
        public int StockItemId { get; set; }
        public double StockRecipeQuantity { get; set; }
        public int StockRecipeItemId { get; set; }
        public DateTime StockRecipeValidFrom { get; set; }
        public DateTime? StockRecipeValidTo { get; set; }
        public int StockRecipeSortId { get; set; }
        public int StockLocationId { get; set; }
        public double StockItemProtein { get; set; }
        public double StockItemFat { get; set; }
        public double StockItemCarbohydrate { get; set; }
        public double StockItemCalorie { get; set; }

        public virtual StockRecipeStatusTable StockRecipeStatus { get; set; }
    }
}
