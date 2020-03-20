using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockLocationRightTable
    {
        public int StockLocationId { get; set; }
        public int ShellUserId { get; set; }
        public int StockLocationRightId { get; set; }
        public int StockLocationRightStatusId { get; set; }

        public virtual StockLocationTable StockLocation { get; set; }
    }
}
