using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Model.Financial;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Financial;
using School.ServiceLayer.Services.FinancialServices;

namespace School.Controllers.Financial
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentFeeController : ControllerBase
    {
        private StudentFeeService _service;

        public StudentFeeController(StudentFeeService service)
        {
            _service = service;
        }


        // GET: api/FinItem
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



        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var result = _service.GetById(id);
                if (result == null)
                    return NotFound("No Data Found");
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetStudFeesListByParent/{id}")]
        public Task<IEnumerable<object>> GetStudFeesListByParent(int Id)
        {
                var result = _service.GetStudFeesListByParent(Id);
            return result;
        }

        [HttpGet("GetStudFeesDtl/{yearId}/{studId}")]
        public Task<IEnumerable<object>> GetStudFeesDtl(int YearId,int StudId)
        {
            var result = _service.GetStudFeesDtl(YearId,StudId);
            return result;
        }


        [HttpPost]
        public void add(StudentFee obj)
        {
            try
            {
                _service.Add(obj);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                _service.Delete(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        [HttpPut("{id}")]
        public void Update(int id, StudentFeeVw obj)
        {
            _service.Update(id, obj);
        }


    }
}
