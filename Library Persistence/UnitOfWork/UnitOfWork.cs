using Library_Domain;
using Library_Domain.dbInterfaces;
using Library_Persistence.Repositories;

namespace Library_Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        //public UnitOfWork()
        //{
        //    UnitOfWork Create()
        //    {
        //        ApplicationContext context = new ApplicationContext();
        //        UnitOfWork uow = new UnitOfWork(context);
        //        return uow;
        //    }

        //}
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Authors = new AuthorRepository(_context);
            Books = new BookRepository(_context);
            Genres = new GenreRepository(_context);
            LibraryMembers = new LibraryMemberRepository(_context);
        }

        public IAuthorRepository Authors { get; private set; }
        public IBookRepository Books { get; private set; }
        public IGenreRepository Genres { get; private set; }
        public ILibraryMemberRepository LibraryMembers { get; private set; }

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
