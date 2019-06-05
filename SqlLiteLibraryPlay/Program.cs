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
            Book b = new Book("The Foos and The Hound", "Rob Stanley", "Horror");
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
        public string Author { get; set; }
        public string Genre { get; set; }

        public Book(string title, string author, string genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }
    }

    public class BookShelf
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Book[] books { get; set; }

        public BookShelf(string name)
        {
            name = Name;
        }
    }
}
