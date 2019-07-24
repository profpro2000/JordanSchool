using Domain.Model.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.UsersRepo
{
   public interface IUserRepo : IRepo<SysUsers>
{

        Task<object> CheckLogin(string userName, string password);
}
}
