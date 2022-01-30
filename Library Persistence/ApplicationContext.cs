using System.Data.Entity;
using Library_Domain.Author;
using Library_Domain.Book;
using Library_Domain.Genre;
using Library_Domain.LibraryMember;

namespace Library_Persistence
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("name=LibraryDBConnection") /*(@hardcoded connection string... )*/
        {
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<LibraryMember> LibraryMember { get; set; }
    }
}
