using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Financial
{
  public  class StudFeeDtlVw
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int? YearId { get; set; }
        public int? Db { get; set; }
        public int? Cr { get; set; }
        public int? Total { get; set; }
        public int? FinItemId { get; set; }
        public string FinItemName { get; set; }
    }
}
