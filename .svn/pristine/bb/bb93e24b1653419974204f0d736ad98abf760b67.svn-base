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
    public class LkpClassFeesService
    {

        private IMapper _mapper;
        private ILkpClassFeesRepo _interface;

        public LkpClassFeesService(IMapper @mapper, ILkpClassFeesRepo @interface)
        {
            _mapper = @mapper;
            _interface = @interface;
        }


        public async Task<List<LkpClassFeesVw>> GetAll()
        {
            var vw = await _interface.GetAllAsync();
            var result = _mapper.Map<List<LkpClassFeesVw>>(vw);
            return result;
        }

        public  LkpClassFeesVw GetById(int id)
        {
            var vw =  _interface.Get(id);
            var result = _mapper.Map<LkpClassFeesVw>(vw);
            return result;
        }

        public LkpClassFeesVw GetByPriceByClassId(int id, int YearId)
        {
            var vw = _interface.Find(p => p.ClassId == id && p.YearId==YearId).FirstOrDefault();
            var result = _mapper.Map<LkpClassFeesVw>(vw);
            return result;
        }


        public void Insert(LkpClassFeesVw obj)
        {
            var tab = _mapper.Map<LkpClassFees>(obj);
            _interface.Add(tab);
            _interface.SaveChanges();
        }

        public void Update(int id, LkpClassFeesVw obj)
        {
            var tab = _mapper.Map<LkpClassFees>(obj);
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
