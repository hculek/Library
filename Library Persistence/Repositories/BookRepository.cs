using Library_Domain.dbInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
