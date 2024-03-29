﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Domain.Model.AddLookups;
using Domain.Model.Adm;
using Domain.Model.Lookups;
using Domain.Model.Reg;

namespace Domain.Model.Financial
{
    public class StudentFee : AuditModel
    {
        public int Id { set; get; }
        public int StudentId { set; get; }
        public AdmStud Student { set; get; }
        public int? YearId { set; get; }
        public LkpLookup Year { set; get; }
        public int? FinItemId { set; get; }
        public FinItem FinItem { set; get; }
        public int? Debit { set; get; }
        public int? Credit { set; get; }
       // public int? PaymentId { set; get; }
       // public Payment Payment { set; get; }

        public int? FinItemVoucherSequence { set; get; }//متسلسل الوصل
        public DateTime VoucherDate { set; get; }
        public int VoucherTypeId { set; get; }//سند قيد او سند دفع
        //public int ThisIsId { set; get; }//سند قيد او سند دفع
        public LkpLookup VoucherType { set; get; }

        public int VoucherStatusId { set; get; }//ملغي أو مرحل
        public LkpLookup VoucherStatus { set; get; }



        public int? PaymentMethodId { set; get; }
        public LkpLookup PaymentMethod { set; get; }//1 cash  2 cheque 3 visa 4 transfer



        public string TransferNo { set; get; }

        public DateTime? TransferDate { set; get; }

        public string VisaCardNo { set; get; }
 
        [IgnoreDataMember] public ICollection<PaymentCheque> Paymentcheques { set; get; }


    }
}
