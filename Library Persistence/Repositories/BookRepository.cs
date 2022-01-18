using Library_Domain.dbInterfaces;

namespace Library_Persistence.Repositories
{
    public class BookRepository  : GenericRepository<Library_Domain.Book.Book>, IBookRepository
    {
        public BookRepository(ApplicationContext context) : base(context)
        {
        }

        //public IEnumerable<Book> GetPopularBooks(int count)
        //{
        //    return _context.Books.OrderByDescending(d => d.Followers).Take(count).ToList();
        //}
    }
}
