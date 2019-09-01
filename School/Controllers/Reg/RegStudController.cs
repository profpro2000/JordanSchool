using System;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Microsoft.AspNetCore.Mvc;
using Model.Reg;
using School.ServiceLayer.Services.RegServices;

namespace School.Controllers.Reg
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegStudController : ControllerBase
    {
        // GET: api/StudMaster
        private RegStudService _service;

        public RegStudController(RegStudService service)
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
                return NotFound("No Data Found");
            }

            return Ok(result);
        }

        // GET: api/StudParent/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _service.GetById(id);
            if (result == null)
            {
                return NotFound("No Data Found");
            }

            return Ok(result);
        }

        // POST: api/StudParent
        [HttpPost]
        public async Task<IActionResult> Post(RegStudVw obj)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new Res(false, "State Not Valid", obj));
                }
                _service.Insert(obj);
                return Ok(new Res(true, "Completed", await _service.GetAll())) ;
            }
            catch (Exception e)
            {
                return BadRequest(new Res(false, "Unexpected Error", obj));
            }
          
        }

        // PUT: api/StudParent/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, RegStudVw obj)
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

        //-------Stud Reports


        // GET: api/StudParent/5
        [HttpGet("StudCard/{yearId}/{studId}")]
        public IActionResult GetStudCardDataVw(int yearId,int studId)
        {
            var result =  _service.GetStudCardDataVw(yearId, studId);
            if (result == null)
            {
                return NotFound("No Data Found");
            }

            return Ok(result);
        }
    }
}
