using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.AddLookups;
using Domain.Model.Lookups;

namespace Domain.Model.Fin
{
 public    class FinItem:AuditModel
    {
        //الحركات المالية
        public int Id { set; get; }
        public int SchoolId { set; get; }
        public LkpSchool LkpSchool { set; get; }



        public int SectionId { set; get; }
        public LkpSection LkpSectoin { set; get; }

        //طبيعة الحركة
        public int TypeId { set; get; } 
        public LkpLookup FinItemTypeLookup { set; get; }

        public int Value { set; get; }


        //يمكن التعديل عليها
        public int IsUpdatable { set; get; }


        //تظهر لمن
        public int VisibleToId { set; get; }
        public LkpLookup VisibleToLookup { set; get; }


    }
}
