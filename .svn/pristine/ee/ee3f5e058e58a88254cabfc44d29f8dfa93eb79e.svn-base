using Core.UsersRepo;
using Domain;
using Domain.Model.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.UsersRepo
{
 public   class SysFormsRepo : DbOperation<SysForms>, ISysFormsRepo
    {
        private SchoolDbContext _db;

        public SysFormsRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
