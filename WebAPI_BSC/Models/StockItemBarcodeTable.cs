using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockItemBarcodeTable
    {
        public int StockItemBarcodeId { get; set; }
        public int StockItemId { get; set; }
        public string StockItemBarcodeKey { get; set; }
        public string StockItemBarcodeName { get; set; }

        public virtual StockItemTable StockItem { get; set; }
    }
}
