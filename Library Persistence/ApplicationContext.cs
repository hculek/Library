using System.Data.Entity;
using Library_Domain.Objects;
using Library_Domain.Objects.LibraryMember;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // PostgreSQL uses the public schema by default - not dbo.
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);


            // fluent API for book
            modelBuilder.Entity<Book>().ToTable("books")
                .HasMany(b => b.Authors)
                .WithMany(a => a.Books)
                .Map(m => m.ToTable("books_authors")
                .MapLeftKey("book_id")
                .MapRightKey("author_id"));

            modelBuilder.Entity<Book>().ToTable("books")
              .HasMany(b => b.Genres)
              .WithMany(g => g.Books)
              .Map(m => m.ToTable("books_genres")
              .MapLeftKey("book_id")
              .MapRightKey("genre_id"));
        }
    }
}
