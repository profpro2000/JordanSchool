using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Financial
{
    public class ClassFeeVw
    {

        public int Id { set; get; }
        public int YearId { set; get; }
        //public LkpLookup Year { set; get; }


        public int ClassId { set; get; }
        //public LkpClass LkpClass { set; get; }

        public int SectionId { set; get; }// is it neccessary?
       // public LkpSection LkpSection { set; get; }// is it neccessary?


        public int FinItemId { set; get; }
        //public FinItem FinItem { set; get; }
    }
}
