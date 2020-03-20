using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockPriceLineTable
    {
        public int StockPriceId { get; set; }
        public long StockPriceLineId { get; set; }
        public string StockPriceLineKey { get; set; }
        public string StockPriceLineName { get; set; }
        public int StockPriceLineSortId { get; set; }
        public int StockPriceLineSortId2 { get; set; }
        public int StockPriceLineTypeId { get; set; }
        public int StockPriceLineStatusId { get; set; }
        public DateTime StockPriceLineValidFrom { get; set; }
        public DateTime StockPriceLineValidTo { get; set; }
        public int StockCompanyId { get; set; }
        public string StockCompanyItemKey { get; set; }
        public string StockCompanyItemName { get; set; }
        public string StockCompanyItemUnitName { get; set; }
        public int StockItemId { get; set; }
        public double StockPrice { get; set; }
        public int StockPriceTaxId { get; set; }
        public double StockPriceQuantityFactor { get; set; }
        public double StockBasePrice { get; set; }
        public double StockBasePriceFactor { get; set; }
        public int StockEntryId { get; set; }
        public int StockLocationId { get; set; }
        public DateTime ShellCreationDate { get; set; }
        public int StockSalesItemGroupId { get; set; }

        public virtual StockEntryTable StockEntry { get; set; }
        public virtual StockPriceTable StockPriceNavigation { get; set; }
    }
}
