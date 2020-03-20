using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockRecipeStatusTable
    {
        public StockRecipeStatusTable()
        {
            StockRecipeTable = new HashSet<StockRecipeTable>();
        }

        public int StockRecipeStatusId { get; set; }
        public string StockRecipeStatusKey { get; set; }
        public string StockRecipeStatusName { get; set; }
        public string StockRecipeStatusNote { get; set; }

        public virtual ICollection<StockRecipeTable> StockRecipeTable { get; set; }
    }
}
