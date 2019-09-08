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


        //[HttpGet("GetChequesListByFeeId/{feeId}")]
        //public Task<IEnumerable<object>> GetChequesListByFeeId(int FeeId)
        //{
        //    var v = _service.GetChequesListByFeeId(FeeId);
        //    return v;
        //}


        [HttpGet("GetStudFeesListByParent/{YearId}/{id}")]
        public Task<IEnumerable<object>> GetStudFeesListByParent(int YearId, int Id)
        {
                var result = _service.GetStudFeesListByParent(YearId,Id);
            return result;
        }


        [HttpGet("GetPaymentList/{YearId}/{ParentId}")]
        public async Task<IEnumerable<object>> GetPaymentList(int YearId, int ParentId)
        {
            var result = await _service.GetPaymentList(YearId, ParentId);
            return result;
        }

        [HttpGet("GetStudFeesDtl/{yearId}/{studId}")]
        public Task<IEnumerable<object>> GetStudFeesDtl(int YearId,int StudId)
        {
            var result = _service.GetStudFeesDtl(YearId,StudId);
            return result;
        }


        [HttpPost]
        public object add(StudentFee obj)
        {
            
               return _service.Add(obj);
               
            

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

        [HttpGet("FinStudCard/{YearId}/{ParentId}")]
        public Task<IEnumerable<object>> FinStudCard(int YearId, int ParentId)
        {
            var result = _service.FinStudCard(YearId, ParentId);
            return result;
        }

        [HttpGet("FinStudCardByStud/{YearId}/{StudId}")]
        public Task<IEnumerable<object>> FinStudCardByStud(int YearId, int StudId)
        {
            var result = _service.FinStudCardByStud(YearId, StudId);
            return result;
        }

    }
}
