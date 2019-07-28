using Domain.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Model.Users
{
 public   class UsersVw
    {


        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Locale { get; set; }
        public string CurrentUrl { get; set; }
        public bool? IsSuperAdmin { get; set; }
        public ICollection<UserSchool> UsersSchool { get; set; }

    }
}
