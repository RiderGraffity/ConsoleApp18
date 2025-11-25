using ConsoleApp9;
using System.Drawing;
using System.Net;


namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library l = new Library();  
            while (true)
            {
                int choose = 0;
                Console.WriteLine("""
1 -> add book
2 -> delete book
3 -> delete book from end
4 -> compare two books
5 -> show by index
6 -> set by index
0 -> exit
""");
            choose = int.Parse(Console.ReadLine());
            if (choose == 1)
                {
                    Book book = new Book();
                    l = l + book;
                    l.print_library();
                }else if(choose == 2)
                {
                    l.print_library();
                    Console.Write("Enter name of book :");
                    string dell_book = Console.ReadLine();
                    l = l - dell_book;
                    l.print_library();
                } else if(choose == 3)
                {
                    l--;
                    l.print_library();
                }
                else if (choose == 4)
                {
                    Console.Write("Enter name of first book: ");
                    string first_book_name = Console.ReadLine();

                    Console.Write("Enter name of second book: ");
                    string second_book_name = Console.ReadLine();

                    // создаём временные книги
                    Book book1 = new Book(first_book_name);
                    Book book2 = new Book(second_book_name);

                    if (book1 == book2)
                    {
                        Console.WriteLine("Books are equal!");
                    }
                    else
                    {
                        Console.WriteLine("Books are NOT equal!");
                    }
                

            }else if (choose == 5)
                {
                    l.print_library();
                    Console.Write("Enter index :");
                    int index = int.Parse(Console.ReadLine());
                    Console.WriteLine(l[index].Name_of_Book);
                }else if (choose == 6)
                {
                    l.print_library();
                    Console.Write("Enter name of book which you whant set :");
                    string name_of_book = Console.ReadLine();

                    Console.Write("Enter index :");
                    int index = int.Parse(Console.ReadLine());

                    l[index].Name_of_Book = name_of_book;
                    l.print_library();
                }

            }
        
        } 
    }
}