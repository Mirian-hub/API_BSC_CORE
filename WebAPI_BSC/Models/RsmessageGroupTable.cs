using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class RsmessageGroupTable
    {
        public RsmessageGroupTable()
        {
            InverseRsmessageGroupParent = new HashSet<RsmessageGroupTable>();
            RsmessageTable = new HashSet<RsmessageTable>();
        }

        public int RsmessageGroupId { get; set; }
        public string RsmessageGroupKey { get; set; }
        public string RsmessageGroupName { get; set; }
        public string RsmessageGroupNote { get; set; }
        public int RsmessageGroupSort { get; set; }
        public int RsmessageGroupParentId { get; set; }

        public virtual RsmessageGroupTable RsmessageGroupParent { get; set; }
        public virtual ICollection<RsmessageGroupTable> InverseRsmessageGroupParent { get; set; }
        public virtual ICollection<RsmessageTable> RsmessageTable { get; set; }
    }
}
