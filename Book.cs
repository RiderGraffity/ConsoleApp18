using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Book
    {
        public string Name_of_Book { get; set; }

        public Book() {
            Console.Write("Enter name of book :");

            Name_of_Book = Console.ReadLine();
        }

        public Book(string name_of_new_book)
        {
            Name_of_Book = name_of_new_book;
        }

        
        

    }
}
