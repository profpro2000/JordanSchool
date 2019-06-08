using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core;
using Core.IAddLookupsRepo;
using Domain.Model.AddLookups;
using Model.AddLookups;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace School.ServiceLayer.Services.AddLookupServices
{
    public class LkpSectionService
    {
        private IMapper _mapper;
        private ILkpSectionRepo _lkpSectionRepo;

        public LkpSectionService(IMapper mapper, ILkpSectionRepo lkpSectionRepo)
        {
            _mapper = mapper;
            _lkpSectionRepo = lkpSectionRepo;
        }

        public  List<LkpSectionVw> GetAll()
        {
            var vw = _lkpSectionRepo.Find();
            var result = _mapper.Map<List<LkpSectionVw>>(vw);
            return result;
        }

        public LkpSectionVw GetById(int id)
        {
            var vw = _lkpSectionRepo.Find(x => id == x.Id).FirstOrDefault();
            var result = _mapper.Map<LkpSectionVw>(vw);
            return result;
        }

        public void Insert(LkpSectionVw obj)
        {
          
            var vw = _mapper.Map<LkpSection>(obj);
            _lkpSectionRepo.Add(vw);
            _lkpSectionRepo.SaveChanges();
        }

        public void Update(int id, LkpSectionVw obj)
        {
            var vw = _mapper.Map<LkpSection>(obj);
            _lkpSectionRepo.Update(id, vw);
            _lkpSectionRepo.SaveChanges();
        }

        public void Delete(int id)
        {
            _lkpSectionRepo.Delete(id);
            _lkpSectionRepo.SaveChanges();
        }
    }
}
