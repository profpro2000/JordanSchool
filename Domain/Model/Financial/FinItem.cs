using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Domain.Model.Lookups;

namespace Domain.Model.Financial
{
    public class FinItem:AuditModel
    {
        public int Id { set; get; }
        public string ArDesc { set; get; }
        public string LaDesc { set; get; }
        public int cdTypeId { set; get; }// debit or redit اضافة او خصم
        public LkpLookup cdTypeLookup { set; get; }

        public int vpTypeId { set; get; }//  percentage or value
        public LkpLookup vpTypeLookup { set; get; }
        public int? FinItemOrder { set; get; }
        public int? FinItemVoucherMaxSequence { get; set; }

        

        [IgnoreDataMember] public ICollection<SchoolFee> SchoolFees { get; set; }
        [IgnoreDataMember] public ICollection<ClassFee> ClassFees { get; set; }
        [IgnoreDataMember] public ICollection<StudentFee> StudentFees { get; set; }


    }
}
