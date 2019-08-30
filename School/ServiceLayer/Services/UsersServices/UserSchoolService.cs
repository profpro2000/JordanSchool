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
    public class UserSchoolService
    {
        private IMapper _mapper;
        private IUserSchoolRepo _interface;
        private SchoolDbContext _db;

        public UserSchoolService(IMapper mapper, IUserSchoolRepo @interface, SchoolDbContext db)
        {
            _mapper = mapper;
            _interface = @interface;
            _db = db;
        }


        public UserSchoolVw GetById(int id)
        {
            var vw = _db.UserSchools.Where(p => p.UserId == id).Include(x => x.Schools).FirstOrDefault();
            var result = _mapper.Map<UserSchoolVw>(vw);
            return result;
        }
        public void Insert(UserSchoolVw model)
        {
            var table = _mapper.Map<UserSchool>(model);
            _interface.Add(table);
            _interface.SaveChanges();
        }
        public void Update(int id, UserSchoolVw model)
        {
            var table = _mapper.Map<UserSchool>(model);
            _interface.Update(id, table);
            _interface.SaveChanges();
        }
    }
}
