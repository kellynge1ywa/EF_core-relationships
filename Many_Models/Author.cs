using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Many_to_Many.Many_Models
{
    public class Author
    {
         public int AuthorId {get; set;}

        public string? Name {get;set;}

        public string? Email {get; set;}
        //Navigation property
        public List<Book>? Books {get; set;}
    }
}