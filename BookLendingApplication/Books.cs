
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BookLendingApplication
{
    class Books
    {
        public Books(string name, string author)
        {
            Name = name;
            Author = author;
        }

        public string Name { get; set; }
        public string Author { get; set; }
    }
}
