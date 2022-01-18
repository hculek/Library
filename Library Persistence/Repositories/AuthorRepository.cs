using Library_Domain.dbInterfaces;

namespace Library_Persistence.Repositories
{
    public class AuthorRepository  : GenericRepository<Library_Domain.Author.Author>, IAuthorRepository
    {
        public AuthorRepository(ApplicationContext context) : base(context)
        {
        }

        //public IEnumerable<Book> GetPopularBooks(int count)
        //{
        //    return _context.Books.OrderByDescending(d => d.Followers).Take(count).ToList();
        //}
    }
}
