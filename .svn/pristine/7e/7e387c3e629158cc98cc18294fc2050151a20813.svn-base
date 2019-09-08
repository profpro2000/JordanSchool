using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Model.Users
{
    public class SysForms:AuditModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public string Icon { get; set; }
        public int? ParentId { get; set; }
        public int? PortalId {get;set;}
        public int? Order { get; set; }
        public int? Active { get; set; }

        [IgnoreDataMember] public ICollection<SysRoleForms> SysRoleForms { get; set; }
    }
}
