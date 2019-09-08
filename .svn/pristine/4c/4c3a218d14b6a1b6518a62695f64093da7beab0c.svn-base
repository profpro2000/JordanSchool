using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Core.IAddLookupsRepo;
using Domain.Model.AddLookups;
using Model.AddLookups;

namespace School.ServiceLayer.Services.AddLookupServices
{
    public class LkpBusService
    {
        private IMapper _mapper;
        private ILkpBusRepo _lkpBusRepo;

        public LkpBusService(IMapper mapper, ILkpBusRepo lkpBusRepo)
        {
            _mapper = mapper;
            _lkpBusRepo = lkpBusRepo;
        }


        public async Task<List<LkpBusVw>> GetAll()
        {
            var vw = await _lkpBusRepo.GetAllAsync();
            var result = _mapper.Map<List<LkpBusVw>>(vw);
            return result;
        }

        public async Task<List<LkpBusVw>> GetById(int id)
        {
            
            var vw = await _lkpBusRepo.GetAllWhereAsync(p => p.Id == id);
            var result = _mapper.Map<List<LkpBusVw>>(vw);
            return result;

        }

        public void Insert(LkpBusVw obj)
        {
            var tab = _mapper.Map<LkpBus>(obj);
            _lkpBusRepo.Add(tab);
            _lkpBusRepo.SaveChanges();
        }

        public void Update(int id, LkpBusVw obj)
        {
            var tab = _mapper.Map<LkpBus>(obj);
            _lkpBusRepo.Update(id, tab);
            _lkpBusRepo.SaveChanges();
        }

        public void Delete(int id)
        {

            _lkpBusRepo.Delete(id);
            _lkpBusRepo.SaveChanges();
        }
    }
}