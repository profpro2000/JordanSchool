using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Model.Users
{
  public  class SysRoleForms:AuditModel
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int FormId { get; set; }

        [IgnoreDataMember] public SysRoles SysRoles { get; set; }
        [IgnoreDataMember] public SysForms SysForms { get; set; }
        
    }
}
