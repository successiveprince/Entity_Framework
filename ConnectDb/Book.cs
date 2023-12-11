using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDb
{
    internal class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public DateTime LastIssued { get; set; }      
        public string BookAuthor { get; set; }  
    }
}
