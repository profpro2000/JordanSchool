using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.ILookupRepo;
using Domain.Model.Lookups;
using Model.Lookups;
using ServicesAndMiddleware.Filters;
using ServicesAndMiddleware.Helper;

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

        /* public IList<LkpLookup> GetByListType(IList<int> data)
         {

             var list = new List<LkpLookup>();
            // var result = _mapper.Map<List<LkpLookupVw>>(list);

             foreach (var item in data)
             {
                  list.AddRange( _lkpLookupRepo.GetAllWhere(x=>x.TypeId==item));
             }

            // var vw = await _lkpLookupRepo.GetAllWhereAsync(p => p.TypeId == id);
            // var result = _mapper.Map<List<LkpLookupVw>>(vw);

             return list;
         }*/

        public async Task<IEnumerable<LkpLookupVw>> GetByListType(LookupTypes id)
        {
            // IEnumerable<Lookup> list = await _unitOfWork.LookupsRepository.GetListByTypeAsync(id);

            // List<LookupViewModel> listVM = _mapper.Map<List<LookupViewModel>>(list);

            var vw =  _lkpLookupRepo.GetListByType(id);
            var result = _mapper.Map<Task<IEnumerable<LkpLookupVw>>>(vw);
            return await result;
        }
        public async Task<IEnumerable<LkpLookupVw>> GetByListType2(FilterLookupsType filter)
        {
            // IEnumerable<Lookup> list = await _unitOfWork.LookupsRepository.GetListByTypeAsync(id);

            // List<LookupViewModel> listVM = _mapper.Map<List<LookupViewModel>>(list);

            /* List < Lookup > list = await _unitOfWork.LookupsRepository
                     .GetAllWhereAsync(x => filter.Id.Contains(x.LookupTypeId));
             if (filter.IsPrimary == 1)
                 list = list.Where(x => x.IsPrimary == null || x.IsPrimary == filter.IsPrimary).ToList();

             List<LookupViewModel> listVM = _mapper.Map<List<LookupViewModel>>(list);
             return listVM;
             */

            var list =  _lkpLookupRepo.GetAllWhereAsync(x => filter.Ids.Contains(x.TypeId));
           // var vw = _lkpLookupRepo.GetAllAsync(x=>x.ed)
            var result = await _mapper.Map<Task<IEnumerable<LkpLookupVw>>>(list);
            return  result;
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
