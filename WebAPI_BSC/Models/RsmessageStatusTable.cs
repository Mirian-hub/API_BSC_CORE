using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class RsmessageStatusTable
    {
        public RsmessageStatusTable()
        {
            RsmessageTable = new HashSet<RsmessageTable>();
        }

        public int RsmessageStatusId { get; set; }
        public string RsmessageStatusKey { get; set; }
        public string RsmessageStatusName { get; set; }
        public string RsmessageStatusNote { get; set; }

        public virtual ICollection<RsmessageTable> RsmessageTable { get; set; }
    }
}
