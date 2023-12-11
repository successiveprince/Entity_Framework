using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDb
{
    internal class Author
    {
       
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }


       // public ICollection<Book> AllBooks { get; set; }

    }
}
