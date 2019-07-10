using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.IFinancial;
using Domain.Model.Financial;
using Model.Financial;

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


    public StudentFeeVw GetById(int Id)
    {
        var vw = _interface.Get(Id);
        var result = _mapper.Map<StudentFeeVw>(vw);
        return result;
    }

    public void Add(StudentFee obj)
    {
        var result = _interface.Add(obj);
        _interface.SaveChanges();

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


}

}
