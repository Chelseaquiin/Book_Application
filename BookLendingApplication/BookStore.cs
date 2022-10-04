using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLendingApplication
{
    class BookStore
    {
        private List<Books> books { get; set; } = new List<Books>();


        public void AddABook(Books book)
        {
            books.Add(book);
        }

        public void ViewAllBooks()
        {
            foreach (Books book in books)
            {
                Console.WriteLine($"Books: {book.Name}, {book.Author}");
            }
        }
    }
}
