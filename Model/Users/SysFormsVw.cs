using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Users
{
   public class SysFormsVw
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public string Icon { get; set; }
        public int? ParentId { get; set; }
        public int? PortalId { get; set; }
        public int? Order { get; set; }
        public int? Active { get; set; }
    }
}
