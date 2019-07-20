using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Core.IRegRepo;
using Domain.Model.Reg;
using Model.Reg;
using School.MiddlewareAndServices.Services;

namespace School.ServiceLayer.Services.RegServices
{
    public class RegStudService 
    {
        private IMapper _mapper;
        private IRegStudRepo _interface;
        private UserService _userService;

        public RegStudService(IMapper mapper, IRegStudRepo @interface, UserService userService)
        {
            _mapper = mapper;
            _interface = @interface;
            _userService = userService;
            _userService.Id=101;  //For Testing
        }

        public async Task<List<RegStudVw>> GetAll()
        {
            var vw = await _interface.StudList();
            var result = _mapper.Map<List<RegStudVw>>(vw);
            return result;
        }


        public async Task<RegStudVw> GetById(int id)
        {
            var vw = await _interface.GetAsync(p => p.Id == id);
            var result = _mapper.Map<RegStudVw>(vw);
            return result;
        }

        public void Insert(RegStudVw obj)
        {
            var table = _mapper.Map<RegStud>(obj);
            table.InsertDate = DateTime.Now;
            table.InsertUser = _userService.Id;

            _interface.Add(table);
            _interface.SaveChanges();
        }

        public void Update(int id, RegStudVw obj)
        {
            var table = _mapper.Map<RegStud>(obj);
            table.UpdateDate=DateTime.Now;
            table.UpdateUser = _userService.Id;

            _interface.Update(id, table);
            _interface.SaveChanges();
        }
        public void Delete(int id)
        {
            _interface.Delete(id);
            _interface.SaveChanges();
        }
    }
}