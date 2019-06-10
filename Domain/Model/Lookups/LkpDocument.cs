using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Lookups
{
   public  class LkpDocument:AuditModel
    {
        public int Id { set; get; }
        public int DocumentId { set; get; }

        public LkpLookup DocumentLookup { set; get; }

        public int SectionId { set; get; }
        public LkpLookup SectionLookup { set; get; }

        public int MandotoryId { set; get; }
       public LkpLookup MandatoryLookup { set; get; }

        public int ActiveId { set; get; }
        public LkpLookup ActiveLookup { set; get; }



    }
}
