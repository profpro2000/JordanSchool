using Core.UsersRepo;
using Domain;
using Domain.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.UsersRepo
{
  public  class UserRepo : DbOperation<Users>, IUserRepo
    {
        private SchoolDbContext _db;

        public UserRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }

        public async  Task<object> CheckLogin( string userName, string password)
        {
            var user =   _db.Users.Where(p => p.Username == userName && p.Password==password).FirstOrDefault();
            if (user == null)
                return null;

            return user;
        }
    
    }
}
