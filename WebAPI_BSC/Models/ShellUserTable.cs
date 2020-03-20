using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellUserTable
    {
        public ShellUserTable()
        {
            ShellComputerUserTable = new HashSet<ShellComputerUserTable>();
            ShellReportFilterValueTable = new HashSet<ShellReportFilterValueTable>();
            ShellSettingValueTable = new HashSet<ShellSettingValueTable>();
            StockEntryTable = new HashSet<StockEntryTable>();
        }

        public int ShellUserId { get; set; }
        public string ShellUserKey { get; set; }
        public string ShellUserName { get; set; }
        public int ShellUserTypeId { get; set; }
        public int ShellUserStatusId { get; set; }
        public DateTime ShellUserValidFrom { get; set; }
        public DateTime ShellUserValidTo { get; set; }
        public int ShellUserGroupId { get; set; }
        public int ShellUserSortId { get; set; }
        public int ShellLanguageId { get; set; }
        public string ShellUserPassword { get; set; }
        public string ShellUserCard { get; set; }
        public string ShellNtuserName { get; set; }
        public string ShellNtcomputerName { get; set; }
        public string ShellLogOnTime { get; set; }
        public string ShellLogOffTime { get; set; }

        public virtual ShellLanguageTable ShellLanguage { get; set; }
        public virtual ShellUserGroupTable ShellUserGroup { get; set; }
        public virtual ShellUserStatusTable ShellUserStatus { get; set; }
        public virtual ShellUserTypeTable ShellUserType { get; set; }
        public virtual ICollection<ShellComputerUserTable> ShellComputerUserTable { get; set; }
        public virtual ICollection<ShellReportFilterValueTable> ShellReportFilterValueTable { get; set; }
        public virtual ICollection<ShellSettingValueTable> ShellSettingValueTable { get; set; }
        public virtual ICollection<StockEntryTable> StockEntryTable { get; set; }
    }
}
