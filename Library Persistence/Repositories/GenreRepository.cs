using Library_Domain.dbInterfaces;

namespace Library_Persistence.Repositories
{
    public class GenreRepository  : GenericRepository<Library_Domain.Genre.Genre>, IGenreRepository
    {
        public GenreRepository(ApplicationContext context) : base(context)
        {
        }

        //public IEnumerable<Book> GetPopularBooks(int count)
        //{
        //    return _context.Books.OrderByDescending(d => d.Followers).Take(count).ToList();
        //}
    }
}
