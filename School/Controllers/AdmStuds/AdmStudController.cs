using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Adm;
using School.ServiceLayer.Services.AdmStudServices;

namespace School.Controllers.AdmStuds
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdmStudController : ControllerBase
    {
        AdmStudService _service;

        public AdmStudController(AdmStudService service)
        {
            _service = service;
        }


        // GET: api/AdmStud
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetAll();
            if (!result.Any())
            { return NotFound("No Data Found"); }
            return Ok(result);
        }

        // GET: api/AdmStud/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            //  return await _service.GetById(id);
            var result = await _service.GetById(id);
            if (result==null)
            { return NotFound("No Data Found"); }
            return Ok(result);
        }
        [HttpGet("Parent/{id}")]
        public async Task<IActionResult> GetByParent(int id)
        {
            //  return await _service.GetById(id);
            var result = await _service.GetByParent(id);
            if (result == null)
            { return NotFound("No Data Found"); }
            return Ok(result);
        }

        [HttpGet("ParentAndSchool/{id}/{schoolId}")]
        public async Task<IActionResult> GetByParentAndSchool(int id, int schoolId)
        {
            //  return await _service.GetById(id);
            var result = await _service.GetByParentAndSchool(id, schoolId);
            if (result == null)
            { return NotFound("No Data Found"); }
            return Ok(result);
        }

        [HttpGet("RegChildrens/{id}")]
        public async Task<IActionResult> RegChildrens(int id)
        {
            var result = await _service.GetRegChildrens(id);
            if (result == null)
            { return NotFound("No Data Found"); }
            return Ok(result);
        }


        [HttpGet("RegChildrensBySchool/{id}/{schoolId}")]
        public async Task<IActionResult> RegChildrens(int id, int schoolId)
        {
            var result = await _service.GetRegChildrensBySchool(id, schoolId);
            if (result == null)
            { return NotFound("No Data Found"); }
            return Ok(result);
        }

        [HttpGet("ParentName/{id}")]
        public object GetByName(int id)
        {
            //  return await _service.GetById(id);
            var result =  _service.GetParentName(id);
            return result;
           /* if (result == null)
            { return NotFound("No Data Found"); }
            return Ok(result);*/
        }

        // POST: api/AdmStud
        [HttpPost]
        public void Post(AdmStudVw obj)
        {
            _service.Insert(obj);
        }

        // PUT: api/AdmStud/5
        [HttpPut("{id}")]
        public void Put(int id,AdmStudVw obj)
        {
            _service.Update(id, obj);
        }

        [HttpGet("UpdateStudSeq/{id}")]
        public void UpdateStudSeq(int id)
        {
            _service.UpdateStudSeq(id);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
