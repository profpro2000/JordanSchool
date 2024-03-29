﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.IFinancial;
using Domain.Model.Financial;
using Model.Financial;

namespace School.ServiceLayer.Services.FinancialServices
{
    public class SchoolFeeService
    {

        private IMapper _mapper;
        private ISchoolFeeRepo _interface;

        public SchoolFeeService(IMapper mapper, ISchoolFeeRepo @interface)
        {
            _mapper = mapper;
            _interface = @interface;
        }


        public async Task<List<SchoolFeeVw>> GetAll()
        {
          //  var vw = await _interface.GetAllAsync();
            var vw = await _interface.GetAll();
            var result = _mapper.Map<List<SchoolFeeVw>>(vw);
            return result;
        }


        public SchoolFeeVw GetById(int Id)
        {
            var vw = _interface.Get(Id);
            var result = _mapper.Map<SchoolFeeVw>(vw);
            return result;
        }

        public void Add(SchoolFee obj)
        {
            var result = _interface.Add(obj);
            _interface.SaveChanges();

        }

        public void Update(int id, SchoolFeeVw obj)
        {
            var tab = _mapper.Map<SchoolFee>(obj);
            _interface.Update(id, tab);
            _interface.SaveChanges();
        }


        public void Delete(int Id)
        {
            var result = _interface.Delete(Id);
            _interface.SaveChanges();
        }
    }
}
