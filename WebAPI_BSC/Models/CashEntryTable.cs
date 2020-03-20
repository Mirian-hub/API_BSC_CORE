using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class CashEntryTable
    {
        public int CashEntryId { get; set; }
        public int? CashEntrySortId { get; set; }
        public string CashEntryKey { get; set; }
        public string CashEntryName { get; set; }
        public DateTime CashEntryDate { get; set; }
        public string CashEntryNote { get; set; }
        public int CashEntryTypeId { get; set; }
        public int CashEntryStatusId { get; set; }
        public int CashLocationId { get; set; }
        public int ShellUserId { get; set; }
        public int CashEntryProcessId { get; set; }
        public int? ShellAcceptorUserId { get; set; }
        public DateTime ShellCreationDate { get; set; }
        public int ShellCreatorUserId { get; set; }
        public DateTime ShellModificationDate { get; set; }
        public int ShellModifierUserId { get; set; }
        public int? ShellRejectorUserId { get; set; }
        public int? ShellRejectorUserId1 { get; set; }
        public int? ShellRejectorUserId2 { get; set; }
        public int? ShellRejectorUserId3 { get; set; }
        public int? ShellRejectorUserId4 { get; set; }
        public int? ShellRejectorUserId5 { get; set; }
        public int? ShellRejectorUserId6 { get; set; }
        public int? ShellRejectorUserId7 { get; set; }
        public int? ShellRejectorUserId8 { get; set; }

        public virtual CashEntryStatusTable CashEntryStatus { get; set; }
        public virtual CashEntryTypeTable CashEntryType { get; set; }
    }
}
