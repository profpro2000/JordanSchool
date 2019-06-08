using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Core.IStudRepo;
using Domain.Model.Stud;
using Model.Stud;

namespace School.ServiceLayer.Services.StudServices
{
    public class StudMasterService
    {
        private IMapper _mapper;
        private IStudMasterRepo _interface;

        public StudMasterService(IMapper mapper, IStudMasterRepo @interface)
        {
            _mapper = mapper;
            _interface = @interface;
        }

        public async Task<List<StudMasterVw>> GetAll()
        {
            var vw = await _interface.GetAllAsync();
            var result = _mapper.Map<List<StudMasterVw>>(vw);
            return result;
        }


        public async Task<List<StudMasterVw>> GetById(int id)
        {
            var vw = await _interface.GetAllWhereAsync(p => p.Id == id);
            var result = _mapper.Map<List<StudMasterVw>>(vw);
            return result;
        }

        public void Insert(StudMasterVw obj)
        {
            var table = _mapper.Map<StudMaster>(obj);
            _interface.Add(table);
            _interface.SaveChanges();
        }

        public void Update(int id, StudMasterVw obj)
        {
            var table = _mapper.Map<StudMaster>(obj);
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