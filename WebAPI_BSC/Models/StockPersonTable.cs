using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockPersonTable
    {
        public StockPersonTable()
        {
            StockEntryTable = new HashSet<StockEntryTable>();
        }

        public int StockPersonId { get; set; }
        public string StockPersonKey { get; set; }
        public string StockPersonName { get; set; }
        public string StockPersonNote { get; set; }
        public int StockPersonTypeId { get; set; }
        public int StockPersonStatusId { get; set; }
        public int StockPersonGroupId { get; set; }
        public string StockPersonAddress { get; set; }
        public string StockPersonAddress2 { get; set; }
        public string StockPersonMobile { get; set; }
        public string StockPersonPhone { get; set; }
        public string StockPersonMail { get; set; }
        public string StockPersonBirthAddress { get; set; }
        public string StockPersonGender { get; set; }
        public string StockPersonMaritalStatus { get; set; }
        public string StockPersonPersonalNumber { get; set; }
        public string StockPersonDriverLicense { get; set; }
        public DateTime? StockPersonValidFrom { get; set; }
        public DateTime? StockPersonValidTo { get; set; }
        public DateTime? StockPersonBirthDate { get; set; }

        public virtual StockPersonGroupTable StockPersonGroup { get; set; }
        public virtual StockPersonStatusTable StockPersonStatus { get; set; }
        public virtual StockPersonTypeTable StockPersonType { get; set; }
        public virtual ICollection<StockEntryTable> StockEntryTable { get; set; }
    }
}
