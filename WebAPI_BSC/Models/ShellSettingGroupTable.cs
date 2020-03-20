using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellSettingGroupTable
    {
        public ShellSettingGroupTable()
        {
            InverseShellSettingGroupParent = new HashSet<ShellSettingGroupTable>();
            ShellSettingTable = new HashSet<ShellSettingTable>();
        }

        public int ShellSettingGroupId { get; set; }
        public string ShellSettingGroupKey { get; set; }
        public string ShellSettingGroupName { get; set; }
        public int ShellSettingGroupParentId { get; set; }

        public virtual ShellSettingGroupTable ShellSettingGroupParent { get; set; }
        public virtual ICollection<ShellSettingGroupTable> InverseShellSettingGroupParent { get; set; }
        public virtual ICollection<ShellSettingTable> ShellSettingTable { get; set; }
    }
}
