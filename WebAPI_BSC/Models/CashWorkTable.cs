using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class CashWorkTable
    {
        public long ShellWorkId { get; set; }
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
        public int? CashEntrySortId { get; set; }
        public int? CashEntryId { get; set; }
        public long? CashEntryLineId { get; set; }
        public string CashEntryKey { get; set; }
        public string CashEntryName { get; set; }
        public DateTime? CashEntryDate { get; set; }
        public int? CashEntryTypeId { get; set; }
        public int? CashEntryStatusId { get; set; }
        public double CashEntrySign { get; set; }
        public int? CashEntryParentId { get; set; }
        public long? CashEntryLineParentId { get; set; }
        public int? CashLocationId { get; set; }
        public int? CashLocationId2 { get; set; }
        public int? CashCompanyId { get; set; }
        public int CashItemId { get; set; }
        public double CashAmount { get; set; }
        public DateTime? ShellCreationDate { get; set; }
        public DateTime? ShellModificationDate { get; set; }
        public int? ShellCreatorUserId { get; set; }
        public int? ShellModifierUserId { get; set; }
        public int? ShellAcceptorUserId { get; set; }
        public int? ShellRejectorUserId { get; set; }
        public int? ShellRejectorUserId1 { get; set; }
        public int? ShellRejectorUserId2 { get; set; }
        public int? ShellRejectorUserId3 { get; set; }
        public int? ShellRejectorUserId4 { get; set; }
        public int? ShellRejectorUserId5 { get; set; }
        public int? ShellRejectorUserId6 { get; set; }
        public int? ShellRejectorUserId7 { get; set; }
        public int? ShellRejectorUserId8 { get; set; }
        public int? CashPersonId { get; set; }
    }
}
