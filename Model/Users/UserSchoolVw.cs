using Domain.Model.AddLookups;
using System;
using System.Collections.Generic;
using Domain.Model.Users;
using System.Runtime.Serialization;

namespace Model.Users
{
  public  class UserSchoolVw
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public int SchoolId { get; set; }
        public string SchoolName { get { return Schools!=null? Schools.Aname:""; } }
        [IgnoreDataMember] public SysUsers User { get; set; }
        [IgnoreDataMember] public LkpSchool Schools { get; set; }
    }
}
