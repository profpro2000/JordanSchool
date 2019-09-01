using Domain.Model.AddLookups;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.IAddLookupsRepo
{
  public  interface ILkpYearRepo:IRepo<LkpYear>
    {
        Task<LkpYear> GetCurrentYear();
    }
}
