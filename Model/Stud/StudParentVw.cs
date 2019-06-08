using Domain.Model.Lookups;

namespace Model.Stud
{
    public class StudParentVw
    {

        public int Id { get; set; }
        public string IdNum { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FamilyName { get; set; }
        public string FirstLName { get; set; }
        public string SecondLName { get; set; }
        public string FamilyLName { get; set; }
        public string MotherName { get; set; }
        public int? ReligionId { get; set; } //Lookup
       // public LkpLookup ReligionLookup { get; set; }
        public int? NationalityId { get; set; } //Lookup
      //  public LkpLookup NationalityLookup { get; set; }
        public int? CityId { get; set; } //Lookup
      //  public LkpLookup CityLookup { get; set; }
        public string Locality1 { get; set; }
        public string Locality2 { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
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
    }
}