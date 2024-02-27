using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2024_02_07
{
    class Book
    {
        public string Title;
        public string Author;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an object of the Book class
            Book book1 = new Book();

            // Set values for the properties
            book1.Title = "Sample Book";
            book1.Author = "John Doe";

            // Display the information on the console
            Console.WriteLine("Book Title:" + book1.Title);
            Console.WriteLine("Author: " + book1.Author);

            Console.ReadLine();
        }
    }

}
