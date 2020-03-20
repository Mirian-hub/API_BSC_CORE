using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class RsWaybillTable
    {
        public long RswaybillId { get; set; }
        public string RswaybillKey { get; set; }
        public string RswaybillName { get; set; }
        public int? RsWaybillTypeId { get; set; }
        public int? RsWaybillStatusId { get; set; }
        public string RsMyCompanyKey { get; set; }
        public string RsMyCompanyName { get; set; }
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
        public double? Rsamount { get; set; }
        public int? StockSupplierId { get; set; }
        public int? StockCustomerId { get; set; }
        public int? StockLocationId { get; set; }
        public int? StockPersonId { get; set; }
        public int? StockCarId { get; set; }
        public int? StockEntryId { get; set; }
        public int? ShellMessageId { get; set; }
        public int ShellProcessId { get; set; }
        public double? StockAmount { get; set; }
        public double? StockTaxAmount { get; set; }
        public double? StockBaseAmount { get; set; }
        public int RscorrectionStatusId { get; set; }
        public DateTime ShellCreated { get; set; }
        public DateTime ShellUpdated { get; set; }
        public double? TransAmount { get; set; }
        public double? TransTaxAmount { get; set; }
        public double? TransBaseAmount { get; set; }
        public string StockEntryName { get; set; }
    }
}
