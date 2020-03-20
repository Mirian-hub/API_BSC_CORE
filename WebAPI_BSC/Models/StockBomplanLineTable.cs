using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockBomplanLineTable
    {
        public long StockBomplanLineId { get; set; }
        public string StockBomplanLineKey { get; set; }
        public string StockBomplanLineName { get; set; }
        public int StockBomplanLineTypeId { get; set; }
        public int StockBomplanLineStatusId { get; set; }
        public int StockBomplanId { get; set; }
        public int StockItemId { get; set; }
        public double StockQuantity { get; set; }

        public virtual StockBomplanTable StockBomplan { get; set; }
        public virtual StockBomplanLineStatusTable StockBomplanLineStatus { get; set; }
        public virtual StockBomplanLineTypeTable StockBomplanLineType { get; set; }
        public virtual StockItemTable StockItem { get; set; }
    }
}
