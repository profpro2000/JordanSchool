using AutoMapper;
using Core.IAddLookupsRepo;
using Domain.Model.AddLookups;
using Model.AddLookups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.ServiceLayer.Services.AddLookupServices
{
    public class LkpYearService
    {

        private IMapper _mapper;
        private ILkpYearRepo _lkpYearRepo;

        public LkpYearService(IMapper mapper, ILkpYearRepo lkpYearRepo)
        {
            _mapper = mapper;
            _lkpYearRepo = lkpYearRepo;
        }

        public async Task<List<LkpYearVw>> GetAll()
        {
            var vw = await _lkpYearRepo.GetAllAsync();
            var result = _mapper.Map<List<LkpYearVw>>(vw);
            return result;
        }

        public async Task<LkpYearVw> GetById(int id)
        {
            var vw =   _lkpYearRepo.Get(id);
            var result = _mapper.Map<LkpYearVw>(vw);
            return result;

        }
        public async Task<LkpYearVw> GetCurrentYear()
        {
            var vw = await _lkpYearRepo.GetCurrentYear();
            var result = _mapper.Map<LkpYearVw>(vw);
            return result;

        }

        public void Insert(LkpYearVw obj)
        {
            var tab = _mapper.Map<LkpYear>(obj);
            _lkpYearRepo.Add(tab);
            _lkpYearRepo.SaveChanges();
        }

        public void Update(int id, LkpYearVw obj)
        {
            var tab = _mapper.Map<LkpYear>(obj);
            _lkpYearRepo.Update(id, tab);
            _lkpYearRepo.SaveChanges();
        }

        public void Delete(int id)
        {
            _lkpYearRepo.Delete(id);
            _lkpYearRepo.SaveChanges();
        }


    }
}
