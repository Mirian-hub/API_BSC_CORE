using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockLocationShelfTable
    {
        public int StockLocationId { get; set; }
        public int StockLocationShelfSortId { get; set; }
        public string StockLocationShelfKey { get; set; }
        public string StockLocationShelfName { get; set; }
        public string StockLocationShelfNote { get; set; }
        public int StockLocationShelfStatusId { get; set; }
        public int StockLocationShelfId { get; set; }
        public int StockLocationShelfTypeId { get; set; }

        public virtual StockLocationTable StockLocation { get; set; }
        public virtual StockLocationShelfStatusTable StockLocationShelfStatus { get; set; }
        public virtual StockLocationShelfTypeTable StockLocationShelfType { get; set; }
    }
}
