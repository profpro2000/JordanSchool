using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Model.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Users;
using School.ServiceLayer.Services.UsersServices;

namespace School.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {

        private UserRoleService _service;
        public UserRoleController(UserRoleService service)
        {
            _service = service;
        }

        [HttpGet("Roles")]
        public async Task<List<SysRoles>> GetRoleList()
        {
            return await _service.GetRoleList();
        }
        // GET: api/UserRole
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }



        [HttpGet("{id}")]
        public SysUsersRolesVw GetById(int id)
        {
            return _service.GetById(id);
        }

        // POST: api/UserSchool
        [HttpPost]
        public void Post(SysUsersRolesVw model)
        {
            _service.Insert(model);
        }


        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, SysUsersRolesVw model)
        {
            _service.Update(id, model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
