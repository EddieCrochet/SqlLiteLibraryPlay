using System;
using System.Data.SQLite;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SqlLiteLibraryPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class SqlLiteLibraryPlayContext : DbContext
    {
        public DbSet<Book> books { get; set; }
        public DbSet<BookShelf> bookshelves { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=SqlLiteLibraryPlay.db");
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
