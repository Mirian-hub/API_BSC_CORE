using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ZPosworkTable
    {
        public int ShellUserId { get; set; }
        public int ShellOperationId { get; set; }
        public int ShellWorkPageId { get; set; }
        public int ShellWorkPageLineId { get; set; }
        public int? ShellWorkPageParentId { get; set; }
        public int? ShellWorkPageLineParentId { get; set; }
        public double ShellWorkPageSign { get; set; }
        public int ShellWorkPageAuto { get; set; }
        public int ShellMessageId { get; set; }
        public int ShellWorkStatusId { get; set; }
        public int? StockEntryId { get; set; }
        public long? StockEntryLineId { get; set; }
        public string StockEntryKey { get; set; }
        public string StockEntryName { get; set; }
        public DateTime? StockEntryDate { get; set; }
        public DateTime? StockEntryDateInitial { get; set; }
        public int? StockEntryTypeId { get; set; }
        public int? StockEntryStatusId { get; set; }
        public int? StockEntryParentId { get; set; }
        public long? StockEntryLineParentId { get; set; }
        public int? TransCompanyId { get; set; }
        public int TransCurrencyId { get; set; }
        public double TransCurrencyFactor { get; set; }
        public int TransTaxMethodId { get; set; }
        public double TransTaxMethodFactor { get; set; }
        public int? TransItemId { get; set; }
        public int? TransItemUnitId { get; set; }
        public double TransItemUnitFactor { get; set; }
        public double TransQuantity { get; set; }
        public double TransPrice { get; set; }
        public double TransPriceOverall { get; set; }
        public double TransPriceAmount { get; set; }
        public int TransTaxId { get; set; }
        public double TransTaxBaseFactor { get; set; }
        public double TransTaxFactor { get; set; }
        public double TransTaxBaseAmount { get; set; }
        public double TransTaxAmount { get; set; }
        public double TransTotalAmount { get; set; }
        public int TransPayMethodId { get; set; }
        public int TransPayDiscountId { get; set; }
        public double TransPayDiscountRate { get; set; }
        public double TransPayDiscountAmount { get; set; }
        public double TransToPayAmount { get; set; }
        public double TransPaidTotalAmount { get; set; }
        public int? StockLocationId { get; set; }
        public int? StockItemId { get; set; }
        public int? StockItemUnitId { get; set; }
        public double StockQuantity { get; set; }
        public double StockAmount { get; set; }
        public double StockTaxBaseAmount { get; set; }
        public double StockTaxAmount { get; set; }
        public double StockTotalAmount { get; set; }
        public double StockPayDiscountAmount { get; set; }
        public double StockToPayAmount { get; set; }
        public double StockPaidTotalAmount { get; set; }
        public DateTime? ShellCreationDate { get; set; }
        public DateTime? ShellModificationDate { get; set; }
        public int? ShellCreatorUserId { get; set; }
        public int? ShellModifierUserId { get; set; }
        public double StockRestQuantity { get; set; }
        public double StockRestAmount { get; set; }
        public double StockRestPrice { get; set; }
        public double StockRestQuantity2 { get; set; }
        public double StockRestQuantity3 { get; set; }
        public double TransQuantityInitial { get; set; }
        public int? ShellComputerId { get; set; }
        public double TransCommissionAmount { get; set; }
        public string Comment { get; set; }
        public bool ShellFlag1 { get; set; }
        public bool ShellFlag2 { get; set; }
        public bool ShellFlag3 { get; set; }
        public bool ShellFlag4 { get; set; }
        public int TransPayPeriodId { get; set; }
        public double TransBaseAmount { get; set; }
        public double TransAmount { get; set; }
        public double TransDiscountAmount { get; set; }
        public double TransDiscountTaxAmount { get; set; }
        public double TransFiscalAmount { get; set; }
        public double TransPayAmount { get; set; }
        public double TransPayChangeAmount { get; set; }
        public double TransPayCashAmount { get; set; }
        public double TransPayBankAmount { get; set; }
        public double TransPayInvoiceAmount { get; set; }
        public double TransPayOtherAmount { get; set; }
    }
}
