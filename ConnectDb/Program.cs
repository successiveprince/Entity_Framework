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

                bool ch = true;

                do
                {
                    Console.WriteLine("Welcome to my Library\n");
                    Console.WriteLine("Options :");
                    Console.WriteLine("1. Add Book");
                    Console.WriteLine("2. Add Author");
                    Console.WriteLine("3. Add Person");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Enter Your Choice :");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1 : 
                            Console.WriteLine("Enter Book Id :");
                            var bId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Book Name : ");
                            var bName = Console.ReadLine();
                            Console.WriteLine("Last Issued Date : ");
                            var bDate = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Author Name : ");
                            var bAuthor = Console.ReadLine();


                            var bObj = new Book() { BookId = bId , BookAuthor = bAuthor  , BookName = bName , LastIssued = bDate};
                            context.Books.Add(bObj);
                            break;
                        case 2 :
                            Console.WriteLine("Enter Author Id :");
                            var aId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Author Name : ");
                            var aName = Console.ReadLine();

                            var aObj = new Author() { AuthorId = aId, AuthorName = aName };
                            context.Authors.Add(aObj);
                            break;

                        case 3 :
                            Console.WriteLine("Enter Person Id :");
                            var pId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Person Name : ");
                            var pName = Console.ReadLine();
                            Console.WriteLine("Issued Book : ");
                            var pBook = Console.ReadLine();
                            Console.WriteLine("Book Issued Date : ");
                            var pBookDate = DateTime.Parse(Console.ReadLine());

                            var pObj = new Person() { PersonId = pId , PersonName = pName , IssuedBook = pBook , DateOfBookIssue = pBookDate};
                            context.Persons.Add(pObj);
                            break;

                        case 4 :
                            Environment.Exit(1);
                            break;




                    }
                    Console.WriteLine("Do you want to continue (Y/N) : ");
                    var input = Console.ReadLine();
                    if(input == "N" ||  input == "n")
                    {
                        ch = false;
                    }
                }
                while (ch);

                //var auth = new Author() { AuthorId = 101, AuthorName = "Chetan Bhagat" };
                ////context.Authors.Add(auth);
                //var bk = new Book() { BookId = 1001, BookName = "Life of Pie", BookAuthor = "Irfan", LastIssued = DateTime.Now};
                //var myBk = new Book() { BookId = 1002, BookName = "Life of India", BookAuthor = "Jogendar", LastIssued = DateTime.Now };
                //var myBook = new Book() { BookId = 1003, BookName = "Discovery Island", BookAuthor = "Michael", LastIssued = DateTime.Parse("22-01-2022") };
                //context.Books.Add(myBook);
                context.SaveChanges();
                Console.WriteLine("Data Added"); 
                Console.ReadKey();
            }
        }
    }
}
