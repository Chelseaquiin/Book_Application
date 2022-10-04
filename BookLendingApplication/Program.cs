using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLendingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our BookStore");
            Console.WriteLine("Please select an Option");
            Console.WriteLine("1. Add A Book");
            Console.WriteLine("2. View All Books");
            Console.WriteLine("0. Exit");

            BookStore bookstore = new BookStore();

            int userInput = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Book Name: ");
                        string bookName = Console.ReadLine();
                        Console.WriteLine("Book Author: ");
                        string bookAuthor = Console.ReadLine();

                        Books books = new Books(bookName, bookAuthor);

                        bookstore.AddABook(books);

                        break;
                    case 2:

                        bookstore.ViewAllBooks();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Select a valid option");
                        break;

                }
                Console.WriteLine("Select an Option");
                userInput = Convert.ToInt32(Console.ReadLine());

            }

        }
    }
}
