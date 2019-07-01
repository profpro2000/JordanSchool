using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.ILookupRepo;
using Domain.Model.Lookups;
using Model.Lookups;

namespace School.ServiceLayer.Services.LookupsServices
{
    public class LkpLookupService
    {
        private IMapper _mapper;
        private ILkpLookupRepo _lkpLookupRepo;

        public LkpLookupService(IMapper mapper, ILkpLookupRepo lkpLookupRepo)
        {
            _mapper = mapper;
            _lkpLookupRepo = lkpLookupRepo;
        }

        public async Task<List<LkpLookupVw>> GetAll()
        {
            var vw = await _lkpLookupRepo.GetAllAsync();
            var result =   _mapper.Map<List<LkpLookupVw>>(vw);
            return result;
        }


        public LkpLookupVw GetById(int id)
        {
            var vw = _lkpLookupRepo.Get(id);
            var result = _mapper.Map<LkpLookupVw>(vw);
            return result;
        }

        public async Task<List<LkpLookupVw>> GetByParentId(int id)
        {
            var vw = await _lkpLookupRepo.GetAllWhereAsync(p => p.TypeId == id);
            var result = _mapper.Map<List<LkpLookupVw>>(vw);
           
            return result;
        }

        public void Add(LkpLookup obj)
        {
          _lkpLookupRepo.Add(obj);
          _lkpLookupRepo.SaveChanges();
        }

         public void Delete(int id)
         {
             _lkpLookupRepo.Delete(id);
             _lkpLookupRepo.SaveChanges();
         }
      /*  public async Task DeleteAsync(int id)
        {
            var _id = await _lkpLookupRepo.GetAsyncById(id);
            // await  _lkpLookupRepo.DeleteAsync(_id);
            _lkpLookupRepo.Delete(_id);
            _lkpLookupRepo.SaveChanges();
        }
        */

        public void Update(int id, LkpLookup obj)
        {
            _lkpLookupRepo.Update(id,obj);
            _lkpLookupRepo.SaveChanges();

        }
    }

}
