using Domain.Model.Lookups;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Financial
{
   public  class PaymentChequeVw
    {

        public int Id { set; get; }

        public string chequeNo { set; get; }

        public DateTime chequeDate { set; get; }

        public int chequeValue { set; get; }

        public int? BankId { set; get; }
        public LkpLookup Bank { set; get; }

        public string BankName { get { return Bank != null ? Bank.AName : ""; } set { } }

 

    }
}
