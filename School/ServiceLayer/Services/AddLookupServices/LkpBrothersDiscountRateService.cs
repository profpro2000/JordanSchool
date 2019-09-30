using AutoMapper;
using Core.IAddLookupsRepo;
using Model.AddLookups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.ServiceLayer.Services.AddLookupServices
{
    public class LkpBrothersDiscountRateService
    {

        private IMapper _mapper;
        private ILkpBrothersDiscountRateRepo _interface;

        public LkpBrothersDiscountRateService(IMapper mapper, ILkpBrothersDiscountRateRepo @interface)
        {
            _mapper = mapper;
            _interface = @interface;
        }

        public async Task<List<LkpBrothersDiscountRateVw>> GetAll()
        {
            var vw = await _interface.GetAllAsync();
            var result = _mapper.Map<List<LkpBrothersDiscountRateVw>>(vw);
            return result;
        }


        public LkpBrothersDiscountRateVw GetById(int Id)
        {
            var vw = _interface.Get(Id);
            var result = _mapper.Map<LkpBrothersDiscountRateVw>(vw);
            return result;
        }
    }
}
