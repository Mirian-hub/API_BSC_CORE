using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class CashLocationTypeTable
    {
        public CashLocationTypeTable()
        {
            CashLocationTable = new HashSet<CashLocationTable>();
        }

        public int CashLocationTypeId { get; set; }
        public string CashLocationTypeKey { get; set; }
        public string CashLocationTypeName { get; set; }
        public string CashLocationTypeNote { get; set; }

        public virtual ICollection<CashLocationTable> CashLocationTable { get; set; }
    }
}
