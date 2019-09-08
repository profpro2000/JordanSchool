using Domain.Model.Users;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Model.Users
{
  public  class SysRolesVw
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string Description { get; set; }
        public int Active { get; set; }

        [IgnoreDataMember] public ICollection<SysRoleForms> SysRoleForms { get; set; }
        [IgnoreDataMember] public ICollection<SysUsersRoles> SysUsersRoles { get; set; }
    }
}
