using System.Data.Entity;
using Library_Domain.Objects.Author;
using Library_Domain.Objects.Book;
using Library_Domain.Objects.Genre;
using Library_Domain.Objects.LibraryMember;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Persistence
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext() : base("name=LibraryDBConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<LibraryMember> LibraryMembers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // PostgreSQL uses the public schema by default - not dbo.
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
