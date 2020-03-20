using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class CashLocationStatusTable
    {
        public CashLocationStatusTable()
        {
            CashLocationTable = new HashSet<CashLocationTable>();
        }

        public int CashLocationStatusId { get; set; }
        public string CashLocationStatusKey { get; set; }
        public string CashLocationStatusName { get; set; }
        public string CashLocationStatusNote { get; set; }

        public virtual ICollection<CashLocationTable> CashLocationTable { get; set; }
    }
}
