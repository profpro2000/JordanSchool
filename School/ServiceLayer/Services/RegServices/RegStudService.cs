using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Core.IRegRepo;
using Domain.Model.Reg;
using Model.Reg;

namespace School.ServiceLayer.Services.RegServices
{
    public class RegStudService
    {
        private IMapper _mapper;
        private IRegStudRepo _interface;

        public RegStudService(IMapper mapper, IRegStudRepo @interface)
        {
            _mapper = mapper;
            _interface = @interface;
        }

        public async Task<List<RegStudVw>> GetAll()
        {
            var vw = await _interface.GetAllAsync();
            var result = _mapper.Map<List<RegStudVw>>(vw);
            return result;
        }


        public async Task<List<RegStudVw>> GetById(int id)
        {
            var vw = await _interface.GetAllWhereAsync(p => p.Id == id);
            var result = _mapper.Map<List<RegStudVw>>(vw);
            return result;
        }

        public void Insert(RegStudVw obj)
        {
            var table = _mapper.Map<RegStud>(obj);
            _interface.Add(table);
            _interface.SaveChanges();
        }

        public void Update(int id, RegStudVw obj)
        {
            var table = _mapper.Map<RegStud>(obj);
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