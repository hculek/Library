using Library_Domain;
using Library_Domain.dbInterfaces;
using Library_Persistence.Repositories;

namespace Library_Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Authors = new AuthorRepository(_context);
            Books = new BookRepository(_context);
            Genres = new GenreRepository(_context);
            LibraryMembers = new LibraryMemberRepository(_context);
            BookAuthors = new BookAuthorRepository(_context);
            BookGenres = new BookGenreRepository(_context);

        }

        public IAuthorRepository Authors { get; private set; }
        public IBookRepository Books { get; private set; }
        public IGenreRepository Genres { get; private set; }
        public ILibraryMemberRepository LibraryMembers { get; private set; }
        public IBookAuthorRepository BookAuthors { get; private set; }
        public IBookGenreRepository BookGenres { get; private set; }

        public int Save()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
