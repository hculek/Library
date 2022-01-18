using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain.dbInterfaces
{
    public interface IBookRepository : IGenericRepository<Book.Book>
    {
        //implemented IGenericRepository functions
        //adding more functions ie:
        //IEnumerable<Book> GetPopularBooks(int count);
    }
}
