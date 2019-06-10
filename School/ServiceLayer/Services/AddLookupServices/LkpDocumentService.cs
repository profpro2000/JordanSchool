using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.IAddLookupsRepo;
using Model.Lookups;

namespace School.ServiceLayer.Services.AddLookupServices
{
    public class LkpDocumentService
    {
        private IMapper _mapper;
        private ILkpDocumentRepo _ILkpDocumentRepo;

        public LkpDocumentService(IMapper mapper, ILkpDocumentRepo ILkpDocumentRepo)
        {
            _mapper = mapper;
            _ILkpDocumentRepo = ILkpDocumentRepo;
        }




        public async Task <List<LkpDocumentVw>> GetAll()
        {
            var vw = await _ILkpDocumentRepo.GetAllAsync();
            var result = _mapper.Map<List<LkpDocumentVw>>(vw);
            return result;
                }
    }

}
    



