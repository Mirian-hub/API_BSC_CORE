using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class RswaybillWorkTable
    {
        public int ShellUserId { get; set; }
        public int ShellOperationId { get; set; }
        public int ShellWorkPageId { get; set; }
        public int ShellWorkPageLineId { get; set; }
        public int? ShellWorkPageParentId { get; set; }
        public string ShellWorkPageLineParentId { get; set; }
        public double ShellWorkPageSign { get; set; }
        public int ShellWorkPageAuto { get; set; }
        public int ShellMessageId { get; set; }
        public int ShellWorkStatusId { get; set; }
        public long? RsWaybillId { get; set; }
        public string RsWaybillKey { get; set; }
        public string RswaybillName { get; set; }
        public int? RsWaybillTypeId { get; set; }
        public int? RsWaybillStatusId { get; set; }
        public string RsCompanyKey { get; set; }
        public string RsCompanyName { get; set; }
        public string RsStartAddress { get; set; }
        public string RsEndAddress { get; set; }
        public DateTime? RsCreateDate { get; set; }
        public DateTime? RsDeliveriDate { get; set; }
        public DateTime? RsActivateDate { get; set; }
        public DateTime? RsCloseDate { get; set; }
        public DateTime? RsBeginDate { get; set; }
        public int? RsConfirmationStatusId { get; set; }
        public string RsPersonKey { get; set; }
        public string RsPersonName { get; set; }
        public string RsTransportKey { get; set; }
        public long? RsWaybillLineId { get; set; }
        public int? RsWaybillLineStatusId { get; set; }
        public string RsItemKey { get; set; }
        public string RsitemName { get; set; }
        public int? RsunitId { get; set; }
        public string RsunitName { get; set; }
        public double? Rsquantity { get; set; }
        public double? Rsprice { get; set; }
        public int? RstaxId { get; set; }
        public int? RstaxId2 { get; set; }
        public double? Rsamount { get; set; }
        public int? StockEntryId { get; set; }
        public long? StockEntryLineId { get; set; }
        public int? StockSupplierId { get; set; }
        public string StockSupplierName { get; set; }
        public int? StockCustomerId { get; set; }
        public int? StockLocationId { get; set; }
        public int? StockPersonId { get; set; }
        public int? StockCarId { get; set; }
        public int? StockItemId { get; set; }
        public int? StockItemUnitId { get; set; }
        public double? StockItemUnitFactor { get; set; }
        public double? StockPrice { get; set; }
        public int? StockPriceLineTypeId { get; set; }
        public double? StockPriceTaxId { get; set; }
        public double? StockPriceTaxFactor { get; set; }
        public double? StockAmount { get; set; }
        public double? StockTaxAmount { get; set; }
        public double? StockBaseAmount { get; set; }
        public int? RscorrectionStatusId { get; set; }
        public DateTime? ShellCreated { get; set; }
        public DateTime? ShellUpdated { get; set; }
        public int? StockMarkupGroupId { get; set; }
        public int? StockMarkupId { get; set; }
        public double? TransPrice { get; set; }
        public int? TransTaxId { get; set; }
        public double? TransTaxFactor { get; set; }
        public double? TransAmount { get; set; }
        public double? TransTaxAmount { get; set; }
        public double? TransBaseAmount { get; set; }
        public string StockEntryName { get; set; }
    }
}
