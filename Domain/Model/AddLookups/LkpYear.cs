using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Model.AddLookups
{
  public  class LkpYear
    {
        public int Id { get; set; }
        public string AName { get; set; }
        public string LName { get; set; }
        public int? Active { get; set; }

        [IgnoreDataMember] public ICollection<LkpClass> Classes { get; set; }
    }
}
