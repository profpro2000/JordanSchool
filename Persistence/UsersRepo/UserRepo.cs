using Core.UsersRepo;
using Domain;
using Domain.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Persistence.UsersRepo
{
  public  class UserRepo : DbOperation<SysUsers>, IUserRepo
    {
        private SchoolDbContext _db;

        public UserRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }

        public async  Task<object> CheckLogin( string userName, string password)
        {
            /* var user = _db.Users.Where(p => p.Username == userName && p.Password == password)
                 .Include(p=>p.UsersSchool.FirstOrDefault())
                 .FirstOrDefault();
                 */

            var yearObj= _db.LkpYears.FirstOrDefault(x => x.Active == 1);
            var yearId = yearObj?.Id;
            var yearName = yearObj?.AName;

            var user = _db.Users.Where(p => p.Username == userName && p.Password == password)
            .Select(p => new
            {
                p.Id,
                p.EmployeeId,
                p.Username,
                p.Password,
                p.IsSuperAdmin,
                p.Locale,
                p.Email,
                SchoolId=p.UsersSchool.Select(x=> x.SchoolId).FirstOrDefault(),
                SchoolName = p.UsersSchool.Select(x => x.Schools.Aname).FirstOrDefault(),
                YearId= yearId,
                YearName = yearName
            }).FirstOrDefaultAsync();


            if (user == null)
                return null;

            return await user;
        }
    
    }
}
