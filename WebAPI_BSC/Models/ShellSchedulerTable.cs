using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellSchedulerTable
    {
        public ShellSchedulerTable()
        {
            ShellSchedulerLanguageTable = new HashSet<ShellSchedulerLanguageTable>();
        }

        public int ShellSchedulerId { get; set; }
        public string ShellSchedulerKey { get; set; }
        public string ShellSchedulerName { get; set; }
        public string ShellSchedulerNote { get; set; }
        public int ShellSchedulerTypeId { get; set; }
        public int ShellSchedulerStatusId { get; set; }
        public DateTime ShellSchedulerValidFrom { get; set; }
        public DateTime ShellSchedulerValidTo { get; set; }
        public int ShellSchedulerSort { get; set; }
        public int ShellSchedulerGroupId { get; set; }
        public int ShellCollectorId { get; set; }
        public int ShellProccessorId { get; set; }
        public int ShellSynchronizerId { get; set; }
        public int? ShellMessangerId { get; set; }
        public string ShellScedulerSource { get; set; }
        public string ShellScedulerDestination { get; set; }
        public string ShellSchedulerMail { get; set; }
        public int ShellWorkingMinute { get; set; }
        public string ShellWorkingWeekDays { get; set; }
        public int ShellWorkingStartHour { get; set; }
        public int ShellWorkingEndHour { get; set; }

        public virtual ShellSchedulerGroupTable ShellSchedulerGroup { get; set; }
        public virtual ShellSchedulerStatusTable ShellSchedulerStatus { get; set; }
        public virtual ShellSchedulerTypeTable ShellSchedulerType { get; set; }
        public virtual ICollection<ShellSchedulerLanguageTable> ShellSchedulerLanguageTable { get; set; }
    }
}
