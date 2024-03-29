﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Domain.Model.Adm;
using Domain.Model.Financial;
using Domain.Model.Lookups;
using Domain.Model.Reg;

namespace Domain.Model.AddLookups
{
    public class LkpClass:AuditModel
    {
        public int Id { get; set; }
        public string Aname { get; set; }
        public string Lname { get; set; }
        public int Amt { get; set; }  // Not used
        public int Capacity { get; set; }
        public float Age { get; set; }
        public int SchoolId { get; set; }
        public LkpSchool LkpSchool { get; set; }
        public int SectionId { get; set; }
        public LkpSection LkpSection { get; set; }
       
        public int? YearId { get; set; }
        public LkpYear YearsLookup { get; set; }
        public int? ClassSeq { get; set; }
        public int? ClassGender { get; set; } //0=All, 1=Male, 2=Female

        [IgnoreDataMember] public ICollection<RegStud> ClassRegStuds { get; set; }
        [IgnoreDataMember] public ICollection<AdmStud> ClassAdm { get; set; }
        [IgnoreDataMember] public ICollection<ClassFee> ClassFees { get; set; }
        [IgnoreDataMember] public ICollection<YearlyStudReg> YearlyStudRegs { get; set; }
        [IgnoreDataMember] public ICollection<LkpClassFees> LkpClassFees { get; set; }


    }
}