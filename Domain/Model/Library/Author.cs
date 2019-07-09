using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model.library
{
    public class Author:AuditModel
    {
        public int Id { set; get; }
        public string ArName { set; get; }
        public string LaName { set; get; }
        public ICollection<Book> AuthorBooks { set; get; }
    }
}
