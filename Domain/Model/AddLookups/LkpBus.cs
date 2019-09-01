using Domain.Model.Adm;
using Domain.Model.Reg;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Domain.Model.AddLookups
{
    public class LkpBus:AuditModel
    {
        public  int Id { get; set; }
        public string SidNo { get; set; }
        public  string DriverName { get; set; }
        public string Mobile { get; set; }
        public string MorningSuper { get; set; }
        public string EvningSuper { get; set; }
        public int SchoolId { get; set; }
        public LkpSchool LkpSchool { get; set; }

        [IgnoreDataMember] public ICollection<AdmStud> BusAdm { get; set; }
        [IgnoreDataMember] public ICollection<YearlyStudReg> YearlyStudRegs { get; set; }

    }
}