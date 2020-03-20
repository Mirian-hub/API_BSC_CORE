using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellLogTable
    {
        public long ShellLogId { get; set; }
        public string ShellLogKey { get; set; }
        public string ShellLogName { get; set; }
        public int ShellLogSortId { get; set; }
        public DateTime ShellLogDate { get; set; }
        public TimeSpan ShellLogTime { get; set; }
        public string ShellLogValue { get; set; }
        public string ShellLogXml { get; set; }
    }
}
