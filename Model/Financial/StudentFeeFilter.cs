using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Financial
{
   public class StudentFeeFilter
    {
        public int? finItemId { set; get; }
        public int? parentId { set; get; }
        public int? FinItemVoucherSequenceFrom { set; get; }
        public int? FinItemVoucherSequenceTo { set; get; }
        public DateTime? voucherDateFrom { set; get; }
        public DateTime? voucherDateTo { set; get; }

        
    }
}
