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
            BookShelf BottomLeft = new BookShelf("BottomLeft", new Book[8]);
            //Bottom left shelfonly holds 8 books

            Book b = new Book("The Foos and The Hound", "Rob Stanley", "Horror");
            Book b1 = new Book("blergh", "jum k", "fiction");
            Book b2 = new Book("grey", "Rob hun", "fact");
            Book b3 = new Book("jill waked one mile", "peggy Stanley", "Horror");
            Book b4 = new Book("6 pills", "Rob Stanley", "Thriller");
            Book b5 = new Book("Joey went back", "Joey Back", "Boigaphy");
            Book b6 = new Book("Hal About it", "Hal hallerson", "Comedy");
            Book b7 = new Book("TDave", "Theodore David", "Biography");
            Book b8 = new Book("Alphabet", "Kim Who", "Childrens");
 
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

        public BookShelf(string name, Book[] _books)
        {
            name = Name;

        }
    }
}
