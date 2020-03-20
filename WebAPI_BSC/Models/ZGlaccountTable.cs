using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ZGlaccountTable
    {
        public int GlaccountId { get; set; }
        public string GlaccountKey { get; set; }
        public string GlaccountName { get; set; }
        public string GlaccountNote { get; set; }
        public int GlaccountTypeId { get; set; }
        public int GlaccountStatusId { get; set; }
        public int GlaccountGroupId { get; set; }
        public string ExactGlaccount { get; set; }
    }
}
