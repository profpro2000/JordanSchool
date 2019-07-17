using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Domain.Model;
using Domain.Model.AddLookups;
using Domain.Model.Lookups;
using Domain.Model.Reg;

namespace Model.Reg
{
    public class RegStudVw:AuditModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int StudNo { get; set; }
        [Required]
        public int ParentId { get; set; }//StudParent
        [IgnoreDataMember] public RegParent RegParent { get; set; }
        public string StudFullName { get { return RegParent != null ? FirstName + " " + RegParent.ParentName : ""; } }
        public int IdNum { get; set; }
        [Required] [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string FirstLName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public int? GenderId { get; set; } //Lookup
        public LkpLookup GenderLookup { get; set; }
        [StringLength(15)]
        public string StudMobile { get; set; }
        public string PreviousSchool { get; set; }
        public int? JoinYearId { get; set; } // Lookup
        public LkpLookup JoinYearLookup { get; set; }
        public int? JoinTermId { get; set; }// Lookup
        public LkpLookup JoinTermLookup { get; set; }
        public int? SchoolId { get; set; }// School
        public LkpSchool LkpSchool { get; set; }
        public int? SectionId { get; set; } //Section
        public LkpSection LkpSection { get; set; }
        public int? JoinClassId { get; set; }//LkpClass
        public LkpClass LkpClass { get; set; }
        public int? JoinClassSeqId { get; set; }//Lookup
        public LkpLookup JoinClassSeqLookup { get; set; }
        public string Image { get; set; }// must change to blob
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(100)]
        public string StudFace { get; set; }
        public int? StudBrotherSeq { get; set; }
        public int? StudHealthId { get; set; }//Lookup
        public LkpLookup StudHealthLookup { get; set; }
        [StringLength(100)]
        public string DiseaseName { get; set; }
        [StringLength(100)]
        public string MedicamentName { get; set; }
        [StringLength(500)]
        public string Note { get; set; }
    }
}