using Core.UsersRepo;
using Domain;
using Domain.Model.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.UsersRepo
{
  public  class UserSchoolRepo : DbOperation<UserSchool>, IUserSchoolRepo
    {
        private SchoolDbContext _db;

        public UserSchoolRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
