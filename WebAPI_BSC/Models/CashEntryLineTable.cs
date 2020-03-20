using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class CashEntryLineTable
    {
        public long CashEntryLineId { get; set; }
        public int CashEntryLineSortId { get; set; }
        public int CashEntryId { get; set; }
        public string CashEntryLineKey { get; set; }
        public string CashEntryLineName { get; set; }
        public string CashEntryLineNote { get; set; }
        public int CashEntryLineTypeId { get; set; }
        public int CashEntryLineStatusId { get; set; }
        public int CashLocationId { get; set; }
        public int? CashLocationId2 { get; set; }
        public int CashCompanyId { get; set; }
        public int CashItemId { get; set; }
        public double CashAmount { get; set; }
        public int? CashPersonId { get; set; }
        public DateTime? CashEntryLineDate { get; set; }

        public virtual CashEntryLineStatusTable CashEntryLineStatus { get; set; }
        public virtual CashEntryLineTypeTable CashEntryLineType { get; set; }
    }
}
