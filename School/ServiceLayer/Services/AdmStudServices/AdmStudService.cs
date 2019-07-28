using AutoMapper;
using Core.IAdmStudRepo;
using Domain.Model.Adm;
using Domain.Model.Reg;
using Model.Adm;
using Model.Reg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.ServiceLayer.Services.AdmStudServices
{
    public class AdmStudService
    {
       private IMapper _mapper;
       private IAdmStudRepo _interface;

        public AdmStudService(IMapper mapper, IAdmStudRepo Interface)
        {
            _mapper = mapper;
            _interface = Interface;
        }

      

        public async Task<List<AdmStudVw>> GetAll()
        {
            var vw = await _interface.GetAllStud();
            var result = _mapper.Map<List<AdmStudVw>>(vw);
            return result;
        }

        public async Task<AdmStudVw> GetById(int id)
        {
            var vw = await _interface.GetAsync(p => p.Id == id);
            var result = _mapper.Map<AdmStudVw>(vw);
            return result;
        }

        public async Task<List<AdmStudVw>> GetByParent(int id)
        {
            var vw = await _interface.GetStudByParent(id);
            var result = _mapper.Map<List<AdmStudVw>>(vw);
            return result;
        }

        public async Task<List<object>>GetRegChildrens(int id)
        {
            var vw = await _interface.GetRegChildrens(id);
            var result = _mapper.Map<List<object>>(vw);
            return result;
        }
       

        public object GetParentName(int id)
        {
            var vw =  _interface.GetParentName(id);
           // var result = _mapper.Map<AdmStudVw>(vw);
            return vw;
        }


        /* public async Task<IEnumerable<object>> ParentDetail(int id)
         {
             var data = await _interface.ParentDetail(id);
             return data;

         }*/

        public void Insert(AdmStudVw obj)
        {
            var table = _mapper.Map<AdmStud>(obj);
            _interface.Add(table);
            _interface.SaveChanges();
        }

        public void Update(int id, AdmStudVw obj)
        {
            var table = _mapper.Map<AdmStud>(obj);
            _interface.Update(id, table);
            _interface.SaveChanges();
        }
        public void Delete(int id)
        {
            _interface.Delete(id);
            _interface.SaveChanges();
        }

        public void UpdateStudSeq(int id)
        {
            _interface.UpdateStudSeq(id);
            _interface.SaveChanges();
        }

       
    }
}
