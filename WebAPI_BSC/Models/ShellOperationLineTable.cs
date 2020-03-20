using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellOperationLineTable
    {
        public int ShellOperationId { get; set; }
        public int ShellOperationLineId { get; set; }
        public int ShellEntryLineTypeId { get; set; }
        public int ShellEntryLineStatusId { get; set; }
        public double ShellEntryLineSign { get; set; }
        public int ShellEntryLineAuto { get; set; }

        public virtual ShellOperationTable ShellOperation { get; set; }
    }
}
