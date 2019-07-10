using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.AddLookups;
using Domain.Model.Lookups;

namespace Domain.Model.Financial
{
   public  class ClassFee:AuditModel
    {
        public int Id { set; get; }
        public int YearId { set; get; }
        public LkpLookup Year { set; get; }


        public int ClassId { set; get; }
        public LkpClass LkpClass { set; get; }

        public int SectionId { set; get; }// is it neccessary?
        public LkpSection LkpSection { set; get; }// is it neccessary?


        public int FinItemId { set; get; }
        public FinItem FinItem { set; get; }



    }
}
