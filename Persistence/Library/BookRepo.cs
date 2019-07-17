using System;
using System.Collections.Generic;
using System.Text;
using Core.ILibrary;
using Domain;
using Domain.Model.library;

namespace Persistence.Library
{
   public  class BookRepo: DbOperation<Book>,IBookRepo
    {

        private SchoolDbContext _db;

        public BookRepo(SchoolDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
