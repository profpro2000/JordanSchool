using Domain.Model.Lookups;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Financial
{
   public class Paymentcheque:AuditModel
    {
        public int Id { set; get; }

        public string chequeNo { set; get; }

        public DateTime chequeDate { set; get; }

        public int chequeValue { set; get; }

        public int? BankId { set; get; }
        public LkpLookup Bank { set; get; }

        public int PaymentId { set; get; }
        public Payment Payment { set; get; }
    }
}
