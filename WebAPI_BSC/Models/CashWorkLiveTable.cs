using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class CashWorkLiveTable
    {
        public int ShellUserId { get; set; }
        public int ShellOperationId { get; set; }
        public int ShellWorkPageId { get; set; }
        public int ShellWorkPageLineId { get; set; }
        public int ShellMessageId { get; set; }
        public DateTime? ShellDateFrom { get; set; }
        public DateTime? ShellDateTo { get; set; }
        public int? CashLocationId { get; set; }
        public int? CashLocationGroupId { get; set; }
        public int? CashItemGroupId { get; set; }
        public int? CashCompanyId { get; set; }
        public int? CashCompanyGroupId { get; set; }
        public int? CashItemId { get; set; }
        public double? CashAmount { get; set; }
        public DateTime? CashEntryDate { get; set; }
        public int? CashEntryId { get; set; }
        public int? CashEntryLineSortId { get; set; }
        public int? CashEntryTypeId { get; set; }
        public string CashEntryKey { get; set; }
        public string CashEntryName { get; set; }
        public long? CashEntryLineId { get; set; }
        public int? CashEntryLineTypeId { get; set; }
        public int? ShellYesNo { get; set; }
        public int? ShellYesNo1 { get; set; }
        public int? ShellYesNo2 { get; set; }
        public int? ShellYesNo3 { get; set; }
        public int? ShellYesNo4 { get; set; }
        public int? ShellYesNo5 { get; set; }
        public int? ShellWorkPageParentId { get; set; }
        public int? ShellWorkPageLineParentId { get; set; }
        public int? CashEntryStatusId { get; set; }
        public double? CashAmount2 { get; set; }
        public double? CashAmount3 { get; set; }
        public double? CashAmount4 { get; set; }
        public int? CashUserId { get; set; }
        public int? CashPersonId { get; set; }
        public int? StockEntryTypeId2 { get; set; }
        public DateTime? StockEntryDate { get; set; }
    }
}
