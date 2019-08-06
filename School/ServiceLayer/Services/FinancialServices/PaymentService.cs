using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.IFinancial;
using Domain.Model.Financial;
using Model.Financial;
using Persistence.FinancialRepo;

namespace School.ServiceLayer.Services.FinancialServices
{
    public class PaymentService
    {
        private IMapper _mapper;
        private IPaymentRepo _interface;

        public PaymentService(IMapper mapper, IPaymentRepo @interface)
        {
            _mapper = mapper;
            _interface = @interface;
        }



        public async Task<List<PaymentVw>> GetAll()
        {
            var vw = await _interface.GetAll();
            var result = _mapper.Map<List<PaymentVw>>(vw);
            return result;
        }

        Task<IEnumerable<object>>
        public async Task<List<PaymentVw>> GetByParenetIdYearId(int parentId,int yearId)
        {
            var vw = await _interface.GetByParenetIdYearId(parentId, yearId);
            var result = _mapper.Map<List<PaymentVw>>(vw);
            return result;
        }


        public PaymentVw GetById(int Id)
        {
            var vw = _interface.Get(Id);
            var result = _mapper.Map<PaymentVw>(vw);
            return result;
        }

        public void Add(Payment obj)
        {
            var result = _interface.Add(obj);
            _interface.SaveChanges();

        }

        public void Update(int id, PaymentVw obj)
        {
            var tab = _mapper.Map<Payment>(obj);
            _interface.Update(id, tab);
            _interface.SaveChanges();
        }


        public void Delete(int Id)
        {
            var result = _interface.Delete(Id);
            _interface.SaveChanges();
        }
    }
}
