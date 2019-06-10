using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.IAdmRepo;
using Model.Adm;

namespace School.ServiceLayer.Services.AdmServices
{
    public class AdmStudService
    {
        private IMapper _mapper;
        private IAdmStudRepo _interface;

        public AdmStudService(IMapper mapper, IAdmStudRepo @interface)
        {
            _mapper = mapper;
            _interface = @interface;
        }


        public async Task<List<AdmStudVw>> GetAll()
        {
            var vw = await _interface.GetAllAsync();
            var result = _mapper.Map<List<AdmStudVw>>(vw);
            return result;
        }

    }
}
