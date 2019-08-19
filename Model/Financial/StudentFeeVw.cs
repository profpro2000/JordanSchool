using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Financial
{
   public class StudentFeeVw
    {

        public int Id { set; get; }
        public int StudentId { set; get; }
      //  public RegStud Student { set; get; }
        public int YearId { set; get; }
      //  public LkpLookup Year { set; get; }
        public int FinItemId { set; get; }
       // public FinItem FinItem { set; get; }
        public int Value { set; get; }
        public int? FinItemOrder { get; set; }


    }
}
