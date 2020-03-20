using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellSettingStatusTable
    {
        public ShellSettingStatusTable()
        {
            ShellSettingTable = new HashSet<ShellSettingTable>();
        }

        public int ShellSettingStatusId { get; set; }
        public string ShellSettingStatusKey { get; set; }
        public string ShellSettingStatusName { get; set; }

        public virtual ICollection<ShellSettingTable> ShellSettingTable { get; set; }
    }
}
