using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDb
{
    internal class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string IssuedBook { get; set; }  
        public DateTime? DateOfBookIssue { get; set; }

    }
}
