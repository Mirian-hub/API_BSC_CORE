using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class CashLocationGroupTable
    {
        public CashLocationGroupTable()
        {
            CashLocationTable = new HashSet<CashLocationTable>();
            InverseCashLocationGroupParent = new HashSet<CashLocationGroupTable>();
        }

        public int CashLocationGroupId { get; set; }
        public string CashLocationGroupKey { get; set; }
        public string CashLocationGroupName { get; set; }
        public string CashLocationGroupNote { get; set; }
        public int? CashLocationGroupParentId { get; set; }

        public virtual CashLocationGroupTable CashLocationGroupParent { get; set; }
        public virtual ICollection<CashLocationTable> CashLocationTable { get; set; }
        public virtual ICollection<CashLocationGroupTable> InverseCashLocationGroupParent { get; set; }
    }
}
