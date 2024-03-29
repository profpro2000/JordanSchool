﻿using Domain.Model.Financial;
using Domain.Model.Lookups;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Financial
{
   public class StudentFeeVw
    {

        public int Id { set; get; }
        public int StudentId { set; get; }
        public int YearId { set; get; }
        public int FinItemId { set; get; }
        public FinItem FinItem { set; get; }

        public string FinItemDesc  { get { return FinItem != null ? FinItem.ArDesc : ""; } set { } }

        public int? Debit { set; get; }
        public int? Credit { set; get; }

        public int? FinItemVoucherSequence { get; set; }
        
        public DateTime VoucherDate { set; get; }


        public int? PaymentMethodId { set; get; }
        public LkpLookup PaymentMethod { set; get; }//1 cash  2 cheque 3 visa 4 transfer

        public string PaymentMethodDesc { get { return PaymentMethod != null ? PaymentMethod.AName : "";  } set { } }

        public string TransferNo { set; get; }

        public DateTime? TransferDate { set; get; }

        public string VisaCardNo { set; get; }




    }
}
