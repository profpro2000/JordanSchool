using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.Lookups;

namespace Model.Financial
{
 public   class PaymentVw
    {

        public int Id { set; get; }
        public string VoucherId { set; get; }//رقم الوصل
        public DateTime VoucherDate { set; get; }
        public int VoucherTypeId { set; get; }//سند قيد او سند دفع
        public LkpLookup VoucherType { set; get; }

        public string VoucherTypeDesc{ get { return VoucherType != null ? VoucherType.AName : ""; } set { } }
       

        public string VoucherStatusId { set; get; }//ملغي أو مرحل
        public LkpLookup VoucherStatus { set; get; }
        public string VoucherStatusDesc { get { return VoucherStatus != null ? VoucherStatus.AName : ""; } set { } }

        public int Debit { set; get; }//القيمة عليه
        public int Credit { set; get; }//القيمة له


        public string Note { set; get; }
    }
}
