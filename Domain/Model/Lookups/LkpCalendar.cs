using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Lookups
{
  public  class LkpCalendar:AuditModel
    {
        public  int Id { get; set; }
        public int YearId { get; set; }
        public int SectionId { get; set; }

        public  int ItemId { get; set; }         
        public LkpItemCalendar LkpItemCalendar { get; set; }

        public  DateTime FromDate { get; set; }
        public  DateTime ToDate { get; set; }
        public  string Note { get; set; }
       
// my comment
//my local comment

    }
}
