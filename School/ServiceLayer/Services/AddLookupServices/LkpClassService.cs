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

        public LkpClassVw GetById(int id)
        {

            var vw = _interface.Get(p => p.Id == id);
            var result = _mapper.Map<LkpClassVw>(vw);
            return result;

        }

        public async Task<IEnumerable<object>> GetClassBySchool(int schoolId)
        {

            var vw = await _interface.GetClassBySchool(schoolId);
           // var result = _mapper.Map<List<LkpClassVw>>(vw);
            return vw;

        }

        public async Task<IEnumerable<object>> GetClassBySection(int sectionId)
        {

            var vw = await _interface.GetClassBySection(sectionId);
            // var result = _mapper.Map<List<LkpClassVw>>(vw);
            return vw;

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