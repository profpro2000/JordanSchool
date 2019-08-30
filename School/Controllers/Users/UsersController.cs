using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Users;
using School.ServiceLayer.Services.UsersServices;


namespace School.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {


        private UsersService _service;
        public UsersController(UsersService service)
        {
            _service = service;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<List<object>> Get()
        {
            return await _service.GetAll();
        }
        [HttpGet("{id}")]
        public UsersVw GetById(int id)
        {
            return _service.GetById(id);
        }

        // GET: api/Users/5
        [HttpGet("checkLogin/{userName}/{password}")]
        public Task<object> Get(string userName, string password)
        {


            var option = new CookieOptions();

            option.Expires = DateTime.Now.AddMinutes(10);

            Response.Cookies.Append("new", "Hello From New", option);

            var test = Request.Cookies["new"];


            return _service.CheckLogin(userName, password);
        }

        // POST: api/Users
        [HttpPost]
        public void Post(UsersVw model)
        {
            _service.Insert(model);
        }
        

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, UsersVw model)
        {
            _service.Update(id, model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }

        [HttpGet("GetUserMenu/{UserId}")]

        public async Task<IEnumerable<object>> GetUserMenu(int UserId)
        {
            var vw = await _service.GetUserMenu(UserId);
            return vw;
        }

        [HttpGet("GetSchoolById/{UserId}")]

        public object GetSchoolById(int UserId)
        {
            var vw =  _service.GetSchoolById(UserId);
            return vw;
        }

        
    }
}
