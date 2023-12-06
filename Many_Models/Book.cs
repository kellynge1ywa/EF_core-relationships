using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Many_to_Many.Many_Models
{
    public class Book
    {
        // [key]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId {get; set;}
        
        public string? Title {get; set;}

        public string? Description {get; set;}

        //public int AuthorId {get; set;}
        //Navigation property
        public List<Author>? M_Authors {get; set;}
    }
}