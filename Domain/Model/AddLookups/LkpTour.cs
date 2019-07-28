using Domain.Model.Adm;
using Domain.Model.Reg;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Model.AddLookups
{
  public  class LkpTour:AuditModel
    {
        public int Id { get; set; }
        public string TourName { get; set; }
        public int TourFullPrice { get; set; }
        public  int TourHalfPrice { get; set; }
        public  int SchoolId { get; set; }
        public LkpSchool LkpSchool { get; set; }

        [IgnoreDataMember] public ICollection<AdmStud> TourAdm { get; set; }
        [IgnoreDataMember] public ICollection<YearlyStudReg> YearlyStudRegs { get; set; }
    }
}
