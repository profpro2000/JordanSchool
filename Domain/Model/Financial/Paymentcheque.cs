using Domain.Model.Lookups;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Financial
{
   public class PaymentCheque:AuditModel
    {
        public int Id { set; get; }

        public string ChequeNo { set; get; }

        public DateTime ChequeDate { set; get; }

        public int ChequeValue { set; get; }

        public int? BankId { set; get; }
        public LkpLookup Bank { set; get; }


        public int StudentFeeId { get; set; }
       public StudentFee StudentFee { get; set; }
    }
}
