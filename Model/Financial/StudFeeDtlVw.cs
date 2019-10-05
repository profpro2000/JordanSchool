using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Financial
{
    public class StudFeeDtlVw
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int? YearId { get; set; }
        public int? Debit { get; set; }
        public int? Credit { get; set; }
        public int? Total { get; set; }
        public int? FinItemId { get; set; }
        public string FinItemName { get; set; }

        public int? PaymentId { set; get; }
        public int? FinItemVoucherSequence { get; set; }
        public DateTime? VoucherDate { get; set; }
        public string Note {get;set;}
    }
}
