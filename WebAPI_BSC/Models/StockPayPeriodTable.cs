using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockPayPeriodTable
    {
        public int ShellComputerId { get; set; }
        public int StockPayPeriodId { get; set; }
        public string StockPayPeriodKey { get; set; }
        public string StockPayPeriodName { get; set; }
        public DateTime? StockPayPeriodValidFrom { get; set; }
        public DateTime? StockPayPeriodValidTo { get; set; }
        public int StockPayPeriodStatusId { get; set; }
        public DateTime? ShellSyncDate { get; set; }
        public int ShellUserId { get; set; }
        public int? StockLocationId { get; set; }
        public int? StockCustomerId { get; set; }
        public double StockPayPeriodOpenAmount { get; set; }
        public double StockPayPeriodInAmount { get; set; }
        public double StockPayPeriodOutAmount { get; set; }
        public double StockPayPeriodCashAmount { get; set; }
        public double StockPayPeriodDifferenceAmount { get; set; }
        public double StockPayPeriodCloseAmount { get; set; }
        public double TransPayCashAmount { get; set; }
        public double TransPayCashChangeAmount { get; set; }
        public double TransPayBankAmount { get; set; }
        public double TransPayInvoiceAmount { get; set; }
        public double TransPayOtherAmount { get; set; }
    }
}
