using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Domain.Model.AddLookups;
using Domain.Model.Adm;
using Domain.Model.Financial;
using Domain.Model.Reg;

namespace Domain.Model.Lookups
{
    public class LkpLookup : AuditModel
    {
        public int Id { get; set; }
        public string AName { get; set; }
        public string LName { get; set; }
        public string Value { get; set; }
        public int? ParentId { get; set; }
        public int TypeId { get; set; }
        public int? DefaultValue { get; set; }
        public LkpLookupType LkpLookupType { get; set; }

        [IgnoreDataMember] public ICollection<LkpSchool> LkpSchool { get; set; }
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

        //financial
        [IgnoreDataMember] public ICollection<FinItem> CdTypes { get; set; }
        [IgnoreDataMember] public ICollection<FinItem> VpTypes { get; set; }
        [IgnoreDataMember] public ICollection<SchoolFee> SchoolFees { get; set; }

        // Adm
        [IgnoreDataMember] public ICollection<AdmStud> ReligionAdm { get; set; }
        [IgnoreDataMember] public ICollection<AdmStud> GenderAdm { get; set; }
        [IgnoreDataMember] public ICollection<AdmStud> NationalityAdm { get; set; }
        [IgnoreDataMember] public ICollection<AdmStud> ClassSeqAdm { get; set; }
        [IgnoreDataMember] public ICollection<AdmStud> ApprovedAdm { get; set; }
        [IgnoreDataMember] public ICollection<AdmStud> BrotherDescountTypeAdm { get; set; }
        [IgnoreDataMember] public ICollection<AdmStud> YearsAdm { get; set; }
        [IgnoreDataMember] public ICollection<AdmStud> TourType { get; set; }


         [IgnoreDataMember] public ICollection<SchoolFee> SchoolFees { get; set; }
        [IgnoreDataMember] public ICollection<ClassFee> ClassFees { get; set; }
        [IgnoreDataMember] public ICollection<StudentFee> StudentFees { get; set; }
    }
}
