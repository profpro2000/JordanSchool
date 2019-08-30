using AutoMapper;
using Core.UsersRepo;
using Domain.Model.Users;
using Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.ServiceLayer.Services.UsersServices
{
    public class UsersService
    {
        private IMapper _mapper;
        private IUserRepo _interface;

        public UsersService(IMapper mapper, IUserRepo @interface)
        {
            _mapper = mapper;
            _interface = @interface;
        }
        
        public async Task<List<object>> GetAll()
        {
            var vw = await _interface.GetAll();
            var result =  _mapper.Map<List<object>>(vw);
            return result;
        }
        
        public UsersVw GetById(int id)
        {
            var vw = _interface.Get(id);
            var result = _mapper.Map<UsersVw>(vw);
            return result;
        }
        public void Insert(UsersVw model)
        {
            var table = _mapper.Map<SysUsers>(model);
            _interface.Add(table);
            _interface.SaveChanges();
        }
        public void Update (int id, UsersVw model)
        {
            var table = _mapper.Map<SysUsers>(model);
            _interface.Update(id,table);
            _interface.SaveChanges();
        }
        public void Delete(int id)
        {
            _interface.Delete(id);
            _interface.SaveChanges();
        }

        public Task<object> CheckLogin (string userName, string password)
        {
            return _interface.CheckLogin(userName, password);
        }

        //-----Stud GetUSerForms
        public async Task<IEnumerable<object>> GetUserMenu(int UserId)
        {
            var vw = await _interface.GetUserMenu(UserId);
            return vw;
        }

        //---------School Info

        public UserSchool GetSchoolById(int id)
        {
            var vw = _interface.GetSchoolById(id);
            var result = _mapper.Map<UserSchool>(vw);
            return result;
        }
        
    }
}
