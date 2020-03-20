using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class RsWaybillLineTable
    {
        public long RswaybillLineId { get; set; }
        public long RswaybillId { get; set; }
        public int RswaybillLineStatusId { get; set; }
        public string RsitemKey { get; set; }
        public string RsitemName { get; set; }
        public int RsunitId { get; set; }
        public string RsunitName { get; set; }
        public double Rsquantity { get; set; }
        public double Rsprice { get; set; }
        public int? RstaxId { get; set; }
        public int? RstaxId2 { get; set; }
        public double Rsamount { get; set; }
        public int? StockItemId { get; set; }
        public int? StockItemUnitId { get; set; }
        public double? StockItemUnitFactor { get; set; }
        public int? StockPriceLineTypeId { get; set; }
        public double? StockPrice { get; set; }
        public int? StockPriceTaxId { get; set; }
        public double? StockPriceTaxFactor { get; set; }
        public int? StockEntryId { get; set; }
        public long? StockEntryLineId { get; set; }
        public int? ShellMessageId { get; set; }
        public int ShellProcessId { get; set; }
        public double? StockAmount { get; set; }
        public double? StockTaxAmount { get; set; }
        public double? StockBaseAmount { get; set; }
        public int? StockMarkupGroupId { get; set; }
        public int? StockMarkupId { get; set; }
        public double? TransPrice { get; set; }
        public int? TransTaxId { get; set; }
        public double? TransTaxFactor { get; set; }
        public double? TransAmount { get; set; }
        public double? TransTaxAmount { get; set; }
        public double? TransBaseAmount { get; set; }
    }
}
