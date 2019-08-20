using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Domain.Model.AddLookups;
using Domain.Model.Lookups;
using Domain.Model.Reg;

namespace Domain.Model.Financial
{
   public class Payment:AuditModel
    {
        public int Id { set; get; }
        public int RegParentId { set; get; }

        public int YearId { set; get; }
        public LkpYear Year { set; get; }
        public RegParent RegParent { set; get; }
        public string VoucherId { set; get; }//رقم الوصل
        public DateTime VoucherDate { set; get; }
        public int VoucherTypeId { set; get; }//سند قيد او سند دفع
        //public int ThisIsId { set; get; }//سند قيد او سند دفع
        public LkpLookup VoucherType { set; get; }

        public int VoucherStatusId { set; get; }//ملغي أو مرحل
        public LkpLookup VoucherStatus { set; get; }



        public int? PaymentMethodId { set; get; } 
        public LkpLookup PaymentMethod { set; get; }//1 cash  2 cheque 3 visa 4 transfer


        public int? Debit { set; get; }//القيمة عليه
        public int? Credit { set; get; }//القيمة له

        public string TransferNo { set; get; }

        public DateTime? TransferDate { set; get; }

        public string VisaCardNo { set; get; }

        public string Note { set; get; }
        public string Note2 { get; set; }

        [IgnoreDataMember] public ICollection<StudentFee> StudentFees { set; get; }
        [IgnoreDataMember] public ICollection<Paymentcheque> Paymentcheques { set; get; }

        


    }
}
