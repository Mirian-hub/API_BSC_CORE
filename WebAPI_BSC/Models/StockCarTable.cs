using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockCarTable
    {
        public StockCarTable()
        {
            StockEntryTable = new HashSet<StockEntryTable>();
        }

        public int StockCarId { get; set; }
        public string StockCarKey { get; set; }
        public string StockCarName { get; set; }
        public string StockCarNote { get; set; }
        public int StockCarTypeId { get; set; }
        public int StockCarStatusId { get; set; }
        public int StockCarGroupId { get; set; }
        public int StockPersonId { get; set; }
        public int StockCustomerId { get; set; }

        public virtual StockCarGroupTable StockCarGroup { get; set; }
        public virtual StockCarStatusTable StockCarStatus { get; set; }
        public virtual StockCarTypeTable StockCarType { get; set; }
        public virtual ICollection<StockEntryTable> StockEntryTable { get; set; }
    }
}
