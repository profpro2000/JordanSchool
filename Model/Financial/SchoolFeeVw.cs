using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.AddLookups;
using Domain.Model.Financial;
using Domain.Model.Lookups;

namespace Model.Financial
{
   public  class SchoolFeeVw
    {

        public int Id { set; get; }

        //School data
        public int SchoolId { set; get; }
        public LkpSchool school { set; get; }
        public string SchoolDesc { get { return school != null ? school.Aname : ""; } set { } }

       
        //year Data
        public int YearId { set; get; }
        public LkpYear Year { set; get; }
        public string YearDesc { get { return Year != null ? Year.AName : ""; } set { } }



        //Fin Item Data
        public int FinItemId { set; get; }
         public FinItem FinItem { set; get; }
        public string FinItemDesc { get { return FinItem != null ? FinItem.ArDesc : ""; } set { } }



        public int Value { set; get; }

    }
}
