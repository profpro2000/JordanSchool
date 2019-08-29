using AutoMapper;
using Core.IFinancial;
using Domain.Model.Financial;
using Microsoft.AspNetCore.Mvc;
using Model.Financial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.ServiceLayer.Services.FinancialServices
{
    public class PaymentChequeService
    {

        private IMapper _mapper;
        private IPaymentChequeRepo _interface;

        public PaymentChequeService(IMapper mapper, IPaymentChequeRepo @interface)
        {
            _mapper = mapper;
            _interface = @interface;
        }

     /*-   public async Task<List<PaymentChequeVw>> GetByPaymentId(int StudentFeeId)
        {
            var v = await _interface.GetByStudentFeetId(StudentFeeId);
            var result = _mapper.Map<List<PaymentChequeVw>>(v);
            return result;
        }*/


        public async Task<List<PaymentChequeVw>> GetAll()
        {
            var vw = await _interface.GetAll();
            var result = _mapper.Map<List<PaymentChequeVw>>(vw);
            return result;
        }

        public void Add(PaymentCheque obj)
        {
            var result = _interface.Add(obj);
            _interface.SaveChanges();
        }


        public void Delete(int Id)
        {
            var result = _interface.Delete(Id);
            _interface.SaveChanges();
        }



    }
}
