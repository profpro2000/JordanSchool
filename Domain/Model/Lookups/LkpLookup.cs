using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Domain.Model.AddLookups;
using Domain.Model.Reg;

namespace Domain.Model.Lookups
{
   public class LkpLookup:AuditModel
    {
        public  int Id { get; set; }
        public string AName { get; set; }
        public string LName { get; set; }
        public string Value { get; set; }
        public int ParentId { get; set; }
        public int TypeId { get; set; }
        public LkpLookupType LkpLookupType { get; set; }

        [IgnoreDataMember] public  ICollection<LkpSchool> LkpSchool { get; set; }
        [IgnoreDataMember] public ICollection<LkpClass> LkpClasses { get; set; }

        [IgnoreDataMember] public ICollection<RegParent> ReligionParents { get; set; }
        [IgnoreDataMember] public ICollection<RegParent> NationalityParents { get; set; }
        [IgnoreDataMember] public ICollection<RegParent> CityParents { get; set; }
        [IgnoreDataMember] public ICollection<RegParent> FatherEducationParents { get; set; }
        [IgnoreDataMember] public ICollection<RegParent> MatherEducationParents { get; set; }
        [IgnoreDataMember] public ICollection<RegParent> ParentRelationParents { get; set; }

        [IgnoreDataMember] public ICollection<RegStud> GenderStudMasters { get; set; }
        [IgnoreDataMember] public ICollection<RegStud> JoinYearStudMasters { get; set; }
        [IgnoreDataMember] public ICollection<RegStud> JoinTermStudMasters { get; set; }
        [IgnoreDataMember] public ICollection<RegStud> JoinClassSeqStudMasters { get; set; }
        [IgnoreDataMember] public ICollection<RegStud> HealthStudMasters { get; set; }
    }
}
