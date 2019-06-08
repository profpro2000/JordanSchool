using Domain.Model.Lookups;

namespace Domain.Model.AddLookups
{
    public class LkpClass:AuditModel
    {
        public int Id { get; set; }
        public string Aname { get; set; }
        public string Lname { get; set; }
        public int Amt { get; set; }
        public int Capacity { get; set; }
        public float Age { get; set; }
        public int SchoolId { get; set; }
        public LkpSchool LkpSchool { get; set; }
        public int SectionId { get; set; }
        public LkpSection LkpSection { get; set; }
        public int YearId { get; set; }
        public LkpLookup YearsLookup { get; set; }

        
    }
}