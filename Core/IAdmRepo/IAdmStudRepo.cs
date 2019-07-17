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
    }
}
