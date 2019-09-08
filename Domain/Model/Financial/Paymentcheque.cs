using Domain.Model.Lookups;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Model.Financial
{
   public class PaymentCheque:AuditModel
    {
        public int Id { set; get; }

        public int PaymentId { get; set; }
        public StudentFee StudentFees { get; set; }

        public string ChequeNo { set; get; }

        public DateTime ChequeDate { set; get; }

        public int ChequeValue { set; get; }
        public string ChequeWoner { get; set; }

        public int? BankId { set; get; }
        [IgnoreDataMember] public LkpLookup Bank { set; get; }

    }
}
