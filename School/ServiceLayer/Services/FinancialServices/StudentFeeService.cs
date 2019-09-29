using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using AutoMapper;
using Core;
using Core.IFinancial;
using Domain.Model.Financial;
using Microsoft.AspNetCore.Mvc;
using Model.Financial;
using FinStudCard = Domain.Model.Financial.FinStudCard;

namespace School.ServiceLayer.Services.FinancialServices
{
    public class StudentFeeService
    {
        private IMapper _mapper;
        private IStudentFeeRepo _interface;

        public StudentFeeService(IMapper mapper, IStudentFeeRepo @interface)
        {
            _mapper = mapper;
            _interface = @interface;
        }
   

    public async Task<List<StudentFeeVw>> GetAll()
    {
        var vw = await _interface.GetAllAsync();
        var result = _mapper.Map<List<StudentFeeVw>>(vw);
        return result;
    }

        public async Task<IEnumerable<object>> GetPaymentList(int YearId, int StudId)
        {
            var vw = await _interface.GetPaymentList(YearId, StudId);
           
            return vw;
        }

        public async Task<IEnumerable<object>> GetStudentFeesByParam(StudentFeeFilter studentFeeFilter)
        {
            var vw = await _interface.GetStudentFeesByParam(studentFeeFilter);

            return vw;
        }
        public StudentFeeVw GetById(int Id)
        {
        var vw = _interface.Get(Id);
        var result = _mapper.Map<StudentFeeVw>(vw);
        return result;
    }

        public Task<IEnumerable<object>> GetStudFeesListByParent(int YearId ,int Id)
        {
            var vw = _interface.GetStudFeesListByParent(YearId,Id);
           // var result = _mapper.Map<StudentFeeVw>(vw);
            return vw;
        }


        //public Task<IEnumerable<object>> GetChequesListByFeeId( int FeeId)
        //{
        //    var v = _interface.GetChequesListByFeeId(FeeId);
        //    return v;
        //}
        



        public Task<IEnumerable<object>> GetStudFeesDtl(int YearId,int StudId)
        {
            var vw = _interface.GetStudFeesDtl(YearId,StudId);
            // var result = _mapper.Map<StudentFeeVw>(vw);
            return vw;
        }

        public StudentFeeVw Add(StudentFee obj)
    {

            //if (!ModelState.IsValid)
            //{
            //   // Response.StatusCode = 400;
            //    //return Ok(new Res(false, "State not valid", obj));
            //}

            var result = _interface.Add(obj);
            _interface.SaveChanges();


            //var idx = obj.Id;
            //var xx = idx;
            var vw = _interface.getByPayemtId(obj.Id);
            var result2= _mapper.Map<StudentFeeVw>(vw);
            return result2;
           //eturn _interface.getByPayemtId(obj.Id);







        }

        public void Update(int id, StudentFeeVw obj)
    {
        var tab = _mapper.Map<StudentFee>(obj);
        _interface.Update(id, tab);
        _interface.SaveChanges();
    }


    public void Delete(int Id)
    {
        var result = _interface.Delete(Id);
        _interface.SaveChanges();
    }

        public async Task<IEnumerable<object>> FinStudCard(int YearId, int ParentId)
        {
            var v = await _interface.FinStudCard(YearId, ParentId);
            return v;
        }

        public async Task<IEnumerable<object>> FinStudCardByStud(int YearId, int StudId)
        {
            var v = await _interface.FinStudCardByStud(YearId, StudId);
            return v;
        }


    }

}
