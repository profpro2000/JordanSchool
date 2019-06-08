using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.ILookupRepo;
using Domain.Model.Lookups;
using Microsoft.AspNetCore.Mvc;
using Model.Lookups;

namespace School.ServiceLayer.Services.LookupsServices
{
    public class LkpLookupTypeService
    {
        private IMapper _mapper;
        private ILkpLookupTypeRepo _lkpLookupTypeRepo;

        public LkpLookupTypeService(IMapper mapper, ILkpLookupTypeRepo iLkpLookupTypeRepo)
        {
            _mapper = mapper;
            _lkpLookupTypeRepo = iLkpLookupTypeRepo;
        }

       

        public async  Task<List<LkpLookupTypeVw>> GetList()
        {
            var vw =  await _lkpLookupTypeRepo.GetAllAsync();
            var result =    _mapper.Map<List<LkpLookupTypeVw>>(vw);
            return result;
        }

        public  async Task<List<LkpLookupTypeVw>> GetAllWithChildren()
        {
            var vw = await _lkpLookupTypeRepo.GetAllWithChildren();
            var result = _mapper.Map<List<LkpLookupTypeVw>>(vw);
            return result;
        }

       
        public  LkpLookupTypeVw GetById(int Id)
        {
            var vw =  _lkpLookupTypeRepo.Get(Id);
            var result = _mapper.Map<LkpLookupTypeVw>(vw);
            return result;
        }



        public  void Add( LkpLookupType obj)
        {
            var result = _lkpLookupTypeRepo.Add(obj);
            _lkpLookupTypeRepo.SaveChanges();
        }

        public void Delete(int id)
        {
            var result = _lkpLookupTypeRepo.Delete(id);
            _lkpLookupTypeRepo.SaveChanges();
        }
    }
}
