using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class CashLocationGlaccountTable
    {
        public int CashLocationId { get; set; }
        public int CashJournalId { get; set; }
        public int CashGlaccountId { get; set; }
    }
}
