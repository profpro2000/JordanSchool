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
    public class LkpCalendarService
    {
        private IMapper _mapper;
        private ILkpCalendarRepo _lkpCalendarRepo;

        public LkpCalendarService(IMapper mapper, ILkpCalendarRepo lkpCalendarRepo)
        {
            _mapper = mapper;
            _lkpCalendarRepo = lkpCalendarRepo;
        }

        public async Task<List<LkpCalendarVw>> GetAll()
        {
            var result = await _lkpCalendarRepo.GetAllAsync();
            var data = _mapper.Map<List<LkpCalendarVw>>(result);
            return data;
        }

        public LkpCalendarVw GetById(int id)
        {
            var vw = _lkpCalendarRepo.Get(id);
            var result = _mapper.Map<LkpCalendarVw>(vw);
            return result;
        }

      

        public void Add(LkpCalendarVw obj)
        {
            var vw = _mapper.Map<LkpCalendar>(obj);
            _lkpCalendarRepo.Add(vw);
            _lkpCalendarRepo.SaveChanges();

        }

        public void Update(int id,LkpCalendar obj)
        {
            _lkpCalendarRepo.Update(id, obj);
            _lkpCalendarRepo.SaveChanges();
        }

        public void Delete(int id)
        {
            _lkpCalendarRepo.Delete(id);
            _lkpCalendarRepo.SaveChanges();
        }
    }
}
