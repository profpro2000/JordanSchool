using AutoMapper;
using Core.UsersRepo;
using Domain;
using Domain.Model.Users;
using Microsoft.EntityFrameworkCore;
using Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.ServiceLayer.Services.UsersServices
{
    public class UserRoleService
    {
        private IMapper _mapper;
        private ISysUserRoleRepo _interface;
        private SchoolDbContext _db;

        public UserRoleService(IMapper mapper, ISysUserRoleRepo @interface, SchoolDbContext db)
        {
            _mapper = mapper;
            _interface = @interface;
            _db = db;
        }

        public async Task<List<SysRoles>> GetRoleList()
        {
            return  _db.SysRoles.ToList();
        }

        public SysUsersRolesVw GetById(int id)
        {
            var vw = _db.SysUsersRoles.Where(p => p.UserId == id).Include(x => x.SysRoles).FirstOrDefault();
            var result = _mapper.Map<SysUsersRolesVw>(vw);
            return result;
        }
        public void Insert(SysUsersRolesVw model)
        {
            var table = _mapper.Map<SysUsersRoles>(model);
            _interface.Add(table);
            _interface.SaveChanges();
        }
        public void Update(int id, SysUsersRolesVw model)
        {
            var table = _mapper.Map<SysUsersRoles>(model);
            _interface.Update(id, table);
            _interface.SaveChanges();
        }
    }
}
