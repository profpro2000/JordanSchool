using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.IAdmRepo;
using Model.Fin;

namespace School.ServiceLayer.Services.FinServices
{
    public class FinItemService
    {

        private IMapper _mapper;
        private IAdmStudRepo _interface;

        public FinItemService(IMapper mapper, IAdmStudRepo @interface)
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


    }
}
