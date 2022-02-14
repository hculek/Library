using Library_Domain.dbInterfaces;
using Library_Domain.Objects;

namespace Library_Persistence.Repositories
{
    public class BookRepository  : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(ApplicationContext context) : base(context)
        {
        }

        //public IEnumerable<Book> GetPopularBooks(int count)
        //{
        //    return _context.Books.OrderByDescending(d => d.Followers).Take(count).ToList();
        //}

        // metoda za ucitati sve zanrove
        // metoda za ucitati sve autore
    }
}
