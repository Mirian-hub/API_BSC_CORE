using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellSettingTable
    {
        public ShellSettingTable()
        {
            ShellSettingValueTable = new HashSet<ShellSettingValueTable>();
        }

        public int ShellSettingId { get; set; }
        public string ShellSettingKey { get; set; }
        public string ShellSettingName { get; set; }
        public int ShellSettingTypeId { get; set; }
        public int ShellSettingStatusId { get; set; }
        public int ShellSettingGroupId { get; set; }
        public int ShellSettingSortId { get; set; }
        public string ShellSettingValue { get; set; }

        public virtual ShellSettingGroupTable ShellSettingGroup { get; set; }
        public virtual ShellSettingStatusTable ShellSettingStatus { get; set; }
        public virtual ShellSettingTypeTable ShellSettingType { get; set; }
        public virtual ICollection<ShellSettingValueTable> ShellSettingValueTable { get; set; }
    }
}
