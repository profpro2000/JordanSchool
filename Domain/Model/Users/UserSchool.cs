using Domain.Model.AddLookups;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.Users
{
  public  class UserSchool
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SchoolId { get; set; }
        public SysUsers User { get; set; }
        public LkpSchool Schools { get; set; }
    }
}
