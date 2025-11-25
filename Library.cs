using ConsoleApp9;
using System.Runtime.InteropServices;

internal class Library
{
    public Book[] array { get; set; }

    public Library(params Book[] books)
    {
        array = new Book[books.Length];
        Array.Copy(books, array, books.Length);
    }

    public void print_library()
    {
        for(int i = 0; i< array.Length; i++)
        {
            Console.WriteLine($"{i} : {array[i].Name_of_Book}");
        }
        //foreach (var item in array)
        //{
        //    Console.WriteLine(item.Name_of_Book);
        //}
    }
    public override string ToString()
    {
        string result = string.Empty;
        foreach (Book x in array)
        {
            result += $"{x}, ";
        }
        return result.TrimEnd(',', ' ');
    }

    public static Library operator +(Library lib, Book b)
    {
        int size = lib.array.Length;
        int newSize = size + 1;

        Book[] arr2 = new Book[newSize];

        for (int i = 0; i < size; i++)
        {
            arr2[i] = lib.array[i];
        }

        arr2[newSize - 1] = b;

        lib.array = arr2;
        return lib;
    }



    public static Library operator -(Library lib, string b)
    {

        int size = lib.array.Length;
        int NewSize = size - 1;

        Book[] arr2 = new Book[NewSize];

        int NeedIndex = -1;
        for (int i = 0; i < size; i++)
        {
            if (lib.array[i].Name_of_Book == b)
            {
                NeedIndex = i;
                break;
            }
        }

        if(NeedIndex == -1)
        {
            Console.WriteLine("Not found");
            return lib;
        }

        int index = 0;
        for(int y = 0; y < size; y++)
        {
            if (y == NeedIndex) {
                continue;
            }
            arr2[index++] = lib.array[y];
        }
        lib.array = arr2;
        return lib;
    }

    public static Library operator --(Library lib) {

        int size = lib.array.Length;
        int NewSize = size - 1;
        Book[] arr2 = new Book[NewSize];

        for(int i = 0; i< NewSize; i++)
        {
            arr2[i] = lib.array[i];
        }

        lib.array = arr2;
        return lib;
    }



    public static bool operator ==(Library lib, Book b)
    {
        for(int i = 0; i < lib.array.Length; i++) {
            if (lib.array[i] == b) { 
            return true;
            }
        }

        return false;
    }

    public static bool operator !=(Library lib, Book b)
    {
        bool counert  = false;
        for (int i = 0; i < lib.array.Length; i++)
        {
            if (lib.array[i] == b)
            {
                counert = true;
            }
        }
        if (counert)
        {
            return false;
        }
        else
        {
            return true;
        }

    }


    public Book this[int index]
    {
        get
        {
            if (index < 0)
            {
                index = array.Length + index;
            }

            if (index >= 0 && index < array.Length)
            {
                return array[index];
            }

            throw new IndexOutOfRangeException();
        }

        set
        {
            if (index < 0)
            {
                index = array.Length + index;
            }

            if (index >= 0 && index < array.Length)
            {
                array[index] = value;
                return;
            }

            throw new IndexOutOfRangeException();
        }
    }

}
