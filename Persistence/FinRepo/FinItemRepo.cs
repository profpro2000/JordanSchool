using System;
using System.Collections.Generic;
using System.Text;
using Core.IFinRepo;
using Domain;
using Domain.Model.Fin;

namespace Persistence.FinRepo
{
    public class FinItemRepo : DbOperation<FinItem>, IFinItemRepo
    {
        private SchoolDbContext _db;

        public FinItemRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
