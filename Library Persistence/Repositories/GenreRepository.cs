using Library_Domain.dbInterfaces;

namespace Library_Persistence.Repositories
{
    public class GenreRepository  : GenericRepository<Library_Domain.Genre.Genre>, IGenreRepository
    {
        public GenreRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
