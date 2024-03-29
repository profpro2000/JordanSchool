﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Domain.Model.AddLookups;
using Domain.Model.Financial;
using Domain.Model.Lookups;
using Domain.Model.Reg;

namespace Domain.Model.Reg
{
    public class RegStud: AuditModel
    {
        public int Id { get; set; }
        public int StudNo { get; set; }
        public  int ParentId { get; set; }//StudParent
        public RegParent RegParent { get; set; }
        public int IdNum { get; set; }
        public string FirstName { get; set; }
        public string FirstLName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public int? GenderId { get; set; } //Lookup
        public LkpLookup GenderLookup { get; set; }
        public string StudMobile { get; set; }
        public string PreviousSchool { get; set; }
        public int? JoinYearId { get; set; } // Lookup
        public LkpLookup JoinYearLookup { get; set; }
        public int? JoinTermId { get; set; }// Lookup
        public  LkpLookup JoinTermLookup { get; set; }
        public int? SchoolId { get; set; }// School
        public LkpSchool LkpSchool { get; set; }
        public int? SectionId { get; set; } //Section
        public LkpSection LkpSection { get; set; }
        public int? JoinClassId { get; set; }//LkpClass
        public LkpClass LkpClass { get; set; }
        public int? JoinClassSeqId { get; set; }//Lookup
        public LkpLookup JoinClassSeqLookup { get; set; }
        public string Image { get; set; }// must change to blob
        public string Email { get; set; }
        public string StudFace { get; set; }
        public int? StudBrotherSeq { get; set; }
        public int? StudHealthId { get; set; }//Lookup
        public LkpLookup StudHealthLookup { get; set; }
        public string DiseaseName { get; set; }
        public string MedicamentName { get; set; }
        public string Note { get; set; }

        [IgnoreDataMember] public ICollection<StudentFee> StudentFees { get; set; }

    }
}