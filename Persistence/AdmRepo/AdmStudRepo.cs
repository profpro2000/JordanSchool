using System;
using System.Collections.Generic;
using System.Text;
using Core.IAdmRepo;
using Domain;
using Domain.Model.Adm;

namespace Persistence.AdmRepo
{
  public  class AdmStudRepo:DbOperation<AdmStud>,IAdmStudRepo
    {

        private SchoolDbContext _db;

        public AdmStudRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
