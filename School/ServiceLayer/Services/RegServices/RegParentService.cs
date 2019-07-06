using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Core.IRegRepo;
using Domain.Model.Reg;
using Model.Reg;

namespace School.ServiceLayer.Services.RegServices
{
    public class RegParentService
    {
        private IMapper _mapper;
        private IRegParentRepo _interface;

        public RegParentService(IMapper mapper, IRegParentRepo @interface)
        {
            _mapper = mapper;
            _interface = @interface;
        }


        public async Task<List<RegParentVw>> GetAll()
        {
            var vw = await _interface.GetAll();
            var result = _mapper.Map<List<RegParentVw>>(vw);
            return result;
        }

        public async Task<List<RegParentVw>> GetById(int id)
        {
            var vw = await _interface.GetAllWhereAsync(p => p.Id == id);
            var result = _mapper.Map<List<RegParentVw>>(vw);
            return result;
        }

        
        public async Task<IEnumerable<object>> ParentDetail(int id)
        {
            var data = await _interface.ParentDetail(id);
            return data;

        }

        public void Insert(RegParentVw obj)
        {
            var table = _mapper.Map<RegParent>(obj);
            _interface.Add(table);
            _interface.SaveChanges();
        }

        public void Update(int id, RegParentVw obj)
        {
            var table = _mapper.Map<RegParent>(obj);
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