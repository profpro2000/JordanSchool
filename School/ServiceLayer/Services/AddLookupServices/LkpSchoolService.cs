﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.IAddLookupsRepo;
using Domain.Model.AddLookups;
using Model.AddLookups;

namespace School.ServiceLayer.Services.AddLookupServices
{
    public class LkpSchoolService
    {
        private IMapper _mapper;
        private ILkpSchoolRepo _lkpSchoolRepo;

        public LkpSchoolService(IMapper mapper, ILkpSchoolRepo schoolRepo)
        {
            _mapper = mapper;
            _lkpSchoolRepo = schoolRepo;
        }

        public async Task<List<LkpSchoolVw>> GetAll()
        {
            var vw = await _lkpSchoolRepo.GetAll();
            var result = _mapper.Map<List<LkpSchoolVw>>(vw);
            return result;
        }

        public LkpSchoolVw GetById( int id)
        {
            var vw = _lkpSchoolRepo.Get(id);
            var result = _mapper.Map<LkpSchoolVw>(vw);
            return result;
        }

        public void Insert( LkpSchoolVw obj)
        {
            var table = _mapper.Map<LkpSchool>(obj);
            _lkpSchoolRepo.Add(table);
            _lkpSchoolRepo.SaveChanges();
        }

        public void Update(int id, LkpSchoolVw obj)
        {
            var table = _mapper.Map<LkpSchool>(obj);
            _lkpSchoolRepo.Update(id, table);
            _lkpSchoolRepo.SaveChanges();
        }
        public void Delete(int id)
        {
            _lkpSchoolRepo.Delete(id);
            _lkpSchoolRepo.SaveChanges();
        }

        public async  Task<IEnumerable<object>> getTest()
        {

            var vw =   _lkpSchoolRepo.GetTest();
            var table =   _mapper.Map<List<LkpSchoolVw>>(vw);
            return table;
           /* return table.Select(x => new
            {
               SchoolName= x.Aname,
               CityId= x.CityId,
               CityName=  x.CitesLookup.Aname
            }).ToList();
            */
        }

        public async Task<IEnumerable<object>> getTest3()
        {

            var vw = await _lkpSchoolRepo.GetTest3();
           // var table = _mapper.Map<List<LkpSchoolVw>>(vw).ToList();
            return vw;
            
        }

        public LkpSchoolVw getTest2()
        {
            var vw = _lkpSchoolRepo.GetTest2();
            var table = _mapper.Map<LkpSchoolVw>(vw);


            return table;
           

        }

    }
}
