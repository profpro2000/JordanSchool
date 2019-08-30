using Domain.Model.AddLookups;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Model.Users
{
  public  class SysUsers
    {

        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Locale { get; set; }
        public string CurrentUrl { get; set; }
        public bool? IsSuperAdmin { get; set; } 
        [IgnoreDataMember] public ICollection<UserSchool> UsersSchool { get; set; }
        [IgnoreDataMember] public ICollection<SysRoles> SysRoles { get; set; }
        [IgnoreDataMember] public ICollection<SysUsersRoles> SysUsersRoles { get; set; }

    }
}
