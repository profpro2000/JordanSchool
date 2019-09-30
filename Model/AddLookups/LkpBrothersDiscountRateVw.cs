using System;
using System.Collections.Generic;
using System.Text;

namespace Model.AddLookups
{
   public class LkpBrothersDiscountRateVw
    {
        public int Id { get; set; }
        public int? Value { get; set; }
        public string DiscountType { get; set; }
        public int? BrotherSeq { get; set; }
    }
}
