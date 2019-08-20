using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.Lookups;

namespace Model.Financial
{
  public  class FinItemVw
    {
        public int Id { set; get; }
        public string ArDesc { set; get; }
        public string LaDesc { set; get; }
        public int cdTypeId { set; get; }// debit or redit اضافة او خصم
        public LkpLookup cdTypeLookup { get; set; }
        public string cdTypeDesc { get { return cdTypeLookup != null ? cdTypeLookup.AName : ""; } set { } }

        public int vpTypeId { set; get; }//  percentage or value

        public LkpLookup vpTypeLookup { get; set; }
        public string vpTypeDesc { get { return vpTypeLookup != null ? vpTypeLookup.AName : ""; } set { } }

        public int? FinItemOrder { get; set; }

    }
}
