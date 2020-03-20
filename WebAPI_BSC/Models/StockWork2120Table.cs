using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockWork2120Table
    {
        public int ShellUserId { get; set; }
        public int ShellOperationId { get; set; }
        public int ShellWorkPageId { get; set; }
        public int ShellWorkPageLineId { get; set; }
        public double ShellWorkPageSign { get; set; }
        public int ShellWorkPageAuto { get; set; }
        public int ShellWorkTrigger { get; set; }
        public int ShellMessageId { get; set; }
        public int ShellWorkStatusId { get; set; }
        public int ShellComputerId { get; set; }
        public int ShellCustomerId { get; set; }
        public int? StockEntryId { get; set; }
        public long StockEntryLineId { get; set; }
        public string StockEntryKey { get; set; }
        public string StockEntryName { get; set; }
        public DateTime StockEntryDateInitial { get; set; }
        public DateTime StockEntryDate { get; set; }
        public TimeSpan StockEntryTime { get; set; }
        public int StockEntryTypeId { get; set; }
        public int StockEntryStatusId { get; set; }
        public int StockEntryParentId { get; set; }
        public long StockEntryLineParentId { get; set; }
        public int TransLocationShelfId { get; set; }
        public int TransCompanyId { get; set; }
        public int TransCompanyCardId { get; set; }
        public int TransTaxMethodId { get; set; }
        public double TransTaxMethodFactor { get; set; }
        public int TransItemId { get; set; }
        public int TransItemUnitId { get; set; }
        public double TransItemUnitFactor { get; set; }
        public string TransItemName { get; set; }
        public double TransQuantityInitial { get; set; }
        public double TransQuantity { get; set; }
        public int TransQuantityAllowChange { get; set; }
        public double TransPrice { get; set; }
        public int TransPriceTaxId { get; set; }
        public double TransPriceTaxFactor { get; set; }
        public double TransAmount { get; set; }
        public double TransTaxAmount { get; set; }
        public double TransBaseAmount { get; set; }
        public int TransServiceId { get; set; }
        public double TransServiceFactor { get; set; }
        public double TransServiceAmount { get; set; }
        public double TransServiceTaxAmount { get; set; }
        public double TransServiceBaseAmount { get; set; }
        public int TransDiscountId { get; set; }
        public double TransDiscountFactor { get; set; }
        public double TransDiscountAmount { get; set; }
        public double TransDiscountTaxAmount { get; set; }
        public double TransDiscountBaseAmount { get; set; }
        public double TransTotalAmount { get; set; }
        public double TransTotalTaxAmount { get; set; }
        public double TransTotalBaseAmount { get; set; }
        public double TransTotalPayAmount { get; set; }
        public int TransPayPeriodId { get; set; }
        public int TransPayMethodId { get; set; }
        public double TransPayCashAmount { get; set; }
        public double TransPayCashChangeAmount { get; set; }
        public double TransPayBankAmount { get; set; }
        public double TransPayInvoiceAmount { get; set; }
        public double TransPayOtherAmount { get; set; }
        public int StockLocationId { get; set; }
        public int StockItemId { get; set; }
        public string StockItemName { get; set; }
        public double StockQuantity { get; set; }
        public double StockAmount { get; set; }
        public DateTime ShellCreateDate { get; set; }
        public int ShellCreateUserId { get; set; }
    }
}
