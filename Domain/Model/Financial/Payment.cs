using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Domain.Model.Lookups;

namespace Domain.Model.Financial
{
   public class Payment:AuditModel
    {
        public int Id { set; get; }
        public string VoucherId { set; get; }//رقم الوصل
        public DateTime VoucherDate { set; get; }
        public int VoucherTypeId { set; get; }//سند قيد او سند دفع
        public LkpLookup VoucherType { set; get; }

        public string VoucherStatusId { set; get; }//ملغي أو مرحل
        public LkpLookup VoucherStatus { set; get; }

        public int Debit { set; get; }//القيمة عليه
        public int Credit { set; get; }//القيمة له
      
  
        public string Note { set; get; }

        [IgnoreDataMember] public ICollection<StudentFee> StudentFees { set; get; }




    }
}
