﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Domain.Model.Stud;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Stud;
using School.ServiceLayer.Services.StudServices;

namespace School.Controllers.Stud
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudParentController : ControllerBase
    {
        private StudParentService _service;

        public StudParentController(StudParentService service)
        {
            _service = service;
        }

        // GET: api/StudParent
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetAll();
            if (!result.Any())
            {
              return  NotFound("No Data Found");
            }

            return Ok(result);
        }

        // GET: api/StudParent/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _service.GetById(id);
            if (!result.Any())
            {
              return  NotFound("No Data Found");
            }

            return Ok(result);
        }

        // POST: api/StudParent
        [HttpPost]
        public  async Task<IActionResult> Post(StudParentVw obj)
        {
            if (!ModelState.IsValid)
            {
                Response.StatusCode = 400;
                return Ok(new Res(false, "State Not Valid", obj));
            }
            _service.Insert(obj);
            return Ok(new Res(true, "Complite", await _service.GetAll()));
        }

        // PUT: api/StudParent/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, StudParentVw obj)
        {

            if (!ModelState.IsValid)
            {
                Response.StatusCode = 400;
                return Ok(new Res(false, "State not valid", obj));
            }
            _service.Update(id, obj);
            return Ok(new Res(true, "Complite", await _service.GetAll()));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                Response.StatusCode = 400;
                return Ok(new Res(false, "State not valid", null));
            }
            _service.Delete(id);
            return Accepted();
        }
    }
}