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
    public class PaymentChequeController : ControllerBase
    {

        private PaymentChequeService _servcie;

        public PaymentChequeController(PaymentChequeService servcie)
        {
            _servcie = servcie;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _servcie.GetAll();
            if (result == null)
                return NotFound("No Data Found");
            return Ok(result);
        }

      /*  [HttpGet("GetByPayementId/{paymentId}")]
        public async Task<List<PaymentChequeVw>> GetByPayementId(int paymentId)
        {

            try
            {
                var result =await _servcie.GetByPaymentId(paymentId);
               //  if (result == null)
                //    return NotFound("No Data Found");
               //   return Ok(result);
                return  result;
            }

            catch (Exception e)
            {
                throw e;
            }
        }*/


        [HttpPost]
        public void Add(PaymentCheque obj)
        {
            try
            {
                _servcie.Add(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                _servcie.Delete(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}