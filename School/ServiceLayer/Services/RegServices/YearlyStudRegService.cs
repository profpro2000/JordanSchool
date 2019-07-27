using AutoMapper;
using Core.IRegRepo;
using Domain.Model.Reg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.ServiceLayer.Services.RegServices
{
    public class YearlyStudRegService
    {

        private IMapper _mapper;
        private IYearlyStudRegRepo _interface;

        public YearlyStudRegService(IMapper mapper, IYearlyStudRegRepo @interface)
        {
            _mapper = mapper;
            _interface = @interface;
        }

        public async Task<List<YearlyStudRegVw>> GetAll()
        {
            var vw = await _interface.GetAllAsync();
            var result = _mapper.Map<List<YearlyStudRegVw>>(vw);
            return result;
        }

        public async Task<YearlyStudRegVw> GetById(int id)
        {
            var vw = await _interface.GetAsync(p => p.Id == id);
            var result = _mapper.Map<YearlyStudRegVw>(vw);
            return result;
        }
        public async Task<List<object>>GetParentChildrens(int id)
        {
            var vw = await _interface.GetParentChildrens(id);
            var result = _mapper.Map<List<object>>(vw);
            return result;
        }
        public int ConfirmStudReg(int id, int PYearId, int oldClassId, int newClassId)
        {

          
             int msg=  _interface.ConfirmStudReg(id,  PYearId, oldClassId, newClassId);
               _interface.SaveChanges();
            return msg;
        }

    }
}
