namespace Library_Domain.dbInterfaces
{
    public interface IGenreRepository : IGenericRepository<Genre.Genre>
    {
        //implemented IGenericRepository functions
        //adding more functions ie:
        //IEnumerable<Book> GetPopularBooks(int count);
    }
}
