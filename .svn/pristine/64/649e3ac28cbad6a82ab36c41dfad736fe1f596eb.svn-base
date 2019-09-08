using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Model.Users
{
  public  class SysRoles:AuditModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string Description { get; set; }
        public int Active { get; set; }

        [IgnoreDataMember] public ICollection<SysRoleForms> SysRoleForms { get; set; }
        [IgnoreDataMember] public ICollection<SysUsersRoles> SysUsersRoles { get; set; }


    }
}
