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
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<LibraryMember> LibraryMembers { get; set; }
    }
}
