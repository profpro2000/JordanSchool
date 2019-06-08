using System;
using System.Collections.Generic;
using System.Text;
using Domain.Model.AddLookups;

namespace Model.AddLookups
{
  public  class LkpSectionVw
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
        public int ManagerId { get; set; }
        public string Email { get; set; }
        public string NationalId { get; set; }
        public int SchoolId { get; set; }
       
    }
}
