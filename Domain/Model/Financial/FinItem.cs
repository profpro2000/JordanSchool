using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Model.Financial
{
    public class FinItem:AuditModel
    {
        public int Id { set; get; }
        public string ArDesc { set; get; }
        public string LaDesc { set; get; }
        public string CDType { set; get; }// debit or redit اضافة او خصم
        public string VPType { set; get; }//  percentage or value

        [IgnoreDataMember] public ICollection<SchoolFee> SchoolFees { get; set; }
        [IgnoreDataMember] public ICollection<ClassFee> ClassFees { get; set; }
        [IgnoreDataMember] public ICollection<StudentFee> StudentFees { get; set; }


    }
}
