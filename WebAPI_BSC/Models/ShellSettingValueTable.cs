using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellSettingValueTable
    {
        public int ShellSettingValueId { get; set; }
        public int ShellUserId { get; set; }
        public int ShellSettingId { get; set; }
        public string ShellSettingValue { get; set; }

        public virtual ShellSettingTable ShellSetting { get; set; }
        public virtual ShellUserTable ShellUser { get; set; }
    }
}
