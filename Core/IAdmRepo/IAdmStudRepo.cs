using Domain.Model.Adm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.IAdmStudRepo
{
   public interface IAdmStudRepo:IRepo<AdmStud>
    {

        Task<List<AdmStud>> GetAllStud();
        Task<List<AdmStud>> GetStudByParent(int id);
        object GetParentName(int id);

        Task<IEnumerable<object>> GetRegChildrens(int id);
        void UpdateStudSeq(int id);

        Task<List<AdmStud>> GetStudByParentAndSchool(int id, int schoolId);
        Task<IEnumerable<object>> GetRegChildrensBySchool(int id, int SchoolId);

    }
}
