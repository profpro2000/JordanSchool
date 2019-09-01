using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.IFinancial;
using Domain.Model.Financial;
using Model.Financial;

namespace School.ServiceLayer.Services.FinancialServices
{
    public class ClassFeeService
    {
        private IMapper _mapper;
        private IClassFeeRepo _interface;

        public ClassFeeService(IMapper mapper, IClassFeeRepo @interface)
        {
            _mapper = mapper;
            _interface = @interface;
        }



        public async Task<List<ClassFeeVw>> GetAll()
        {
            var vw = await _interface.GetAllAsync();
            var result = _mapper.Map<List<ClassFeeVw>>(vw);
            return result;
        }


        public ClassFeeVw GetById(int Id)
        {
            var vw = _interface.Get(Id);
            var result = _mapper.Map<ClassFeeVw>(vw);
            return result;
        }

        public void Add(ClassFee obj)
        {
            var result = _interface.Add(obj);
            _interface.SaveChanges();

        }

        public void Update(int id, ClassFeeVw obj)
        {
            var tab = _mapper.Map<ClassFee>(obj);
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
