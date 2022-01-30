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
            Author = new AuthorRepository(_context);
            Book = new BookRepository(_context);
            Genre = new GenreRepository(_context);
            LibraryMember = new LibraryMemberRepository(_context);
        }

        public IAuthorRepository Author { get; private set; }
        public IBookRepository Book { get; private set; }
        public IGenreRepository Genre { get; private set; }
        public ILibraryMemberRepository LibraryMember { get; private set; }

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
