using Core.UsersRepo;
using Domain;
using Domain.Model.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.UsersRepo
{
 public  class SysUserRoleRepo : DbOperation<SysUsersRoles>, ISysUserRoleRepo
    {
        private SchoolDbContext _db;

        public SysUserRoleRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
