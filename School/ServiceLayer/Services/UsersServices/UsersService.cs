using AutoMapper;
using Core.UsersRepo;
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

        public Task<object> CheckLogin (string userName, string password)
        {
            return _interface.CheckLogin(userName, password);
        }
    }
}
