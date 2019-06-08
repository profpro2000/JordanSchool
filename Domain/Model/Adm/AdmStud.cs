using System;
using Domain.Model.AddLookups;

namespace Domain.Model.Adm
{
    public class AdmStud:AuditModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int StudNo { get; set; }
        public int SchoolId { get; set; }
        public  LkpSchool LkpSchool { get; set; }
        public  int SectionId { get; set; }
        public LkpSection LkpSection { get; set; }
        public DateTime? EntryDate { get; set; }
        public int ReligionId { get; set; }

    }
}