using Core.UsersRepo;
using Domain;
using Domain.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model.Users;

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
                SchoolLName = p.UsersSchool.Select(x => x.Schools.Lname).FirstOrDefault(),
                YearId = yearId,
                YearName = yearName
            }).FirstOrDefaultAsync();


            if (user == null)
                return null;

            return await user;
        }

        public async Task<IEnumerable<object>> GetUserMenu(int UserId)
        {
            var xx = "";
            xx = null;
            var Vw = _db.SysUserMenuVw.Where(p => p.UserId == UserId).Select(m => new
            {
                Id = m.formId,
                title = m.title,
                routerLink = m.path,
                href = xx ,
                icon=m.icon,
                target=xx,
                hasSubMenu=m.parentId>0?false:true,
                m.parentId,
                m.OrderId
            })
                .ToList().OrderBy(x=>x.OrderId);
            return Vw;
        }
        
        public object GetSchoolById(int id)
        {
            var result = _db.UserSchools.Where(p => p.UserId == id).FirstOrDefault();
            return result;
        }
        
        public async Task<IEnumerable<object>> GetAll()
        {
           // var result = _db.SysUsers.Include(p => p.UsersSchool).ToList();
            var result = _db.SysUsers.Select(p => new
            {
                Id = p.Id,
                p.Username,
                p.Password,
                RoleName = p.SysUsersRoles != null ? p.SysUsersRoles.Where(x => x.UserId == p.Id).Select(xx => xx.SysRoles.name).FirstOrDefault() : "",
                schoolId = p.UsersSchool != null ? p.UsersSchool.Where(x => x.UserId == p.Id).Select(xx => xx.SchoolId).FirstOrDefault() : 0,
                schoolName = p.UsersSchool != null ? p.UsersSchool.Where(x => x.UserId == p.Id).Select(xx => xx.Schools.Aname).FirstOrDefault() : "",
                p.Email
            }).ToList();
            return result;
        }

    }
}
