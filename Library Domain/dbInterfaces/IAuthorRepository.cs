namespace Library_Domain.dbInterfaces
{
    public interface IAuthorRepository : IGenericRepository<Author.Author>
    {
        //implemented IGenericRepository functions
        //adding more functions ie:
        //IEnumerable<Book> GetPopularBooks(int count);
    }
}
