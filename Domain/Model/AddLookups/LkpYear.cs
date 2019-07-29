using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Domain.Model.Financial;

namespace Domain.Model.AddLookups
{
  public  class LkpYear
    {
        public int Id { get; set; }
        public string AName { get; set; }
        public string LName { get; set; }
        public int? Active { get; set; }

        [IgnoreDataMember] public ICollection<LkpClass> Classes { get; set; }
       [IgnoreDataMember] public ICollection<SchoolFee> SchoolFees { set; get; }
       [IgnoreDataMember] public ICollection<Payment> Payments { set; get; }


    }
}
