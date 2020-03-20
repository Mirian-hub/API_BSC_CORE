using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockUsageTypeTable
    {
        public StockUsageTypeTable()
        {
            StockLocationItemTable = new HashSet<StockLocationItemTable>();
        }

        public int StockUsageTypeId { get; set; }
        public string StockUsageTypeKey { get; set; }
        public string StockUsageTypeName { get; set; }
        public string StockUsageTypeNote { get; set; }
        public bool S1 { get; set; }
        public bool S2 { get; set; }
        public bool T1 { get; set; }
        public bool T2 { get; set; }
        public bool M1 { get; set; }
        public bool M2 { get; set; }

        public virtual ICollection<StockLocationItemTable> StockLocationItemTable { get; set; }
    }
}
