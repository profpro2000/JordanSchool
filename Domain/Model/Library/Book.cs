using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.library
{
    public class Book:AuditModel
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public int AuthorId { set; get; }

        public Author BookAuthor { set; get; }

    }
}
