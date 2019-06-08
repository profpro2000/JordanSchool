using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Core.IAddLookupsRepo;
using Domain.Model.AddLookups;
using Model.AddLookups;

namespace School.ServiceLayer.Services.AddLookupServices
{
    public class LkpClassService
    {

        private IMapper _mapper;
        private ILkpClassRepo _interface;
        
        public LkpClassService(IMapper mapper, ILkpClassRepo @interface)
        {
            _mapper = mapper;
            _interface = @interface;
            
        }

      public async Task<List<LkpClassVw>> GetAll()
        {
            
            var vw = await _interface.GetAllAsync();
            var result = _mapper.Map<List<LkpClassVw>>(vw);
            return result;
        }

        public async Task<List<LkpClassVw>> GetById(int id)
        {

            var vw = await _interface.GetAllWhereAsync(p => p.Id == id);
            var result = _mapper.Map<List<LkpClassVw>>(vw);
            return result;

        }

        public void Insert(LkpClassVw obj)
        {
            var tab = _mapper.Map<LkpClass>(obj);
            _interface.Add(tab);
            _interface.SaveChanges();
        }

        public void Update(int id, LkpClassVw obj)
        {
            var tab = _mapper.Map<LkpClass>(obj);
            _interface.Update(id, tab);
            _interface.SaveChanges();
        }

        public void Delete(int id)
        {

            _interface.Delete(id);
            _interface.SaveChanges();
        }
    }
}