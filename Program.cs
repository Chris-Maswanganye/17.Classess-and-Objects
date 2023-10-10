using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _17.Classess_and_Objects
{
    internal class Program
    {
        public String tittle;
        public String author;
        public String pages;
    }

       
        static void Main(string[] args)
        {
            Book book1 = new Book();//create a new book object
                                    //creation of a new book
            book1.tittle = "Harry Potter";
            book1.author = "JH Rowlin";
            book1.pages = 400;

            Book book2 = new book();
            book1.tittle = "Lord of rings";
            book1.author = "Tolein";
            book1.pages = 900;

            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.title);
            //freeze
            Console.ReadLine();
        }
    }
}
