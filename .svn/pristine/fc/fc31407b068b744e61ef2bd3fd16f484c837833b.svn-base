using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Users;
using School.ServiceLayer.Services.UsersServices;

namespace School.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSchoolController : ControllerBase
    {
        private UserSchoolService _service;
        public UserSchoolController(UserSchoolService service)
        {
            _service = service;
        }
        
        // GET: api/UserSchool
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UserSchool/5
    
    [HttpGet("{id}")]
    public UserSchoolVw GetById(int id)
    {
        return _service.GetById(id);
    }

        // POST: api/UserSchool
        [HttpPost]
        public void Post(UserSchoolVw model)
        {
            _service.Insert(model);
        }


        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, UserSchoolVw model)
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
