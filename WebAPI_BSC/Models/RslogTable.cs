using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class RslogTable
    {
        public long RslogId { get; set; }
        public DateTime RslogDate { get; set; }
        public string RslogKey { get; set; }
        public string RslogName { get; set; }
        public int SyncProcessId { get; set; }
    }
}
