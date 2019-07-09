using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Financial
{
   public  class ClassFee:AuditModel
    {
        public int Id { set; get; }
        public int YearId { set; get; }

        public int ClassId { set; get; }

        public int SectionId { set; get; }// is it neccessary?


        public int FinItemId { set; get; }



    }
}
