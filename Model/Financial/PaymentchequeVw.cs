using Domain.Model.Lookups;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Financial
{
   public  class PaymentChequeVw
    {

        public int Id { set; get; }

        public string ChequeNo { set; get; }

        public DateTime ChequeDate { set; get; }

        public int ChequeValue { set; get; }

        public int? BankId { set; get; }
        public LkpLookup Bank { set; get; }

        public string BankName { get { return Bank != null ? Bank.AName : ""; } set { } }
        public int PaymentId { set; get; }



    }
}
