using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellMessageTable
    {
        public int ShellMessageId { get; set; }
        public string ShellMessageKey { get; set; }
        public string ShellMessageName { get; set; }
        public int ShellMessageTypeId { get; set; }
        public int ShellMessageStatusId { get; set; }
        public int ShellMessageGroupId { get; set; }
        public int ShellMessageSortId { get; set; }

        public virtual ShellMessageGroupTable ShellMessageGroup { get; set; }
        public virtual ShellMessageStatusTable ShellMessageStatus { get; set; }
        public virtual ShellMessageTypeTable ShellMessageType { get; set; }
    }
}
