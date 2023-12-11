using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Connection context = new Connection())
            {
                var auth = new Author() { AuthorId = 101, AuthorName = "Chetan Bhagat" };
                //context.Authors.Add(auth);
                var bk = new Book() { BookId = 1001, BookName = "Life of Pie", BookAuthor = "Irfan", LastIssued = DateTime.Now};
                var myBk = new Book() { BookId = 1002, BookName = "Life of India", BookAuthor = "Jogendar", LastIssued = DateTime.Now };
                var myBook = new Book() { BookId = 1003, BookName = "Discovery Island", BookAuthor = "Michael", LastIssued = DateTime.Parse("22-01-2022") };
                context.Books.Add(myBook);
                context.SaveChanges();
                Console.WriteLine("Data Added"); 
                Console.ReadKey();
            }
        }
    }
}
