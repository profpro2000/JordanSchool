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
    public class FinItemService  
    {
        private IMapper _mapper;
        private IFinItemRepo _interface;

        public FinItemService(IMapper mapper, IFinItemRepo @interface)
        {
            _mapper = mapper;
            _interface = @interface;
        }

        public async Task<List<FinItemVw>> GetAll()
        {
            var vw = await _interface.GetAllAsync();
            var result = _mapper.Map<List<FinItemVw>>(vw);
            return result;
        }


        public FinItemVw GetById(int Id)
        {
            var vw = _interface.Get(Id);
            var result = _mapper.Map<FinItemVw>(vw);
            return result;
        }

        public void Add(FinItem obj)
        {
            var result = _interface.Add(obj);
            _interface.SaveChanges();

        }

        public void Update(int id, FinItemVw obj)
        {
            var tab = _mapper.Map<FinItem>(obj);
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
