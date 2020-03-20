using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class RsmessageTable
    {
        public int RsmessageId { get; set; }
        public string RsmessageKey { get; set; }
        public string RsmessageName { get; set; }
        public string RsmessageNote { get; set; }
        public int RsmessageTypeId { get; set; }
        public int RsmessageStatusId { get; set; }
        public DateTime RsmessageValidFrom { get; set; }
        public DateTime RsmessageValidTo { get; set; }
        public int RsmessageSort { get; set; }
        public int RsmessageGroupId { get; set; }

        public virtual RsmessageGroupTable RsmessageGroup { get; set; }
        public virtual RsmessageStatusTable RsmessageStatus { get; set; }
        public virtual RsmessageTypeTable RsmessageType { get; set; }
    }
}
