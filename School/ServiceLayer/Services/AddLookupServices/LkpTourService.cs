using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.IAddLookupsRepo;
using Domain.Model.AddLookups;
using Model.AddLookups;

namespace School.ServiceLayer.Services.AddLookupServices
{
    public class LkpTourService
    {
        private IMapper _mapper;
        private ILkpTourRepo _lkpTourRepo;

        public LkpTourService(IMapper mapper, ILkpTourRepo lkpTourRepo)
        {
            _mapper = mapper;
            _lkpTourRepo = lkpTourRepo;
        }


        public async Task<List<LkpTourVw>> GetAll()
        {
            var vw = await _lkpTourRepo.GetAllAsync();
            var result = _mapper.Map<List<LkpTourVw>>(vw);
            return result;
        }

        public async  Task<List<LkpTourVw>> GetById(int id)
        {
            //var vw =   _lkpTourRepo.Find(p => p.Id == id).FirstOrDefault();
          //var vw = await _lkpTourRepo.GetAsyncById(id);
           var vw = await _lkpTourRepo.GetAllWhereAsync(p => p.Id == id);
            var result = _mapper.Map<List<LkpTourVw>>(vw);
            return result;

        }

        public void Insert(LkpTourVw obj)
        {
            var tab = _mapper.Map<LkpTour>(obj);
            _lkpTourRepo.Add(tab);
            _lkpTourRepo.SaveChanges();
        }

        public void Update(int id,LkpTourVw obj)
        {
            var tab = _mapper.Map<LkpTour>(obj);
            _lkpTourRepo.Update(id,tab);
            _lkpTourRepo.SaveChanges();
        }

        public void Delete(int id)
        {
           
            _lkpTourRepo.Delete(id);
            _lkpTourRepo.SaveChanges();
        }



    }
}