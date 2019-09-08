using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.AddLookups;
using Domain.Model.Lookups;

namespace Domain.Model.Financial
{
    //school financial settings
    public class SchoolFee : AuditModel
    {
        public int Id { set; get; }
        public int SchoolId { set; get; }

        public LkpSchool school { set; get; }

        public int YearId { set; get; }
       public LkpYear Year { set; get; }

        public int FinItemId { set; get; }
        public FinItem FinItem { set; get; }

        public int Value { set; get; }



    }
}
