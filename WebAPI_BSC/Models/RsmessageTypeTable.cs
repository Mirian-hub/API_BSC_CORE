using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class RsmessageTypeTable
    {
        public RsmessageTypeTable()
        {
            RsmessageTable = new HashSet<RsmessageTable>();
        }

        public int RsmessageTypeId { get; set; }
        public string RsmessageTypeKey { get; set; }
        public string RsmessageTypeName { get; set; }
        public string RsmessageTypeNote { get; set; }

        public virtual ICollection<RsmessageTable> RsmessageTable { get; set; }
    }
}
