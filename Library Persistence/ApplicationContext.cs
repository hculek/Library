using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Domain;
using Library_Domain.Author;
using Library_Domain.Book;
using Library_Domain.Genre;
using Library_Domain.LibraryMember;
using Npgsql;

namespace Library_Persistence
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<LibraryMember> LibraryMembers { get; set; }
    }
}
