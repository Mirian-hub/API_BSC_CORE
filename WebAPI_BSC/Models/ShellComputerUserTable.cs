using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellComputerUserTable
    {
        public int ShellComputerId { get; set; }
        public int ShellUserId { get; set; }
        public int ShellUserGroupId { get; set; }

        public virtual ShellComputerTable ShellComputer { get; set; }
        public virtual ShellUserTable ShellUser { get; set; }
    }
}
