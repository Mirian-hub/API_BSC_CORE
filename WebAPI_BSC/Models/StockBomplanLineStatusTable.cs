using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockBomplanLineStatusTable
    {
        public StockBomplanLineStatusTable()
        {
            StockBomplanLineTable = new HashSet<StockBomplanLineTable>();
        }

        public int StockBomplanLineStatusId { get; set; }
        public string StockBomplanLineStatusKey { get; set; }
        public string StockBomplanLineStatusName { get; set; }
        public string StockBomplanLineStatusNote { get; set; }

        public virtual ICollection<StockBomplanLineTable> StockBomplanLineTable { get; set; }
    }
}
