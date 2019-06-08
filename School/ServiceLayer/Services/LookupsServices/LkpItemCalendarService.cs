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
    public class LkpItemCalendarService
    {
        private IMapper _mapper;
        private ILkpItemCalendarRepo _lkpItemCalendarRepo;

        public LkpItemCalendarService(IMapper mapper, ILkpItemCalendarRepo lkpItemCalendarRepo)
        {
            _mapper = mapper;
            _lkpItemCalendarRepo = lkpItemCalendarRepo;
        }

       
        public List<LkpItemCalendarVw> GetList()
        {
            var result = _lkpItemCalendarRepo.GetItemCalendars();
            var x =  _mapper.Map<List<LkpItemCalendarVw>>(result);
            return x;
        }
        [HttpGet]
        public async Task<List<LkpItemCalendarVw>> GetAllLkpCalendar()
        {
            var result = await _lkpItemCalendarRepo.GetAllLkpCalendar();
            var x = _mapper.Map<List<LkpItemCalendarVw>>(result);
            return x;
        }

        [HttpGet("List")]
        public async Task<List<LkpItemCalendarVw>> Get()
        {
            var vw = await _lkpItemCalendarRepo.GetAllAsync();
            var result = _mapper.Map<List<LkpItemCalendarVw>>(vw);
            return result;
        }

        public void Add(LkpItemCalendar obj)
        {
            _lkpItemCalendarRepo.Add(obj);
            _lkpItemCalendarRepo.SaveChanges();
        }

        public void Delete(int id)
        {
            _lkpItemCalendarRepo.Delete(id);
            _lkpItemCalendarRepo.SaveChanges();
        }
    }
}
