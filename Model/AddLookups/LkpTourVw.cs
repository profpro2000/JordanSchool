using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Domain.Model.AddLookups;
using Domain.Model.Lookups;

namespace Model.AddLookups
{
  public  class LkpTourVw
    {
        public int Id { get; set; }
        public string TourName { get { return Tour != null? Tour.AName:""; } set { } }
        public int TourFullPrice { get; set; }
        public int TourHalfPrice { get; set; }
        public int SchoolId { get; set; }
        public LkpSchool LkpSchool { get; set; }
        public int? TourNameId { get; set; }
        [IgnoreDataMember] public LkpLookup Tour { get; set; }
    }
}
