﻿using System.Data.Entity;
using Library_Domain.Objects.Author;
using Library_Domain.Objects.Book;
using Library_Domain.Objects.Genre;
using Library_Domain.Objects.LibraryMember;
using Library_Domain.Objects.JunctionObj;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Persistence
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext() : base("name=LibraryDBConnection")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public virtual DbSet<Book> books { get; set; }
        public virtual DbSet<Author> authors { get; set; }
        public virtual DbSet<Genre> genres { get; set; }
        public virtual DbSet<LibraryMember> librarymembers { get; set; }
        public virtual DbSet<BookGenre> bookGenres { get; set; }
        public virtual DbSet<BookAuthor> bookAuthors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // PostgreSQL uses the public schema by default - not dbo.
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
