using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockWorkValuationTable
    {
        public int ShellUserId { get; set; }
        public int ShellOperationId { get; set; }
        public int ShellWorkPageId { get; set; }
        public int ShellWorkPageLineId { get; set; }
        public int ShellMessageId { get; set; }
        public DateTime? ShellDateFrom { get; set; }
        public DateTime? ShellDateTo { get; set; }
        public int? StockLocationId { get; set; }
        public int? StockItemId { get; set; }
        public double StockQuantity { get; set; }
        public double StockQuantity1 { get; set; }
        public double StockQuantity2 { get; set; }
        public double StockAmount { get; set; }
        public double StockAmount1 { get; set; }
        public double StockAmount2 { get; set; }
        public DateTime? StockEntryDate { get; set; }
        public int? StockEntryId { get; set; }
        public int? StockEntryLineSortId { get; set; }
        public int? StockEntryTypeId { get; set; }
        public string StockEntryKey { get; set; }
        public string StockEntryName { get; set; }
        public long? StockEntryLineId { get; set; }
        public int? StockEntryLineTypeId { get; set; }
        public double Amount { get; set; }
        public double TaxAmount { get; set; }
        public double FullAmount { get; set; }
        public double Price { get; set; }
        public int? TaxCodeId { get; set; }
        public int? StockEntryParentId { get; set; }
        public long? StockEntryLineParentId { get; set; }
        public double StockPrice { get; set; }
        public double StockPrice1 { get; set; }
        public double StockPrice2 { get; set; }
        public int ShellWorkStatusId { get; set; }
    }
}
