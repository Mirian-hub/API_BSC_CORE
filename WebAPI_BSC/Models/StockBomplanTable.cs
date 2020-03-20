using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockBomplanTable
    {
        public StockBomplanTable()
        {
            StockBomplanLineTable = new HashSet<StockBomplanLineTable>();
        }

        public int StockBomplanId { get; set; }
        public string StockBomplanKey { get; set; }
        public string StockBomplanName { get; set; }
        public string StockBomplanNote { get; set; }
        public int StockBomplanTypeId { get; set; }
        public int StockBomplanStatusId { get; set; }
        public int StockBomplanGroupId { get; set; }
        public DateTime StockBomplanDate { get; set; }
        public int StockItemId { get; set; }
        public int StockLocationId { get; set; }
        public int StockCompanyId { get; set; }
        public int StockCompanyId2 { get; set; }

        public virtual StockBomplanGroupTable StockBomplanGroup { get; set; }
        public virtual StockBomplanStatusTable StockBomplanStatus { get; set; }
        public virtual StockBomplanTypeTable StockBomplanType { get; set; }
        public virtual StockItemTable StockItem { get; set; }
        public virtual ICollection<StockBomplanLineTable> StockBomplanLineTable { get; set; }
    }
}
