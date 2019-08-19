using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.AddLookups;
using Domain.Model.Lookups;
using Domain.Model.Reg;

namespace Model.Financial
{
    public class PaymentVw
    {

        public int Id { set; get; }

        public int RegParentId { set; get; }

        //public RegParent RegParent { set; get; }

        //public string FatherName
        //{
        //    get
        //    {
        //        return RegParent != null ? RegParent.FirstName + " " + RegParent.SecondName + " " + RegParent.FamilyName : "";
        //    }
        //}




        public int? YearId { set; get; }
        public LkpYear Year { set; get; }

        public string YearDesc { get { return Year != null ? Year.AName : ""; } set { } }

        public string VoucherId { set; get; }//رقم الوصل
        public DateTime VoucherDate { set; get; }
        public int VoucherTypeId { set; get; }//سند قيد او سند دفع
        public LkpLookup VoucherType { set; get; }

        public string VoucherTypeDesc { get { return VoucherType != null ? VoucherType.AName : ""; } set { } }

        


        public string VoucherStatusId { set; get; }//ملغي أو مرحل
        public LkpLookup VoucherStatus { set; get; }
        public string VoucherStatusDesc { get { return VoucherStatus != null ? VoucherStatus.AName : ""; } set { } }



        public int? PaymentMethodId { set; get; }
        public LkpLookup PaymentMethod { set; get; }//1 cash  2 cheque 3 visa 4 transfer
        public string PaymentMethodDesc { get { return PaymentMethod != null ? PaymentMethod.AName : ""; } set { } }

        public int? Debit { set; get; }//القيمة عليه
        public int? Credit { set; get; }//القيمة له


        public string Note { set; get; }

        public string TransferNo { set; get; }

        public DateTime TransferDate { set; get; }

        public string VisaCardNo { set; get; }
    }
}
