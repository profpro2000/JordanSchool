using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Domain.Model.AddLookups;
using Domain.Model.Stud;

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

        [IgnoreDataMember] public ICollection<StudParent> ReligionParents { get; set; }
        [IgnoreDataMember] public ICollection<StudParent> NationalityParents { get; set; }
        [IgnoreDataMember] public ICollection<StudParent> CityParents { get; set; }
        [IgnoreDataMember] public ICollection<StudParent> FatherEducationParents { get; set; }
        [IgnoreDataMember] public ICollection<StudParent> MatherEducationParents { get; set; }
        [IgnoreDataMember] public ICollection<StudParent> ParentRelationParents { get; set; }

        [IgnoreDataMember] public ICollection<StudMaster> GenderStudMasters { get; set; }
        [IgnoreDataMember] public ICollection<StudMaster> JoinYearStudMasters { get; set; }
        [IgnoreDataMember] public ICollection<StudMaster> JoinTermStudMasters { get; set; }
        [IgnoreDataMember] public ICollection<StudMaster> JoinClassSeqStudMasters { get; set; }
        [IgnoreDataMember] public ICollection<StudMaster> HealthStudMasters { get; set; }
    }
}
