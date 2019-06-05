﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SqlLiteLibraryPlay;

namespace SqlLiteLibraryPlay.Migrations
{
    [DbContext(typeof(SqlLiteLibraryPlayContext))]
    [Migration("20190605231433_AuthorToBook")]
    partial class AuthorToBook
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("SqlLiteLibraryPlay.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<int?>("BookShelfID");

                    b.Property<string>("Genre");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("BookShelfID");

                    b.ToTable("books");
                });

            modelBuilder.Entity("SqlLiteLibraryPlay.BookShelf", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("bookshelves");
                });

            modelBuilder.Entity("SqlLiteLibraryPlay.Book", b =>
                {
                    b.HasOne("SqlLiteLibraryPlay.BookShelf")
                        .WithMany("books")
                        .HasForeignKey("BookShelfID");
                });
#pragma warning restore 612, 618
        }
    }
}
