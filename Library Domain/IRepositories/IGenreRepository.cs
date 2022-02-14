using Library_Domain.Objects;
namespace Library_Domain.dbInterfaces
{
    public interface IGenreRepository : IGenericRepository<Genre>
    {
        //implemented IGenericRepository functions
        //adding more functions ie:
        //IEnumerable<Book> GetPopularBooks(int count);
    }
}
