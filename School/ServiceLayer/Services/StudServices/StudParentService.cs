using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Core.IStud;
using Domain.Model.Stud;
using Model.Stud;

namespace School.ServiceLayer.Services.StudServices
{
    public class StudParentService
    {
        private IMapper _mapper;
        private IStudParentRepo _interface;

        public StudParentService(IMapper mapper, IStudParentRepo @interface)
        {
            _mapper = mapper;
            _interface = @interface;
        }


        public async Task<List<StudParentVw>> GetAll()
        {
            var vw = await _interface.GetAllAsync();
            var result = _mapper.Map<List<StudParentVw>>(vw);
            return result;
        }

        public async Task<List<StudParentVw>> GetById(int id)
        {
            var vw = await _interface.GetAllWhereAsync(p => p.Id == id);
            var result = _mapper.Map<List<StudParentVw>>(vw);
            return result;
        }

        public void Insert(StudParentVw obj)
        {
            var table = _mapper.Map<StudParent>(obj);
            _interface.Add(table);
            _interface.SaveChanges();
        }

        public void Update(int id, StudParentVw obj)
        {
            var table = _mapper.Map<StudParent>(obj);
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