using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Model.Users
{
 public  class SysUsersRoles: AuditModel
    {
        
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
        [IgnoreDataMember] public SysRoles SysRoles { get; set; }
        [IgnoreDataMember] public SysUsers SysUsers { get; set; }
        
    }
}
