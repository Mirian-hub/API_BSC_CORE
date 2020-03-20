using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellSettingTypeTable
    {
        public ShellSettingTypeTable()
        {
            ShellSettingTable = new HashSet<ShellSettingTable>();
        }

        public int ShellSettingTypeId { get; set; }
        public string ShellSettingTypeKey { get; set; }
        public string ShellSettingTypeName { get; set; }

        public virtual ICollection<ShellSettingTable> ShellSettingTable { get; set; }
    }
}
