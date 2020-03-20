using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockWork21xZtable
    {
        public int ShellUserId { get; set; }
        public int ShellOperationId { get; set; }
        public int ShellWorkPageId { get; set; }
        public int ShellWorkPageLineId { get; set; }
        public int? ShellWorkPageParentId { get; set; }
        public int? ShellWorkPageLineParentId { get; set; }
        public double ShellWorkPageSign { get; set; }
        public int ShellWorkPageAuto { get; set; }
        public int ShellWorkTrigger { get; set; }
        public int ShellMessageId { get; set; }
        public int ShellWorkStatusId { get; set; }
        public int ShellComputerId { get; set; }
        public int ShellCustomerId { get; set; }
        public int StockEntryId { get; set; }
        public long StockEntryLineId { get; set; }
        public string StockEntryKey { get; set; }
        public string StockEntryName { get; set; }
        public DateTime StockEntryDate { get; set; }
        public DateTime? StockEntryDateInitial { get; set; }
        public int StockEntryTypeId { get; set; }
        public int StockEntryStatusId { get; set; }
        public int StockLocationId { get; set; }
        public int TransCompanyId { get; set; }
        public int TransCompanyCardId { get; set; }
        public int TransTaxMethodId { get; set; }
        public double TransTaxMethodFactor { get; set; }
        public double TransQuantity { get; set; }
        public double TransAmount { get; set; }
        public double TransTaxAmount { get; set; }
        public double TransBaseAmount { get; set; }
        public double TransServiceFactor { get; set; }
        public double TransServiceAmount { get; set; }
        public double TransServiceTaxAmount { get; set; }
        public double TransServiceBaseAmount { get; set; }
        public double TransDiscountFactor { get; set; }
        public double TransDiscountAmount { get; set; }
        public double TransDiscountTaxAmount { get; set; }
        public double TransDiscountBaseAmount { get; set; }
        public double TransTotalAmount { get; set; }
        public double TransTotalTaxAmount { get; set; }
        public double TransTotalBaseAmount { get; set; }
        public int? TransPayPeriodId { get; set; }
        public int TransPayMethodId { get; set; }
        public double TransPayAmount { get; set; }
        public double TransPayChangeAmount { get; set; }
        public double TransPayCashAmount { get; set; }
        public double TransPayCashChangeAmount { get; set; }
        public double TransPayBankAmount { get; set; }
        public double TransPayInvoiceAmount { get; set; }
        public double TransPayOtherAmount { get; set; }
        public double StockPayPeriodOpenAmount { get; set; }
        public double StockPayPeriodInAmount { get; set; }
        public double StockPayPeriodOutAmount { get; set; }
        public double StockPayPeriodCashAmount { get; set; }
        public double StockPayPeriodDifferenceAmount { get; set; }
        public double StockPayPeriodCloseAmount { get; set; }
    }
}
