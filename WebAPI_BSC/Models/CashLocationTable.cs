using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class CashLocationTable
    {
        public int CashLocationId { get; set; }
        public string CashLocationKey { get; set; }
        public string CashLocationName { get; set; }
        public string CashLocationNote { get; set; }
        public int CashLocationTypeId { get; set; }
        public int CashLocationStatusId { get; set; }
        public int CashLocationGroupId { get; set; }

        public virtual CashLocationGroupTable CashLocationGroup { get; set; }
        public virtual CashLocationStatusTable CashLocationStatus { get; set; }
        public virtual CashLocationTypeTable CashLocationType { get; set; }
    }
}
