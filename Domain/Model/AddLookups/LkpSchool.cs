using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using Domain.Model.Lookups;
using Domain.Model.Reg;

namespace Domain.Model.AddLookups
{
  public  class LkpSchool:AuditModel
    {
        public int Id { get; set; }
        public string Aname { get; set; }
        public string Lname { get; set; }
        public int CityId { get; set; }
        [IgnoreDataMember] public LkpLookup CitesLookup { get; set; }
        public string Address { get; set; }
        public  string Tel { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string WebPage { get; set; }
        public string FaceBook { get; set; }
        public ICollection<LkpSection> LkpSections { get; set; }

        [IgnoreDataMember] public ICollection<LkpTour> LkpTours { get; set; }
        [IgnoreDataMember] public ICollection<LkpBus> LkpBusses { get; set; }
        [IgnoreDataMember] public ICollection<LkpClass> LkpClasses { get; set; }

        [IgnoreDataMember] public ICollection<RegStud> SchoolRegStuds { get; set; }

    }
}
