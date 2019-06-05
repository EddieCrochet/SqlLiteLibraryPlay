using System;
using System.Data.SQLite;

namespace SqlLiteLibraryPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public Book(int id, string title, string genre)
        {
            id = ID;
            Title = title;
            Genre = genre;
        }
    }

    public class BookShelf
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Book[] books { get; set; }

        public BookShelf(int id, string name)
        {
            id = ID;
            name = Name;
        }
    }
}
