using Domain.Model.Lookups;
using Domain.Model.Reg;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Model.Reg
{
    public class RegParentVw
    {

        [Key]
        public int Id { get; set; }
        public string IdNum { get; set; }

        public string FatherName { get { return FirstName+" "+SecondName+" "+FamilyName; } }
        [StringLength(100)][Required]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string SecondName { get; set; }
        public string FatherLName { get { return FirstLName + " " + SecondLName + " " + FamilyLName; } }
        [StringLength(100)]
        public string FamilyName { get; set; }
        [StringLength(100)]
        public string FirstLName { get; set; }
        public string SecondLName { get; set; }
        public string FamilyLName { get; set; }
        public string MotherName { get; set; }
        public int? ReligionId { get; set; } //Lookup
        public LkpLookup ReligionLookup { get; set; }
        public string ReligionName { get { return ReligionLookup != null ? ReligionLookup.AName : ""; } set { } }
        public int? NationalityId { get; set; } //Lookup
       [IgnoreDataMember] public LkpLookup NationalityLookup { get; set; }

        public string NationalityName => NationalityLookup != null ? NationalityLookup.AName : "";

        public int? CityId { get; set; } //Lookup
        public LkpLookup CityLookup { get; set; }
        public string CityName => CityLookup != null ? CityLookup.AName : "";
        [StringLength(100)]
        public string Locality1 { get; set; }
        [StringLength(100)]
        public string Locality2 { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(200)]
        public string Street { get; set; }
        [StringLength(200)]
        public string BuildingNo { get; set; }
        public int? FatherEducationId { get; set; } //Lookup
       // public LkpLookup FatherEducationLookup { get; set; }
        public string FatherSpec { get; set; }
        public int? MatherEducationId { get; set; } //Lookup
       // public LkpLookup MatherEducationLookup { get; set; }
        public string MatherSpec { get; set; }
        public int? ParentRelationId { get; set; } //Lookup
       // public LkpLookup ParentRelationLookup { get; set; }
        public string ParentName { get; set; }
        public string ParentWork { get; set; }
        public int? FamilySize { get; set; }
        public int? FamilyIncome { get; set; }
        public string FamilyAssistance { get; set; }
        public int? RefugeeCardNo { get; set; }
        public string Tel { get; set; }
        public string FatherMobile { get; set; }
        public string MotherMobile { get; set; }
        public int? SmsParent { get; set; }
        public string SmsMobile { get; set; }
        public string ParentEmail { get; set; }
        public string ParentFace { get; set; }
        public string Note { get; set; }

        public ICollection<RegStud> RegStuds { get; set; }
    }
}